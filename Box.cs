using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Generics
{
    internal class Box : IEquatable<Box> 
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public int Volume { get {  return Height * Width * Length; } }

        public Box(int _height, int _width, int _length)
        {
            Height = _height;
            Width = _width;
            Length = _length;
        }

        public bool Equals(Box other)
        {
            if(other == null) return false;
            return Volume == other.Volume;
        }
    }
}
