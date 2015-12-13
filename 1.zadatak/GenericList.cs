using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.zadatak
{
   public class GenericList<X> : IGenericList<X>,IEnumerable<X>
    {
        private X[] _internalStorage;
        public int size { get; set; }
        private int _lastIndex;

        public GenericList(int initialSize)
        {
            _internalStorage = new X[initialSize];
        }

        public GenericList()
        {
            _internalStorage = new X[4];
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(X item)
        {
            X[] pom = new X[size];
            if (_lastIndex + 1 >= size)
            {
                pom = new X[2 * size];
                int i;
                for (i = 0; i < size; i++)
                {
                    pom[i] = _internalStorage[i];
                }
                pom[i + 1] = item;
                _lastIndex++;
                return;
            }
            _internalStorage[_lastIndex++] = item;
        }

        public void Clear()
        {
            _internalStorage = new X[size];
        }

        public bool Contains(X item)
        {
            for (int i = 0; i < size; i++)
            {
                if (_internalStorage[i].Equals(item))
                    return true;
            }
            return false;
        }

        public X GetElement(int index)
        {
            if (index >= size || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else {
                return _internalStorage[index];
            }
        }

        public int IndexOf(X item)
        {
            for (int i = 0; i < size; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Remove(X item)
        {
            bool x = false;
            X[] pom = new X[size];
            for (int i = 0; i < size; i++)
            {
                if (!_internalStorage[i].Equals(item))
                {
                    pom[i] = _internalStorage[i];
                }
                else {
                    x = true;
                    _lastIndex--;
                }
            }
            _internalStorage = pom;
            return x;
        }

        public bool RemoveAt(int index)
        {
            bool x = false;
            X[] pom = new X[size];
            for (int i = 0; i < size; i++)
            {
                if (i != index)
                {
                    pom[i] = _internalStorage[i];
                }
                else {
                    x = true;
                    _lastIndex--;
                }
            }
            _internalStorage = pom;
            return x;
        }

        public IEnumerator<X> GetEnumerator()
        {
            return new GenericListEnumerator<X>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
