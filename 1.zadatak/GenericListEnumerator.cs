using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.zadatak
{
    class GenericListEnumerator<X> : IEnumerator<X>
    {
        GenericList<X> _genericList;
        int currentElement;

        public GenericListEnumerator(GenericList<X> g)
        {
            _genericList = g;
        }

        public X Current
        {
            get
            {
                if (MoveNext())
                {
                    return _genericList.GetElement(currentElement++);
                }
                else {
                    return default(X);
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return currentElement;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (currentElement + 1 > _genericList.size)
            {
                return false;
            }
            else {
                return true;
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
