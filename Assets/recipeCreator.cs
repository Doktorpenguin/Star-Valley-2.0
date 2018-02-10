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
	public void CheckComponents ()
	{
		var component0 = AssetDatabase.FindAssets(Requirements[0].name);
		var component1 = AssetDatabase.FindAssets(Requirements[0].name);
	}

}
