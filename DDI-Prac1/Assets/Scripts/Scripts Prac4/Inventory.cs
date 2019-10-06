using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour 
{
	public delegate void OnItemChange();
	public OnItemChange onItemChange;
	public int space = 15;
	public List<Item> items = new List<Item>();

	public void Add(Item item)
	{	
		space = 15;
		if (items.Count < space)
		{
			Debug.Log("This is space: "+space+", and this is item count: "+items.Count);
			items.Add(item);
			Debug.Log("just added item to inventory");
			if(onItemChange != null)
			{
				Debug.Log("in line onItemChange.Invoke(); ");

				onItemChange.Invoke();
			}
		}
		else
		{
			Debug.LogWarning("Spacio insuficiente en inventario");
		}
	}

	public void Remove(Item item)
	{
		if (items.Contains(item))
		{
			items.Remove(item);
			if(onItemChange != null)
			{
				onItemChange.Invoke();
			}
		}
		else
		{
			Debug.LogWarning("Item no esta en inventario");
		}
	}
}
