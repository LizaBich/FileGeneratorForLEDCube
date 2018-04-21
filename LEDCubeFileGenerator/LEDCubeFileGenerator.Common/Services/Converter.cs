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
        public string ConvertToTxt(CubeModel cube, string mode)
        {
            var strBuild = (new StringBuilder(mode)).AppendLine();

            for (var i = 0; i < cube.CubeSize; ++i)
            {
                var layer = cube.Points.Where(item => item.Z == i).Select(item => item.ToString());

                strBuild.AppendLine(this.IEnumToString(layer));
            }

            return strBuild.ToString();
        }

        private string IEnumToString(IEnumerable<string> source)
        {
            var stringBuilder = new StringBuilder();

            foreach (var item in source)
            {
                stringBuilder.Append(item);
            }

            return stringBuilder.ToString();
        }
    }
}
