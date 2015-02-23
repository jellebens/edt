using Moq;
using NUnit.Framework;
using Sharpsolutions.Edt.System.Command;
using Sharpsolutions.Edt.System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Tests.Command {
    [TestFixture]
    public class JobServiceTests {
        private static Guid commandId = Guid.Parse("{A35E5D85-B2E7-4996-BCA8-75B317C61B86}");
        [Test]
        public void CreateShouldCreateNewJobAndAdd() {


            Mock<IJobRepository> repository = new Mock<IJobRepository>();
            Mock<ICommand> command = new Mock<ICommand>();

            repository.Setup(r => r.Add(It.Is<Job>(j => j.Status == JobStatus.New)));

            JobService JobService = new JobService(repository.Object);

            JobService.New(command.Object);

            repository.VerifyAll();
        }

        [Test]
        public void StartShouldGetJobStartAndAdd() {
            Mock<IJobRepository> repository = new Mock<IJobRepository>();
            Mock<ICommand> command = new Mock<ICommand>();
            command.Setup(x => x.Id).Returns(commandId);
            Mock<Job> jobMock = new Mock<Job>();
            jobMock.Setup(j => j.Start());

            repository.Setup(r => r.Get(commandId)).Returns(jobMock.Object);

            repository.Setup(r => r.Add(It.IsAny<Job>()));

            JobService JobService = new JobService(repository.Object);

            JobService.Start(command.Object);

            repository.VerifyAll();
            jobMock.VerifyAll();
        }

        [Test]
        public void CompleteShouldGetJobCompleteAndAdd() {
            Mock<IJobRepository> repository = new Mock<IJobRepository>();
            Mock<ICommand> command = new Mock<ICommand>();
            command.Setup(x => x.Id).Returns(commandId);
            Mock<Job> jobMock = new Mock<Job>();
            jobMock.Setup(j => j.Complete());

            repository.Setup(r => r.Get(commandId)).Returns(jobMock.Object);

            repository.Setup(r => r.Add(It.IsAny<Job>()));

            JobService JobService = new JobService(repository.Object);

            JobService.Complete(command.Object);

            repository.VerifyAll();
            jobMock.VerifyAll();
        }
    }
}
