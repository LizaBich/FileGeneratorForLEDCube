using LEDCubeFileGenerator.Common.Interfaces;
using LEDCubeFileGenerator.Common.Models;
using LEDCubeFileGenerator.Common.Services;
using NUnit.Framework;

namespace LEDCubeFileGenerator.Test
{
    [TestFixture]
    public class ConverterTest
    {
        private CubeModel _cubeModel;

        private IConverter _converter;

        [SetUp]
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

        [Test]
        public void Converter_ConvertToTxt_HowItWorks()
        {
            var result = this._converter.ConvertToTxt(this._cubeModel, "All");

            var pattern = "All\r\n[0,0][0,1]\r\n[1,0][1,1]\r\n";

            Assert.AreEqual(pattern, result);
        }
    }
}
