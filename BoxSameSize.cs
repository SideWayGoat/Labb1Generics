using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Generics
{
    internal class BoxSameSize : EqualityComparer<Box>
    {
        public override bool Equals(Box x, Box y)
        {
            if (x.Height == y.Height && x.Length == y.Length && x.Width == y.Width)
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
