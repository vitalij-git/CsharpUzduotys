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
    public class SqlWorkerRepositoryTests
    {

        [TestMethod()]
        public void GetAllTest()
        {
            // Arrange
            SqlWorkerRepository workerRepository = new SqlWorkerRepository();

            // Act
            Dictionary<int, List<Worker>> result = workerRepository.GetAll();

            // Assert
            Assert.IsNotNull(result);
            
        }

        [TestMethod()]
        public void GetByIdTest()
        { 
            // Arrange
            SqlWorkerRepository workerRepository = new SqlWorkerRepository();
            // Act
            Worker worker = workerRepository.GetById(1);
            // Assert
            Assert.IsNotNull(worker);
        }

       
    }
}