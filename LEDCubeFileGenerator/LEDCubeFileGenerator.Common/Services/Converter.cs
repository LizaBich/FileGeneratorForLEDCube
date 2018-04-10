using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEDCubeFileGenerator.Common.Interfaces;
using LEDCubeFileGenerator.Common.Models;

namespace LEDCubeFileGenerator.Common.Services
{
    public class Converter: IConverter
    {
        public void ConvertToTxt(IList<PointModel> cube)
        {
            
        }

        private byte[] ConvertToBytes(string source)
        {
            return System.Text.Encoding.UTF8.GetBytes(source);
        }

        private string ListToString(IList<PointModel> cube)
        {
            var strBuild = new StringBuilder(cube[0].ToString());
            for (var i = 1; i < cube.Count; ++i)
            {
                strBuild.AppendLine(cube[i].ToString());
            }

            return strBuild.ToString();
        }
    }
}
