using System;

namespace LEDCubeFileGenerator.Common.Models
{
    public class PointModel
    {
        private sbyte _xy;

        private sbyte _z;
        
        private readonly sbyte _cubeSize;

        public PointModel(sbyte cubeSize)
        {
            this._cubeSize = cubeSize;
        }
        
        public sbyte XY
        {
            get => this._xy;
            set
            {
                if (value > Math.Pow(this._cubeSize, 2))
                    throw new ArgumentException($"Invalid argument: number of diod in layer can't be greater than {Math.Pow(this._cubeSize, 2) - 1}");
                this._xy = value;
            }
        }
        
        public sbyte Z
        {
            get => this._z;
            set
            {
                if (value > this._cubeSize)
                    throw new ArgumentException($"Invalid argument: number of diod in column can't be greater than {this._cubeSize}");
                this._z = value;
            }
        }

        public override string ToString()
        {
            return $"[{this.Z},{this.XY}]";
        }

        public override bool Equals(object obj)
        {
            return obj is PointModel && this.Equals((PointModel) obj);
        }

        private bool Equals(PointModel point)
        {
            return this.XY == point.XY && this.Z == point.Z;
        }
    }
}
