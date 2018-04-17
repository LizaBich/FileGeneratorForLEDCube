using System;
using LEDCubeFileGenerator.Common.Interfaces;
using LEDCubeFileGenerator.Common.Models;

namespace LEDCubeFileGenerator.Common.Services
{
    public class CubeService : ICubeService
    {
        private readonly CubeModel _cubeModel;

        public CubeService(sbyte cubeSize)
        {
            this._cubeModel = new CubeModel(cubeSize);
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

        public void AddVerticalLayer(bool isX, sbyte startPosition)
        {
            for (sbyte i = 0; i < this._cubeModel.CubeSize; ++i)
            {
                if (isX)
                {
                    for (sbyte j = startPosition; j < this._cubeModel.CubeSize + startPosition; ++j)
                    {
                        this.AddPoint(j, i);
                    }
                }
                else
                {
                    sbyte j = startPosition;
                    while (j < startPosition + Math.Pow(this._cubeModel.CubeSize, 2) - this._cubeModel.CubeSize + 1)
                    {
                        this.AddPoint(j, i);
                        j += this._cubeModel.CubeSize;
                    }
                }

            }
        }

        public void AddColumn(sbyte startPoint)
        {
            for (sbyte i = 0; i < this._cubeModel.CubeSize; ++i)
            {
                this.AddPoint(startPoint, i);
            }
        }
    }
}
