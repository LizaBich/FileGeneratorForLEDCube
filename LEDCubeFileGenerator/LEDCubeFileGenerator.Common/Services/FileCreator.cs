using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using LEDCubeFileGenerator.Common.Interfaces;
using System.Windows.Forms;

namespace LEDCubeFileGenerator.Common.Services
{
    public class FileCreator: IFileCreator
    {
        public async Task Save(string content, string fileName)
        {
            var file = File.Create(fileName);
            var streamWriter = new StreamWriter(file);
            await streamWriter.WriteAsync(content);
            streamWriter.Close();

            //using (var folderDialog = new FolderBrowserDialog())
            //{
            //    folderDialog.Description = "Выбор папки для сохранения файла";
            //    folderDialog.ShowNewFolderButton = false;
            //    folderDialog.RootFolder = Environment.SpecialFolder.Personal;
            //    var result = folderDialog.ShowDialog();

            //    if (result == DialogResult.OK)
            //    {

            //    }
            //}
        }
    }
}
