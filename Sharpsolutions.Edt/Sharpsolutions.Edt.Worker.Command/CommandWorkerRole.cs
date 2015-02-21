using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.ServiceRuntime;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Sharpsolutions.Edt.System;
using Castle.Core.Logging;
using Sharpsolutions.Edt.System.Command;
using Sharpsolutions.Edt.System.Logging;
using System.Runtime.Serialization.Json;
using Sharpsolutions.Edt.System.Serialization.Json;
using Sharpsolutions.Edt.Contracts.Command.Account;
using Sharpsolutions.Edt.Handler.Command.Castle.Installer;
using System.Runtime.Serialization;
using Sharpsolutions.Edt.Data.Castle.Installers;
using Sharpsolutions.Edt.Data.Azure;

namespace Sharpsolutions.Edt.Worker.Command {
    
    public class CommandWorkerRole : RoleEntryPoint {
        // The name of your queue
        private const string QueueName = Settings.Bus.Queue.SendCommand;
        private IWindsorContainer _Container;
        private ILogger _Logger = NullLogger.Instance;
        private IJobRepository _JobRepository;

        // QueueClient is thread-safe. Recommended that you cache 
        // rather than recreating it on every request
        private QueueClient _Client;
        private ManualResetEvent _CompletedEvent = new ManualResetEvent(false);


        public override void Run() {
            _Client.OnMessage(HandleMessage);

            _CompletedEvent.WaitOne();
        }

        private void HandleMessage(BrokeredMessage receivedMessage) {
            try {
                _Logger.InfoFormat("Processing message: {0}. DeliveryCount: {1}", receivedMessage.MessageId,
                    receivedMessage.DeliveryCount);

                DataContractJsonSerializer serializer = JsonSerializerFactory.Create<RegisterUser>();
                dynamic command = receivedMessage.GetBody<ICommand>(serializer);

                ICommandProcessor processor = _Container.Resolve<ICommandProcessor>();
                Job job = Job.Create(command.Id);
                try {
                    _JobRepository.Add(job);
                    
                    processor.Execute(command);

                    _Logger.InfoFormat("Handled message {0}", receivedMessage.MessageId);
                    receivedMessage.Complete();
                    job.Complete();
                    _JobRepository.Add(job);
                } finally {
                    _Container.Release(processor);
                }
            } catch (InvalidCastException e) {
                _Logger.ErrorFormat(e, "An InvalidCastException has been caught moving message to deadletter");
                receivedMessage.DeadLetter("Unknown Message can not cast to ICommand", e.Message);
            } catch (SerializationException e) {
                _Logger.ErrorFormat(e, "An SerializationException has been caught moving message to deadletter {0}.", e.Message);
                receivedMessage.DeadLetter("Can not deserialize message", e.Message);
            } catch (Exception e) {
                _Logger.FatalFormat(e, "An Exception Has been caught: {0}", e.Message);
            }
        }



        public override bool OnStart() {
            ConfigureContainer();
            ConfigureWorker();

            return base.OnStart();
        }

        private void ConfigureContainer() {
            _Container = new WindsorContainer();

            _Container.Install(FromAssembly.This());
            _Container.InstallFrom()
                            .System()
                            .Command()
                            .Data();

            ILoggerFactory factory = _Container.Resolve<ILoggerFactory>();
            _Logger = factory.Create(Loggers.Commanding.Worker);
            _JobRepository = _Container.Resolve<IJobRepository>();
        }

        private void ConfigureWorker() {
            // Set the maximum number of concurrent connections 
            ServicePointManager.DefaultConnectionLimit = 12;
            // Create the queue if it does not exist already
            string connectionString = CloudConfigurationManager.GetSetting(Settings.Bus.ConfigKey);
            var namespaceManager = NamespaceManager.CreateFromConnectionString(connectionString);
            if (!namespaceManager.QueueExists(QueueName)) {
                namespaceManager.CreateQueue(QueueName);
            }

            // Initialize the connection to Service Bus Queue
            _Client = QueueClient.CreateFromConnectionString(connectionString, QueueName);
        }

        public override void OnStop() {
            // Close the connection to Service Bus Queue
            _Client.Close();
            _Container.Dispose();
            _CompletedEvent.Set();

            base.OnStop();
        }
    }
}
