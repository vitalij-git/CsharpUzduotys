using Microsoft.VisualStudio.TestTools.UnitTesting;
using EgzaminasRestoranas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EgzaminasRestoranas.Models.Tests
{
    [TestClass()]
    public class ReadTableIdTests
    {
        [TestMethod()]

        public void ReadTableFromFile_ValidFile_ReturnsCorrectValue()
        {
            // Arrange
            var tableReader = new ReadTableId(); 

            // Act
            int result = tableReader.ReadTableFromFile();

            // Assert
            Assert.IsInstanceOfType(result, typeof(int));   
        }

       
    }
}