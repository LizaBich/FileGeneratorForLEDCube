using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LEDCubeFileGenerator
{
    public partial class LedCubeApp : Form
    {
        private readonly IList<IList<bool>> _selectedPoints;

        public LedCubeApp()
        {
            this.InitializeComponent();

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
        }

        private void LayersList_TextChanged(object sender, EventArgs e)
        {
            switch (this.layersList.Text)
            {
                case "Layer 0":
                    this.cubeView.Recover(this._selectedPoints[0].Select(item => item).ToList());
                    break;
                case "Layer 1":
                    this.cubeView.Recover(this._selectedPoints[1].Select(item => item).ToList());
                    break;
                case "Layer 2":
                    this.cubeView.Recover(this._selectedPoints[2].Select(item => item).ToList());
                    break;
                case "Layer 3":
                    this.cubeView.Recover(this._selectedPoints[3].Select(item => item).ToList());
                    break;
                case "Layer 4":
                    this.cubeView.Recover(this._selectedPoints[4].Select(item => item).ToList());
                    break;
                case "Layer 5":
                    this.cubeView.Recover(this._selectedPoints[5].Select(item => item).ToList());
                    break;
                case "Layer 6":
                    this.cubeView.Recover(this._selectedPoints[6].Select(item => item).ToList());
                    break;
                case "Layer 7":
                    this.cubeView.Recover(this._selectedPoints[7].Select(item => item).ToList());
                    break;
                default:
                    this.ShowMessage("You have to choose layer!");
                    break;
            }
        }

        private void AddPoint(object sender, int point)
        {
            switch (this.layersList.Text)
            {
                case "Layer 0":
                    this._selectedPoints[0] = this.cubeView.IsSelected.Select(item => item).ToList();
                    break;
                case "Layer 1":
                    this._selectedPoints[1] = this.cubeView.IsSelected.Select(item => item).ToList();
                    break;
                case "Layer 2":
                    this._selectedPoints[2] = this.cubeView.IsSelected.Select(item => item).ToList();
                    break;
                case "Layer 3":
                    this._selectedPoints[3] = this.cubeView.IsSelected.Select(item => item).ToList();
                    break;
                case "Layer 4":
                    this._selectedPoints[4] = this.cubeView.IsSelected.Select(item => item).ToList();
                    break;
                case "Layer 5":
                    this._selectedPoints[5] = this.cubeView.IsSelected.Select(item => item).ToList();
                    break;
                case "Layer 6":
                    this._selectedPoints[6] = this.cubeView.IsSelected.Select(item => item).ToList();
                    break;
                case "Layer 7":
                    this._selectedPoints[7] = this.cubeView.IsSelected.Select(item => item).ToList();
                    break;
                default:
                    this.ShowMessage("You have to choose layer!");
                    break;
            }
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message, @"Warning");
        }
    }
}
