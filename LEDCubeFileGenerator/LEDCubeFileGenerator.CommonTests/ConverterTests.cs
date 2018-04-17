using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LEDCubeFileGenerator.Common;
using LEDCubeFileGenerator.Common.Interfaces;
using LEDCubeFileGenerator.Common.Models;
using LEDCubeFileGenerator.Common.Services;

namespace LEDCubeFileGenerator.CommonTests
{
    [TestClass]
    public class ConverterTests
    {
        private CubeModel _cubeModel;

        private IConverter _converter;

        [TestInitialize]
        public void Initialize()
        {
            this._cubeModel = new CubeModel(2);
            this._converter = new Converter();

            this._cubeModel.Points.Add(new PointModel(2)
            {
                XY = 0,
                Z = 0
            });

            this._cubeModel.Points.Add(new PointModel(2)
            {
                XY = 1,
                Z = 0
            });

            this._cubeModel.Points.Add(new PointModel(2)
            {
                XY = 0,
                Z = 1
            });

            this._cubeModel.Points.Add(new PointModel(2)
            {
                XY = 1,
                Z = 1
            });
        }

        [TestMethod]
        public void Converter_ConvertToTxt_HowItWorks()
        {
            var result = this._converter.ConvertToTxt(this._cubeModel);

            var pattern = "[0,0][0,1]\n[1,0][1,1]\n";

            Assert.AreEqual(pattern, result);
        }
    }
}
