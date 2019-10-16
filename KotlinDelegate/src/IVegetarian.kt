interface IVegetarian {
    fun CheckIfChangeable(ingredientList: MutableList<String>) : Boolean
    fun ReplaceIngredients(ingredientList: MutableList<String>) : MutableList<String>
    fun RemoveIngredients(ingredientList: MutableList<String>)
}
