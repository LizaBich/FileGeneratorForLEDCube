using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LEDCubeFileGenerator
{
    /// <summary>
    /// Interaction logic for CubeView.xaml
    /// </summary>
    public partial class CubeView : UserControl
    {
        private IList<bool> _isSelected;
        private readonly IList<Ellipse> _points;

        public CubeView()
        {
            this.InitializeComponent();
            this._isSelected = new List<bool>(64);
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
            for (var i = 0; i < this._points.Count && i < this._isSelected.Count; ++i)
            {
                this._isSelected[i] = false;
                this._points[i].Fill = Brushes.LightGray;
            }
        }

        public void Recover(IList<bool> source)
        {
            this._isSelected = source;
            for (var i = 0; i < this._points.Count && i < this._isSelected.Count; ++i)
            {
                this._points[i].Fill = this._isSelected[i] ? Brushes.Red : Brushes.LightGray;
            }
        }

        private void Point0_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 0);
        }

        private void Point1_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 1);
        }

        private void Point2_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 2);
        }

        private void Point3_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 3);
        }

        private void Point4_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 4);
        }

        private void Point5_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 5);
        }

        private void Point6_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 6);
        }

        private void Point7_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 7);
        }

        private void Point8_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 8);
        }

        private void Point9_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 9);
        }

        private void Point10_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 10);
        }

        private void Point11_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 11);
        }

        private void Point12_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 12);
        }

        private void Point13_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 13);
        }

        private void Point14_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 14);
        }

        private void Point15_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 15);
        }

        private void Point16_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 16);
        }

        private void Point17_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 17);
        }

        private void Point18_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 18);
        }

        private void Point19_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 19);
        }

        private void Point20_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 20);
        }

        private void Point21_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 21);
        }

        private void Point22_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 22);
        }

        private void Point23_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 23);
        }

        private void Point24_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 24);
        }

        private void Point25_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 25);
        }

        private void Point26_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 26);
        }

        private void Point27_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 27);
        }

        private void Point28_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 28);
        }

        private void Point29_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 29);
        }

        private void Point30_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 30);
        }

        private void Point31_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 31);
        }

        private void Point32_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 32);
        }

        private void Point33_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 33);
        }

        private void Point34_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 34);
        }

        private void Point35_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 35);
        }

        private void Point36_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 36);
        }

        private void Point37_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 37);
        }

        private void Point38_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 38);
        }

        private void Point39_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 39);
        }

        private void Point40_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 40);
        }

        private void Point41_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 41);
        }

        private void Point42_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 42);
        }

        private void Point43_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 43);
        }

        private void Point44_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 44);
        }

        private void Point45_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 45);
        }

        private void Point46_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 46);
        }

        private void Point47_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 47);
        }

        private void Point48_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 48);
        }

        private void Point49_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 49);
        }

        private void Point50_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 50);
        }

        private void Point51_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 51);
        }

        private void Point52_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 52);
        }

        private void Point53_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 53);
        }

        private void Point54_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 54);
        }

        private void Point55_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 55);
        }

        private void Point56_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 56);
        }

        private void Point57_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 57);
        }

        private void Point58_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 58);
        }

        private void Point59_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 59);
        }

        private void Point60_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 60);
        }

        private void Point61_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 61);
        }

        private void Point62_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 62);
        }

        private void Point63_Selected(object sender, MouseButtonEventArgs e)
        {
            this.PointSelected?.Invoke(this, 63);
        }
    }
}
