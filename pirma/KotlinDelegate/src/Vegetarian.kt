
class Vegetarian() : IVegetarian {
    override fun CheckIfChangeable(ingredientList: MutableList<String>): Boolean{
		var bol : Boolean = true
		for(item in ingredientList)
			{
				if(item == "pepperoni" || item == "salami" || item == "salmon")
					bol = true
				break
			}
		return bol
	}
    override fun ReplaceIngredients(ingredientList: MutableList<String>) : MutableList<String>{
		
		for(item in ingredientList)
			{
				if(item == "pepperoni")
					ingredientList[ingredientList.lastIndexOf("pepperoni")] =  "mushroom"
				if(item == "salami")
					ingredientList[ingredientList.lastIndexOf("salami")] =  "mushroom"
			}
		return ingredientList
	}
    override fun RemoveIngredients(ingredientList: MutableList<String>){
		ingredientList.remove("pepperoni")
		ingredientList.remove("salmon")
		ingredientList.remove("salami")
	}
}