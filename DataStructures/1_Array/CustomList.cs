using System;
using ConsoleApp1.DataStructures._1_Array.CustomInterfaces;

namespace ConsoleApp1.DataStructures._1_Array
{
    //This is not a real List implementation.
    //It's custom implementation helps to understand how list works
    //IQueryable interface was not implemented. So, you cannot iterate
    public class CustomList<T> : ICustomList<T>
    {
        private static readonly T[] EmptyArray = new T[0];
        private T[] _items;
        private int? _lastElementIndex;

        /// <summary>
        /// Gets Custom list elements count
        /// </summary>
        public int Count => _lastElementIndex + 1 ?? 0;

        public int Capacity => _items.Length;

        #region Constructors

        public CustomList()
        {
            _items = EmptyArray;
        }

        public CustomList(int capacity)
        {
            if (capacity < 0)
                throw new Exception("Size cannot be less than 0");

            _items = capacity == 0 ? EmptyArray : new T[capacity];
        }

        //TODO: Just an example. Constructor where we can pass all collection was not implemented

        #endregion


        #region Public methods

        public void Add(T item)
        {
            if (_lastElementIndex == null)
            {
                _items = new T[4];
                _items[0] = item;
                _lastElementIndex = 0;
            }
            else if (_lastElementIndex == _items.Length - 1)
            {
                GrowCustomList();
                AddElementToArray(item);
            }
            else
            {
                AddElementToArray(item);
            }
        }

        /// <summary>
        /// Clears all Custom array
        /// </summary>
        public void Clear()
        {
            _items = EmptyArray;
            _lastElementIndex = null;
        }

        public T First()
        {
            if (_lastElementIndex == null)
                throw new Exception("You cannot get first element of Empty Custom List");

            return _items[0];
        }

        public T Last()
        {
            if (_lastElementIndex == null)
                throw new Exception("You cannot get last element of Empty Custom List");

            return _items[(int)_lastElementIndex];
        }

        /// <summary>
        /// Removes first found item of Custom Array
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            //Find item
            var index = Array.IndexOf(_items, item);

            //Throw error if item was not found
            if (index == -1)
                throw new Exception("Given element was not found");

            //Remove item and rebuild array. Shrink array if needed
            RemoveItemAndRebuildArray(index);
        }

        public T RemoveAt(int itemIndex)
        {
            if (itemIndex > _lastElementIndex)
                throw new Exception($"Item index cannot be more than Custom List last index size {_lastElementIndex}");
            if (itemIndex < 0)
                throw new Exception("Index cannot be negative");

            //Get remove item
            T entity =_items[itemIndex];

            //Remove item from array and move all other elements left
            RemoveItemAndRebuildArray(itemIndex);

            //Return removed item
            return entity;
        }

        public void Reverse()
        {
            T[] temp = _items;
            _items = new T [_items.Length];

            for (int i = (int)_lastElementIndex, j = 0 ; i > -1; i--, j++)
            {
                _items[j] = temp[i];
            }
        }

        public void PrintList()
        {
            for (int i = 0; i < _lastElementIndex + 1; i++)
            {
                Console.WriteLine(_items[i]);
            }
            Console.WriteLine("\n");
        }

        #endregion

        #region Private helpers

        public void RemoveItemAndRebuildArray(int itemIndex)
        {
            //Decrement last index  
            _lastElementIndex--;

            //Save original array as temp
            T[] temp = _items;

            //Calculate new array size
            int newArraySize;
            if (_lastElementIndex < 4)
                newArraySize = 4;
            else if (_items.Length / 2 > _lastElementIndex)
            {
                newArraySize = _items.Length / 2;
            }
            else
            {
                newArraySize = _items.Length;
            }
            _items = new T[newArraySize]; 

            //Remove item from array and 
            for (var i = 0; i < _lastElementIndex + 1; i++)
            {
                if (i >= itemIndex)
                    _items[i] = temp[i + 1];
                else
                    _items[i] = temp[i];
            }
        }

        private void GrowCustomList()
        {
            T[] tempArr = _items;
            _items = new T[tempArr.Length * 2];

            for (var i = 0; i < tempArr.Length; i++)
            {
                _items[i] = tempArr[i];
            }
        }

        private void ShrinkCustomList()
        {

        }

        private void AddElementToArray(T item)
        {
            var nextIndex = (int) _lastElementIndex + 1;

            _items[nextIndex] = item;
            _lastElementIndex++;
        }

        #endregion
    }
}
