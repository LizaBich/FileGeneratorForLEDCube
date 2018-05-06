using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LEDCubeFileGenerator.Common.Interfaces;

namespace LEDCubeFileGenerator
{
    public partial class LedCubeApp : Form
    {
        private const string FinishMessage = "Done";

        private const string InProgressMessage = "In progress";

        private const string FileName = "LED_ARDUINO.TXT";

        private const string WarningMessage = "You have to choose layer!";

        private readonly ICubeService _cubeService;

        private readonly IList<IList<bool>> _selectedPoints;

        public LedCubeApp(ICubeService service)
        {
            this.InitializeComponent();

            this._cubeService = service;

            this._selectedPoints = new List<IList<bool>>
            {
                new List<bool>{false, false, false, false, false, false, false, false,
                    false, false, false, false, false, false, false, false,
                    false, false, false, false, false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false
                },
                new List<bool>{false, false, false, false, false, false, false, false,
                    false, false, false, false, false, false, false, false,
                    false, false, false, false, false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false
                },
                new List<bool>{false, false, false, false, false, false, false, false,
                    false, false, false, false, false, false, false, false,
                    false, false, false, false, false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false
                },
                new List<bool>{false, false, false, false, false, false, false, false,
                    false, false, false, false, false, false, false, false,
                    false, false, false, false, false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false
                },
                new List<bool>{false, false, false, false, false, false, false, false,
                    false, false, false, false, false, false, false, false,
                    false, false, false, false, false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false
                },
                new List<bool>{false, false, false, false, false, false, false, false,
                    false, false, false, false, false, false, false, false,
                    false, false, false, false, false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false
                },
                new List<bool>{false, false, false, false, false, false, false, false,
                    false, false, false, false, false, false, false, false,
                    false, false, false, false, false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false
                },
                new List<bool>{false, false, false, false, false, false, false, false,
                    false, false, false, false, false, false, false, false,
                    false, false, false, false, false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false,
                    false,false,false,false,false,false,false,false
                }
            };

            this.cubeView.PointSelected += this.AddPoint;
            this.layersList.TextChanged += this.LayersList_TextChanged;

            this.progress.Value = 0;
            this.finishLabel.Text = string.Empty;

            this.layersList.Text = @"Layer 0";
        }

        private void LayersList_TextChanged(object sender, EventArgs e)
        {
            switch (this.layersList.Text)
            {
                case "Layer 0":
                    this.TextChangedExtension(0);
                    break;
                case "Layer 1":
                    this.TextChangedExtension(1);
                    break;
                case "Layer 2":
                    this.TextChangedExtension(2);
                    break;
                case "Layer 3":
                    this.TextChangedExtension(3);
                    break;
                case "Layer 4":
                    this.TextChangedExtension(4);
                    break;
                case "Layer 5":
                    this.TextChangedExtension(5);
                    break;
                case "Layer 6":
                    this.TextChangedExtension(6);
                    break;
                case "Layer 7":
                    this.TextChangedExtension(7);
                    break;
                default:
                    this.CubeViewHost.Enabled = false;
                    this.ShowMessage(WarningMessage);
                    break;
            }
        }

        private void AddPoint(object sender, int point)
        {
            switch (this.layersList.Text)
            {
                case "Layer 0":
                    this.AddPointExtension(0);
                    break;
                case "Layer 1":
                    this.AddPointExtension(1);
                    break;
                case "Layer 2":
                    this.AddPointExtension(2);
                    break;
                case "Layer 3":
                    this.AddPointExtension(3);
                    break;
                case "Layer 4":
                    this.AddPointExtension(4);
                    break;
                case "Layer 5":
                    this.AddPointExtension(5);
                    break;
                case "Layer 6":
                    this.AddPointExtension(6);
                    break;
                case "Layer 7":
                    this.AddPointExtension(7);
                    break;
                default:
                    this.ShowMessage(WarningMessage);
                    break;
            }
        }

        private void ClearLayerButton_Click(object sender, EventArgs e)
        {
            switch (this.layersList.Text)
            {
                case "Layer 0":
                    this.ClearLayerExtension(0);
                    break;
                case "Layer 1":
                    this.ClearLayerExtension(1);
                    break;
                case "Layer 2":
                    this.ClearLayerExtension(2);
                    break;
                case "Layer 3":
                    this.ClearLayerExtension(3);
                    break;
                case "Layer 4":
                    this.ClearLayerExtension(4);
                    break;
                case "Layer 5":
                    this.ClearLayerExtension(5);
                    break;
                case "Layer 6":
                    this.ClearLayerExtension(6);
                    break;
                case "Layer 7":
                    this.ClearLayerExtension(7);
                    break;
                default:
                    this.ShowMessage(WarningMessage);
                    break;
            }
        }

        private void ClearLayerExtension(int position)
        {
            this._selectedPoints[position] = this._selectedPoints[position].Select(item => false).ToList();
            this.cubeView.Recover(this._selectedPoints[position]);
        }

        private void AddPointExtension(int position) =>
            this._selectedPoints[position] = this.cubeView.IsSelected.Select(item => item).ToList();

        private void TextChangedExtension(int position, bool flag = true)
        {
            this.CubeViewHost.Enabled = flag;
            this.cubeView.Recover(this._selectedPoints[position].Select(item => item).ToList());
        }

        private void ShowMessage(string message)
        {
            const string warnMessage = "Warning";
            MessageBox.Show(message, warnMessage);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.finishLabel.Text = InProgressMessage;

            using (var folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.ShowNewFolderButton = true;
                var result = folderBrowser.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.FillCube();
                    var mode = $"[{this.xExpression.Text}][{this.yExpression.Text}]";
                    this._cubeService.ConvertToFile($"{folderBrowser.SelectedPath}\\\\{FileName}", mode);
                    this.finishLabel.Text = FinishMessage;
                    this.progress.Value = 0;
                }
                else
                {
                    this.finishLabel.Text = string.Empty;
                }
            }
        }

        private void FillRow(IEnumerable<bool> layer, bool isX, bool result, sbyte startPos, sbyte position)
        {
            const sbyte size = 8;

            if (result)
                this._cubeService.AddRow(isX, position, startPos);
            else
            {
                for (var i = startPos; i < startPos + size; ++i)
                {
                    if (layer.ElementAt(i)) this._cubeService.AddPoint(i, position);
                }
            }
        }

        private void FillCube()
        {
            sbyte position = 0;
            foreach (var layer in this._selectedPoints)
            {
                if (layer.All(item => item))
                {
                    this._cubeService.AddHorizontalLayer(position);
                }
                else
                {
                    sbyte startPos = 0;
                    while (startPos < 64)
                    {
                        this.FillRow(layer, true,
                            layer.Skip(startPos).Take(8).All(item => item),
                            startPos, position);

                        startPos += 8;
                    }
                }

                this.progress.PerformStep();
                ++position;
            }
        }
    }
}
