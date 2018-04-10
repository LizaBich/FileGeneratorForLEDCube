using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEDCubeFileGenerator.Common.Interfaces;
using LEDCubeFileGenerator.Common.Models;

namespace LEDCubeFileGenerator.Common.Services
{
    public class CubeService: ICubeService
    {
        private readonly CubeModel _cubeModel;

        public CubeService(sbyte cubeSize)
        {
            this._cubeModel = new CubeModel(cubeSize);
        }

        public void AddPoint(sbyte layerPos, sbyte columnPos)
        {
            this._cubeModel.Points.Add(new PointModel(this._cubeModel.CubeSize)
            {
                XY = layerPos,
                Z = columnPos
            });
        }
    }
}
