using System.IO;
using System.Threading.Tasks;
using LEDCubeFileGenerator.Common.Interfaces;

namespace LEDCubeFileGenerator.Common.Services
{
    public class FileCreator: IFileCreator
    {
        public async Task Save(string content, string fileName)
        {
            using (var file = File.Create(fileName))
            {
                using (var streamWriter = new StreamWriter(file))
                {
                    await streamWriter.WriteAsync(content);
                    streamWriter.Close();
                }
            }
        }
    }
}
