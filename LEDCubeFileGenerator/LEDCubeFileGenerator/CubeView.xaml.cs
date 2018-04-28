using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LEDCubeFileGenerator
{
    /// <summary>
    /// Interaction logic for CubeView.xaml
    /// </summary>
    public partial class CubeView : UserControl
    {
        private readonly IList<Ellipse> _points;

        public IList<bool> IsSelected { get; private set; }

        public CubeView()
        {
            this.InitializeComponent();
            this.IsSelected = new List<bool>(64);
            this._points = new List<Ellipse>
            {
                this.Point0,
                this.Point1,
                this.Point2,
                this.Point3,
                this.Point4,
                this.Point5,
                this.Point6,
                this.Point7,
                this.Point8,
                this.Point9,
                this.Point10,
                this.Point11,
                this.Point12,
                this.Point13,
                this.Point14,
                this.Point15,
                this.Point16,
                this.Point17,
                this.Point18,
                this.Point19,
                this.Point20,
                this.Point21,
                this.Point22,
                this.Point23,
                this.Point24,
                this.Point25,
                this.Point26,
                this.Point27,
                this.Point28,
                this.Point29,
                this.Point30,
                this.Point31,
                this.Point32,
                this.Point33,
                this.Point34,
                this.Point35,
                this.Point36,
                this.Point37,
                this.Point38,
                this.Point39,
                this.Point40,
                this.Point41,
                this.Point42,
                this.Point43,
                this.Point44,
                this.Point45,
                this.Point46,
                this.Point47,
                this.Point48,
                this.Point49,
                this.Point50,
                this.Point51,
                this.Point52,
                this.Point53,
                this.Point54,
                this.Point55,
                this.Point56,
                this.Point57,
                this.Point58,
                this.Point59,
                this.Point60,
                this.Point61,
                this.Point62,
                this.Point63
            };

            this.Refresh();
        } 

        public event EventHandler<int> PointSelected;

        public void Refresh()
        {
            for (var i = 0; i < this._points.Count && i < this.IsSelected.Count; ++i)
            {
                this.IsSelected[i] = false;
                this._points[i].Fill = Brushes.LightGray;
            }
        }

        public void Recover(IList<bool> source)
        {
            this.IsSelected = source;
            for (var i = 0; i < this._points.Count && i < this.IsSelected.Count; ++i)
            {
                this._points[i].Fill = this.IsSelected[i] ? Brushes.Red : Brushes.LightGray;
            }
        }

        private void Point0_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[0] = !this.IsSelected[0];
            this.Point0.Fill = this.IsSelected[0] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 0);
        }

        private void Point1_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[1] = !this.IsSelected[1];
            this.Point1.Fill = this.IsSelected[1] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 1);
        }

        private void Point2_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[2] = !this.IsSelected[2];
            this.Point2.Fill = this.IsSelected[2] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 2);
        }

        private void Point3_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[3] = !this.IsSelected[3];
            this.Point3.Fill = this.IsSelected[3] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 3);
        }

        private void Point4_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[4] = !this.IsSelected[4];
            this.Point4.Fill = this.IsSelected[4] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 4);
        }

        private void Point5_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[5] = !this.IsSelected[5];
            this.Point5.Fill = this.IsSelected[5] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 5);
        }

        private void Point6_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[6] = !this.IsSelected[6];
            this.Point6.Fill = this.IsSelected[6] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 6);
        }

        private void Point7_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[7] = !this.IsSelected[7];
            this.Point7.Fill = this.IsSelected[7] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 7);
        }

        private void Point8_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[8] = !this.IsSelected[8];
            this.Point8.Fill = this.IsSelected[8] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 8);
        }

        private void Point9_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[9] = !this.IsSelected[9];
            this.Point9.Fill = this.IsSelected[9] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 9);
        }

        private void Point10_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[10] = !this.IsSelected[10];
            this.Point10.Fill = this.IsSelected[10] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 10);
        }

        private void Point11_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[11] = !this.IsSelected[11];
            this.Point11.Fill = this.IsSelected[11] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 11);
        }

        private void Point12_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[12] = !this.IsSelected[12];
            this.Point12.Fill = this.IsSelected[12] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 12);
        }

        private void Point13_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[13] = !this.IsSelected[13];
            this.Point13.Fill = this.IsSelected[13] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 13);
        }

        private void Point14_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[14] = !this.IsSelected[14];
            this.Point14.Fill = this.IsSelected[14] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 14);
        }

        private void Point15_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[15] = !this.IsSelected[15];
            this.Point15.Fill = this.IsSelected[15] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 15);
        }

        private void Point16_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[16] = !this.IsSelected[16];
            this.Point16.Fill = this.IsSelected[16] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 16);
        }

        private void Point17_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[17] = !this.IsSelected[17];
            this.Point17.Fill = this.IsSelected[17] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 17);
        }

        private void Point18_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[18] = !this.IsSelected[18];
            this.Point18.Fill = this.IsSelected[18] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 18);
        }

        private void Point19_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[19] = !this.IsSelected[19];
            this.Point19.Fill = this.IsSelected[19] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 19);
        }

        private void Point20_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[20] = !this.IsSelected[20];
            this.Point20.Fill = this.IsSelected[20] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 20);
        }

        private void Point21_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[21] = !this.IsSelected[21];
            this.Point21.Fill = this.IsSelected[21] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 21);
        }

        private void Point22_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[22] = !this.IsSelected[22];
            this.Point22.Fill = this.IsSelected[22] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 22);
        }

        private void Point23_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[23] = !this.IsSelected[23];
            this.Point23.Fill = this.IsSelected[23] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 23);
        }

        private void Point24_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[24] = !this.IsSelected[24];
            this.Point24.Fill = this.IsSelected[24] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 24);
        }

        private void Point25_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[25] = !this.IsSelected[25];
            this.Point25.Fill = this.IsSelected[25] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 25);
        }

        private void Point26_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[26] = !this.IsSelected[26];
            this.Point26.Fill = this.IsSelected[26] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 26);
        }

        private void Point27_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[27] = !this.IsSelected[27];
            this.Point27.Fill = this.IsSelected[27] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 27);
        }

        private void Point28_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[28] = !this.IsSelected[28];
            this.Point28.Fill = this.IsSelected[28] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 28);
        }

        private void Point29_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[29] = !this.IsSelected[29];
            this.Point29.Fill = this.IsSelected[29] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 29);
        }

        private void Point30_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[30] = !this.IsSelected[30];
            this.Point30.Fill = this.IsSelected[30] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 30);
        }

        private void Point31_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[31] = !this.IsSelected[31];
            this.Point31.Fill = this.IsSelected[31] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 31);
        }

        private void Point32_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[32] = !this.IsSelected[32];
            this.Point32.Fill = this.IsSelected[32] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 32);
        }

        private void Point33_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[33] = !this.IsSelected[33];
            this.Point33.Fill = this.IsSelected[33] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 33);
        }

        private void Point34_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[34] = !this.IsSelected[34];
            this.Point34.Fill = this.IsSelected[34] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 34);
        }

        private void Point35_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[35] = !this.IsSelected[35];
            this.Point35.Fill = this.IsSelected[35] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 35);
        }

        private void Point36_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[36] = !this.IsSelected[36];
            this.Point36.Fill = this.IsSelected[36] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 36);
        }

        private void Point37_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[37] = !this.IsSelected[37];
            this.Point37.Fill = this.IsSelected[37] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 37);
        }

        private void Point38_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[38] = !this.IsSelected[38];
            this.Point38.Fill = this.IsSelected[38] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 38);
        }

        private void Point39_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[39] = !this.IsSelected[39];
            this.Point39.Fill = this.IsSelected[39] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 39);
        }

        private void Point40_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[40] = !this.IsSelected[40];
            this.Point40.Fill = this.IsSelected[40] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 40);
        }

        private void Point41_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[41] = !this.IsSelected[41];
            this.Point41.Fill = this.IsSelected[41] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 41);
        }

        private void Point42_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[42] = !this.IsSelected[42];
            this.Point42.Fill = this.IsSelected[42] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 42);
        }

        private void Point43_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[43] = !this.IsSelected[43];
            this.Point43.Fill = this.IsSelected[43] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 43);
        }

        private void Point44_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[44] = !this.IsSelected[44];
            this.Point44.Fill = this.IsSelected[44] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 44);
        }

        private void Point45_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[45] = !this.IsSelected[45];
            this.Point45.Fill = this.IsSelected[45] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 45);
        }

        private void Point46_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[46] = !this.IsSelected[46];
            this.Point46.Fill = this.IsSelected[46] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 46);
        }

        private void Point47_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[47] = !this.IsSelected[47];
            this.Point47.Fill = this.IsSelected[47] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 47);
        }

        private void Point48_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[48] = !this.IsSelected[48];
            this.Point48.Fill = this.IsSelected[48] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 48);
        }

        private void Point49_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[49] = !this.IsSelected[49];
            this.Point49.Fill = this.IsSelected[49] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 49);
        }

        private void Point50_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[50] = !this.IsSelected[50];
            this.Point50.Fill = this.IsSelected[50] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 50);
        }

        private void Point51_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[51] = !this.IsSelected[51];
            this.Point51.Fill = this.IsSelected[51] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 51);
        }

        private void Point52_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[52] = !this.IsSelected[52];
            this.Point52.Fill = this.IsSelected[52] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 52);
        }

        private void Point53_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[53] = !this.IsSelected[53];
            this.Point53.Fill = this.IsSelected[53] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 53);
        }

        private void Point54_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[54] = !this.IsSelected[54];
            this.Point54.Fill = this.IsSelected[54] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 54);
        }

        private void Point55_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[55] = !this.IsSelected[55];
            this.Point55.Fill = this.IsSelected[55] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 55);
        }

        private void Point56_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[56] = !this.IsSelected[56];
            this.Point56.Fill = this.IsSelected[56] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 56);
        }

        private void Point57_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[57] = !this.IsSelected[57];
            this.Point57.Fill = this.IsSelected[57] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 57);
        }

        private void Point58_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[58] = !this.IsSelected[58];
            this.Point58.Fill = this.IsSelected[58] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 58);
        }

        private void Point59_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[59] = !this.IsSelected[59];
            this.Point59.Fill = this.IsSelected[59] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 59);
        }

        private void Point60_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[60] = !this.IsSelected[60];
            this.Point60.Fill = this.IsSelected[60] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 60);
        }

        private void Point61_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[61] = !this.IsSelected[61];
            this.Point61.Fill = this.IsSelected[61] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 61);
        }

        private void Point62_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[62] = !this.IsSelected[62];
            this.Point62.Fill = this.IsSelected[62] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 62);
        }

        private void Point63_Selected(object sender, MouseButtonEventArgs e)
        {
            this.IsSelected[63] = !this.IsSelected[63];
            this.Point63.Fill = this.IsSelected[63] ? Brushes.Red : Brushes.LightGray;
            this.PointSelected?.Invoke(this, 63);
        }
    }
}
