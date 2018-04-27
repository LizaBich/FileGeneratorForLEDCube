using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    this.cubeView.Recover(this._selectedPoints[0]);
                    break;
                case "Layer 1":
                    this.cubeView.Recover(this._selectedPoints[1]);
                    break;
                case "Layer 2":
                    this.cubeView.Recover(this._selectedPoints[2]);
                    break;
                case "Layer 3":
                    this.cubeView.Recover(this._selectedPoints[3]);
                    break;
                case "Layer 4":
                    this.cubeView.Recover(this._selectedPoints[4]);
                    break;
                case "Layer 5":
                    this.cubeView.Recover(this._selectedPoints[5]);
                    break;
                case "Layer 6":
                    this.cubeView.Recover(this._selectedPoints[6]);
                    break;
                case "Layer 7":
                    this.cubeView.Recover(this._selectedPoints[7]);
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
                    this._selectedPoints[0][point] = !this._selectedPoints[0][point];
                    break;
                case "Layer 1":
                    this._selectedPoints[1][point] = !this._selectedPoints[1][point];
                    break;
                case "Layer 2":
                    this._selectedPoints[2][point] = !this._selectedPoints[2][point];
                    break;
                case "Layer 3":
                    this._selectedPoints[3][point] = !this._selectedPoints[3][point];
                    break;
                case "Layer 4":
                    this._selectedPoints[4][point] = !this._selectedPoints[4][point];
                    break;
                case "Layer 5":
                    this._selectedPoints[5][point] = !this._selectedPoints[5][point];
                    break;
                case "Layer 6":
                    this._selectedPoints[6][point] = !this._selectedPoints[6][point];
                    break;
                case "Layer 7":
                    this._selectedPoints[7][point] = !this._selectedPoints[7][point];
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
