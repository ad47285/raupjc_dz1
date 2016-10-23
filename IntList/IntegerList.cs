using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntList
{
    public interface IIntegerList
    {
        /// <summary >
        /// Adds an item to the collection .
        /// </ summary >
        void Add(int item);

        /// <summary >
        /// Removes the item at the given index in the collection .
        /// </ summary >
        bool RemoveAt(int index);

        /// <summary >
        /// Removes the first occurrence of an item from the collection .
        /// If the item was not found , method does nothing .
        /// </ summary >
        bool Remove(int item);

        /// <summary >
        /// Returns the item at the given index in the collection .
        /// </ summary >
        int GetElement(int index);

        /// <summary >
        /// Readonly property . Gets the number of items contained in the collection.
        /// </ summary >
        int Count { get; }

        /// <summary >
        /// Returns the index of the item in the collection .
        /// If item is not found in the collection , method returns -1.
        /// </ summary >
        int IndexOf(int item);

        /// <summary >
        /// Removes all items from the collection .
        /// </ summary >
        void Clear();

        /// <summary >
        /// Determines whether the collection contains a specific value .
        /// </ summary >
        bool Contains(int item);
    }


    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int size { get; set; }
        private int totalSize { get; set; }


        public IntegerList()
        {
            _internalStorage = new int[4];
            size = 0;
        }

        public IntegerList(int initialSize)
        {
            if (initialSize > 0)
            {
                _internalStorage = new int[initialSize];
                size = 0;
            }
            else
            {
                Console.WriteLine("initialSize is equal or less than 0.");
                // return nešto 
            }
        }


        public void Add(int item)
        {
            if (size >= _internalStorage.Length)
            {
                totalSize = _internalStorage.Length;
                int[] internalStorage = new int[totalSize];

                for (int i = 0; i < size; i++)
                {
                    internalStorage[i] = _internalStorage[i];
                }

                totalSize *= 2;
                _internalStorage = new int[totalSize];

                for (int i = 0; i < size; i++)
                {
                    _internalStorage[i] = internalStorage[i];
                }
            }

            _internalStorage[size] = item;
            size++;
        }


        public bool RemoveAt(int index)
        {
            if (index >= size || index < 0)
            {
                return false;
            }

            for (int i = index; i < size - 1; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }

            size--;
            return true;
        }


        public bool Remove(int item)
        {
            int idx = -1;
            for (int i = 0; i < size; i++)
            {
                if (_internalStorage[i] == item)
                {
                    idx = i;
                    break;
                }
            }

            return RemoveAt(idx);
        }


        public int GetElement(int index)
        {
            if (index >= 0 && index < size)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }


        public int Count
        {
            get
            {
                return size;
            }
        }


        public int IndexOf(int item)
        {
            for (int i = 0; i < size; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }


        public void Clear()
        {
            size = 0;
        }


        public bool Contains(int item)
        {
            for (int i = 0; i < size; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return true;
                }
            }

            return false;
        }

        public void test()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(_internalStorage[i]);
            }
        }
    }
}
