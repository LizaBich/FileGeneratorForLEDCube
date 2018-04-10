using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEDCubeFileGenerator.Common.Models;

namespace LEDCubeFileGenerator.Common.Interfaces
{
    public interface IConverter
    {
        void ConvertToTxt(IList<PointModel> cube);
    }
}
