using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEDCubeFileGenerator.Common.Models;

namespace LEDCubeFileGenerator.Common.Interfaces
{
    public interface ICubeService
    {
        CubeModel Cube { get; }

        void AddPoint(sbyte layerPos, sbyte columnPos);

        void AddRow(bool isX, sbyte numberOfLayer, sbyte startPosition);

        void AddHorizontalLayer(sbyte layerPosition);

        bool ConvertToFile(string filePath, string mode);
    }
}
