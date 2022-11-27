using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Topic_3_Generic;

public class Task2_Generic<T>
{
    private List<T> List { get; }

    public Task2_Generic(List<T> list)
    {
        List = list;
    }

    public void PrintList()
    {
        foreach (var item in List)
        {
            Console.WriteLine(item.ToString);
        }
    }

    public T[] ConvertToArray()
    {
        return List.ToArray();
    }

    public void AddItem(T item)
    {
        List.Add(item);
    }

    public void AddList(List<T> list)
    {
        List.AddRange(list);

    }
    public void RemoveElementFromList(T element)
    {
        var itemToRemove = List.Single(x => x.Equals(element));
        List.Remove(itemToRemove);

    }

    public void RemoveElementFromListByIndex(T element)
    {
        int index = List.IndexOf(element);
        List.RemoveAt(index);
    }

    public void RemoveDublicatesFromList(T element)
    {
        List.RemoveAll(x => x.Equals(element));

        // liambda fukcija kurios dar nesimokinome.
    }
}
