using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "New_Recipe", menuName = "Create Recipe")]
public class recipeCreator : ScriptableObject {
	//Add Ability To Add More Components

	public componentCreator[] Requirements = new componentCreator[1];
	public componentCreator Result;

	public bool HasComponents = false;
	public void setup () 
	{
		
	}
	public void  CheckComponents ()
	{

		for(int I = 0; I < Requirements.Length; I++)
		{
			if(Inventory.instance.components[I] == Requirements[I])
			{
				HasComponents = true;
			}

			else 
			{
				HasComponents = false;
			}
		}

		//if (Inventory.instance.components.Contains(Requirements[0]) && Inventory.instance.components.Contains(Requirements[1]))
		//{
			//HasComponents = true;
		//}
	}

}
