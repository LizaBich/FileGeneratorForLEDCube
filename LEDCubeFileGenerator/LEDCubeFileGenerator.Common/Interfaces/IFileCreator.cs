using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEDCubeFileGenerator.Common.Interfaces
{
    public interface IFileCreator
    {
        Task Save(string content, string fileName);
    }
}
