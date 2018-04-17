using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using NUnit.Framework;
using LEDCubeFileGenerator.Common.Interfaces;
using LEDCubeFileGenerator.Common.Services;

namespace LEDCubeFileGenerator.Test
{
    /// <summary>
    /// Summary description for FileCreatorTest
    /// </summary>
    [TestFixture]
    public class FileCreatorTest
    {
        private IFileCreator _fileCreator;

        [SetUp]
        public void Initialize()
        {
            this._fileCreator = new FileCreator();
        }

        [Test]
        public void FileCreator_Save_HowItWorks()
        {
            this._fileCreator.Save("Hello!", "F:\\ARDUINO.TXT");

            var result = File.Exists("F://ARDUINO.TXT");

            Assert.AreEqual(true, result);
        }
    }
}
