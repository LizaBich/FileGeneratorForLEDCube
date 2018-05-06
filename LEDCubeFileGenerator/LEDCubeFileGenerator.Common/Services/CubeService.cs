using System;
using System.IO;
using LEDCubeFileGenerator.Common.Interfaces;
using LEDCubeFileGenerator.Common.Models;

namespace LEDCubeFileGenerator.Common.Services
{
    public class CubeService : ICubeService
    {
        private readonly CubeModel _cubeModel;

        private readonly IConverter _converter;

        private readonly IFileCreator _fileCreator;

        public CubeService(sbyte cubeSize, IConverter converter, IFileCreator fileCreator)
        {
            this._cubeModel = new CubeModel(cubeSize);
            this._converter = converter;
            this._fileCreator = fileCreator;
        }

        public CubeModel Cube => this._cubeModel;

        public void AddPoint(sbyte layerPos, sbyte columnPos)
        {
            this._cubeModel.Points.Add(new PointModel(this._cubeModel.CubeSize)
            {
                XY = layerPos,
                Z = columnPos
            });
        }

        public void AddRow(bool isX, sbyte numberOfLayer, sbyte startPosition)
        {
            if (isX)
            {
                for (var i = startPosition; i < startPosition + this._cubeModel.CubeSize; ++i)
                {
                    this.AddPoint(i, numberOfLayer);
                }
            }
            else
            {
                var j = startPosition;
                while (j < startPosition + Math.Pow(this._cubeModel.CubeSize, 2) - this._cubeModel.CubeSize + 1)
                {
                    this.AddPoint(j, numberOfLayer);
                    j += this._cubeModel.CubeSize;
                }
            }
        }

        public void AddHorizontalLayer(sbyte layerPosition)
        {
            for (sbyte i = 0; i < Math.Pow(this._cubeModel.CubeSize, 2); ++i)
            {
                this.AddPoint(i, layerPosition);
            }
        }

        public bool ConvertToFile(string filePath, string mode)
        {
            var content = this._converter.ConvertToTxt(this.Cube, mode);

            this._fileCreator.Save(content, filePath);

            return File.Exists(filePath);
        }
    }
}
