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
            SqlWorkerRepository workerRepository = new SqlWorkerRepository();

            // Act
            Dictionary<int, List<Worker>> result = workerRepository.GetAll();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
           
        }

    }
}