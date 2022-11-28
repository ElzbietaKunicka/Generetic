using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lapkricio28
{
    internal class MyList<TArray>
    {
        private TArray[] MyArray { get; set; }
        private int _index = 0;
        private int _size = 10;

        public MyList()
        {
            MyArray = new TArray[_size];
            
        }

        public void Add(TArray elementToAdd)
        {
            if(CheckIfFull())
            {
                MyArray = IncreaselistSize();
            }
            if(elementToAdd != null)
            {
                MyArray[_index] = elementToAdd;
                _index++;

            }
            else
            {
                var exception =  new ArgumentNullException(nameof(elementToAdd));
                throw exception;
            }
        }
        private bool CheckIfFull()
        {
            if (_index == _size)

                return true;
            return false;
        }

        private TArray[] IncreaselistSize()
        {
            _size += (_size / 2);
            var newArray = new TArray[_size];
            MyArray.CopyTo(newArray, 0);
            return newArray;
        }

        public void Remove(int index)
        {
            MyArray[index] = default;
            _index--;
        }
    }
}
