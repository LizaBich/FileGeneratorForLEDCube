using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEDCubeFileGenerator.Common.Models
{
    public class CubeModel
    {
        public readonly sbyte CubeSize;

        public readonly IList<PointModel> Points;

        public CubeModel(sbyte cubeSize)
        {
            this.CubeSize = cubeSize;
            this.Points = new List<PointModel>(Convert.ToInt32(Math.Pow(this.CubeSize, 3)));   
        }
    }
}
