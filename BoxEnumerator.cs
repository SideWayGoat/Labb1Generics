using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Generics
{
    internal class BoxEnumerator : IEnumerator<Box>
    {

        private BoxCollection _boxes;
        private int _currentIndex;
        private Box _currentBox;

        public BoxEnumerator(BoxCollection box)
        {
            _boxes = box;
            _currentIndex = -1;
            _currentBox = default;
        }

        public Box Current { get { return _currentBox; } }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if(++_currentIndex >= _boxes.Count)
            {
                return false;
            }
            else
            {
                _currentBox = _boxes[_currentIndex];
            }
            return true;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}
