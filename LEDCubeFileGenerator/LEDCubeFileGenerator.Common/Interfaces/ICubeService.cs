using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEDCubeFileGenerator.Common.Interfaces
{
    public interface ICubeService
    {
        void AddPoint(sbyte layerPos, sbyte columnPos);

        //void AddRow(bool isX);

        //void AddHorizontalLayer(sbyte numberOfLayer);

        //void AddVerticalLayer(bool isX);

        //void AddColumn();

        //void ConvertToFile();
    }
}
