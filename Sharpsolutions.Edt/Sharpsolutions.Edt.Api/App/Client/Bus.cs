using Castle.Core.Logging;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Microsoft.WindowsAzure;
using Sharpsolutions.Edt.System;
using Sharpsolutions.Edt.System.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Sharpsolutions.Edt.System.Logging;
using System.Runtime.Serialization.Json;
using Sharpsolutions.Edt.System.Serialization.Json;

namespace Sharpsolutions.Edt.Api.App.Client {
    public class Bus : IBus {
		private IJobService _JobService;
		private readonly ILogger _Logger;
        public Bus(IJobService jobservice,  ILoggerFactory loggerFactory) {
            _Logger = loggerFactory.Create(Loggers.Commanding.Producer);

			_JobService = jobservice;
        }

        public void Publish<TCommand>(TCommand command) where TCommand : ICommand {

            if (command.Id == default(Guid))
            {
                throw new CommandMissingIdException();
            }

            string connectionString = CloudConfigurationManager.GetSetting(Settings.Bus.ConfigKey);
            
            NamespaceManager namespaceManager = NamespaceManager.CreateFromConnectionString(connectionString);
            if (!namespaceManager.QueueExists(Settings.Bus.Queue.SendCommand)) {
                _Logger.InfoFormat("Queue does not exist creating queue {0}", Settings.Bus.Queue.SendCommand);
                QueueDescription queueDescription = namespaceManager.CreateQueue(Settings.Bus.Queue.SendCommand);
            }

            QueueClient Client = QueueClient.CreateFromConnectionString(connectionString, Settings.Bus.Queue.SendCommand);

            DataContractJsonSerializer serializer = JsonSerializerFactory.Create(command);

            BrokeredMessage message = new BrokeredMessage(command, serializer) { MessageId = command.Id.ToString()};

            _Logger.DebugFormat("Dispatching message with id {0}", message.MessageId);
			_JobService.New(command);

            Client.SendAsync(message);
        }
    }
}