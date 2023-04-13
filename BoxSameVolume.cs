using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Generics
{
    internal class BoxSameVolume : EqualityComparer<Box>
    {
        public override bool Equals(Box x, Box y)
        {
            if (x.Height * x.Width * x.Length == y.Height * x.Width * y.Length)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode(Box box)
        {
            var hash = box.Height ^ box.Length ^ box.Width;
            return hash.GetHashCode();
        }
    }
}
