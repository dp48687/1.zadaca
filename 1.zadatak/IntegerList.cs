using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.zadatak
{
    public class IntegerList : IIntegerList
    {
        private int [] _internalStorage;
        private int size;
        private int _lastIndex;

        public IntegerList(int initialSize) {
            _internalStorage = new int[initialSize];
        }

        public IntegerList() {
            _internalStorage = new int[4];
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(int item)
        {
            int[] pom = new int[size];
            if (_lastIndex+1>=size) {
                pom = new int[2*size];
                int i;
                for (i=0; i<size; i++) {
                    pom[i] = _internalStorage[i];
                }
                pom[i + 1] = item;
                _lastIndex++;
                return;
            }
            _internalStorage[_lastIndex++]=item;
        }

        public void Clear()
        {
            _internalStorage = new int[size];
        }

        public bool Contains(int item)
        {
            for (int i=0; i< size; i++)
            {
                if (_internalStorage[i] == item)
                    return true;
            }
            return false;
        }

        public int GetElement(int index)
        {
            if (index>=size || index<0) {
                throw new IndexOutOfRangeException();
            }else {
                return _internalStorage[index];
            }
        }

        public int IndexOf(int item)
        {
            for (int i=0; i< size; i++) {
                if (_internalStorage[i]==item) {
                    return i;
                }
            }
            return -1;
        }

        public bool Remove(int item)
        {
            bool x = false;
            int[] pom = new int[size];
            for (int i=0; i< size; i++) {
                if (_internalStorage[i] != item)
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
            int[] pom = new int[size];
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
    }
}
