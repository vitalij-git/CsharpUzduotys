using Microsoft.VisualStudio.TestTools.UnitTesting;
using EgzaminasRestoranas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminasRestoranas.Models.Tests
{
    [TestClass()]
    public class WorkerStatusTests
    {
        [TestMethod()]
        //public void GetWorkerStatusTest()
        //{
        //    Assert.Fail();
        //}
        public void GetWorkerStatus_ReturnsCorrectData()
        {
            // Arrange
            var workerStatus = new WorkerStatus(); 

            // Act
            List<string> statusList = workerStatus.GetWorkerStatus();

            // Assert
            Assert.IsNotNull(statusList);
            Assert.AreEqual(2, statusList.Count);
            Assert.IsInstanceOfType(statusList, typeof(List<string>));
        }
    }
}