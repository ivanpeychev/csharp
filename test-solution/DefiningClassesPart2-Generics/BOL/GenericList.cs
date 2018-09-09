using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GenericList<T>
	where T : IComparable
{
	private T[] elements;

	private const int initialCapacity = 4;

	public int Count { get; private set; } = 0;

	public int Capacity { get { return elements.Length; } }

	public GenericList()
	{
		this.elements = new T[initialCapacity];
	}

    public GenericList(int capacity)
    {
        this.elements = new T[capacity];
    }

    public void Add(T item)
	{
		if (Count == Capacity)
		{
			Expand();
		}

		this.elements[Count++] = item;
	}

	public T Min()
	{
		Array.Sort(this.elements);
		
		return this.elements[0];
	}

	public T Max()
	{
		Array.Sort(this.elements);

		return this.elements[Count];
	}

	public override string ToString()
	{
		var result = new StringBuilder();

		for (int i = 0; i < this.Count; i++)
		{
			result.Append(this.elements[i]);

			if (i != Count - 1)
			{
				result.Append(" >> ");
			}
		}

		return result.ToString();
	}

	private void Expand()
	{
		var newElements = new T[2 * Capacity];

		for (int i = 0; i < this.Count; i++)
		{
			newElements[i] = this.elements[i];
		}

		this.elements = newElements;
	}
}