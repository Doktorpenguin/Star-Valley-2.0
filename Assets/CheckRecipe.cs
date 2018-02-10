using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRecipe : MonoBehaviour {

	public recipeCreator recipe;
	public void CheckComps () {
		recipe.CheckComponents();
	}
}
