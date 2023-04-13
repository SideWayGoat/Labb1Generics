using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Generics
{
    internal class BoxCollection : ICollection<Box>
    {
        private List<Box> boxes;

        public int Count { get { return boxes.Count; } }

        public bool IsReadOnly { get { return false; } }

        public BoxCollection()
        {
            boxes = new List<Box>();
        }


        public Box this[int index]
        {
            get { return boxes[index]; }
            set { boxes[index] = value; }
        }

        public void Add(Box item)
        {
            if (!Contains(item))
            {
                boxes.Add(item);
            }
            else
            {
                Console.WriteLine($"The box was not added, Height: {item.Height} Width: {item.Width} and Length: {item.Length} already exsist");
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Box item)
        {
            bool found = false;
            foreach (Box b in boxes)
            {
                if (b.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }
        
        public bool Contains(Box item, EqualityComparer<Box> comp)
        {
            foreach (Box b in boxes)
            {
                if(comp.Equals(b, item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            if( array == null)
            {
                throw new ArgumentNullException();
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(Count > array.Length - arrayIndex + 1)
            {
                throw new ArgumentException("The destination array has fewer elements than the collection");
            }
            for (int i = 0; i < boxes.Count; i++)
            {
                array[i + arrayIndex] = boxes[i];
            }
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            bool remove = false;
            for (int i = 0; i < boxes.Count; i++)
            {
                if (boxes[i].Equals(item))
                {
                    boxes.RemoveAt(i);
                    remove = true;
                    break;
                }
            }

            return remove;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
