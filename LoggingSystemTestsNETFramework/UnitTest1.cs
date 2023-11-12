using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using LoggingSystem;

namespace LoggingSystemTestsNETFramework
{

    [TestFixture]
    public class LoggerTests
    {
        [Test]
        public void ConsoleLogger_Log_ShouldPrintToConsole()
        {
           
            var logger = new ConsoleLogger();
            var expectedMessage = "Test log message";
           
            logger.Log(expectedMessage);
            
            Console.WriteLine("Testing the console output");
        }

        [Test]
        public void FileLogger_Log_ShouldWriteToFile()
        {
           
            var filePath = "testLogFile.txt";
            var logger = new FileLogger(filePath);
            var expectedMessage = "Test log message";
            
            logger.Log(expectedMessage);

        
            var fileContent = System.IO.File.ReadAllText(filePath);
            StringAssert.Contains(expectedMessage, fileContent);
        }

        [Test]
        public void InMemoryLogger_Log_ShouldAddToLogStore()
        {            
            var logStore = new List<string>();
            var logger = new InMemoryLogger(logStore);
            var expectedMessage = "Test log message";
           
            logger.Log(expectedMessage);
           
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1, logStore.Count);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual($"[In-Memory] {expectedMessage}", logStore[0]);
        }
    }
}
