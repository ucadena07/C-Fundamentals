using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections;

internal class ArrayUtils<T>  : IArrayUtilities<T> where T : notnull
{
	public int ComputeLengthOfArray(T[] array)
	{
		return array.Length;
	}

	public T FirstElementOrDefault(T[] array)
	{
		if (array.Length == 0) return default;
		return array[0];
	}
}

public interface IArrayUtilities<T> where T: notnull
{
	int ComputeLengthOfArray(T[] array);
	T FirstElementOrDefault(T[] array);
}