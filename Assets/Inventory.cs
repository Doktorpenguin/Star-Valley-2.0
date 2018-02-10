using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public static Inventory instance;

	void Awake ()
	{
		instance = this;
	}

	void Start ()
	{
		
	}

	public List<componentCreator> components = new List<componentCreator>();

	public void AddComponent (componentCreator component)
	{
		components.Add(component);
	}

	public void RemoveComponent (componentCreator component)
	{
		components.Remove(component);
	}
}
