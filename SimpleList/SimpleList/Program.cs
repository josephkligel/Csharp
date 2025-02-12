﻿SimpleList<int> numbers = new();

foreach (int i in Enumerable.Range(1, 5))
{
    numbers.Add(i * 10);
}

numbers.RemoveAt(2);



Console.ReadKey();

class SimpleList<T>
{
    private T[] _items = new T[4];
    private int _size = 0;

    public void Add(T item)
    {
        if (_size >= _items.Length)
        {
            T[] newItems = new T[_items.Length * 2];
            for (int i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }
            _items = newItems;
        }
        
        _items[_size] = item;
        ++_size;
    }

    public void RemoveAt(int index)
    {
        if(index < 0 || index > _size)
        {
            throw new IndexOutOfRangeException(
                $"Index {index} is outside the bounds of the list");
        }

        --_size;

        for (int i = index; i < _size; i++)
        {
            _items[i] = _items[i + 1];
        }

        _items[_size] = default;
    }

    public T GetAt(int index)
    {
        if (index < 0 || index > _size)
        {
            throw new IndexOutOfRangeException(
                $"Index {index} is outside the bounds of the list");
        }

        return _items[index];
    }


}
