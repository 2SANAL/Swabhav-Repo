using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddaperForDqueeAndEquee
{
    class QueueAdapter<T> : IQueue<T>,IEnumerable<T>
    {
        private LinkedList<T> _quee = new LinkedList<T>();

        
        public int Count()
        {
            return _quee.Count;
        }

        public T Dequee()
        {
            T elemtn = _quee.First();
            _quee.RemoveFirst();
            return elemtn;

        }

        public void Enquee(T element)
        {
            _quee.AddLast(element);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _quee.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _quee.GetEnumerator();
        }
    }
}
