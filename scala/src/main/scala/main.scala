abstract class Pizza {
  //var ingredientList : List[String]
  def MakePizza(ingredients: List[String]) = {
      if (CheckIfChangeable(ingredients)) {
        var list = ReplaceIngredients(ingredients)
        RemoveIngredients(list)
      }
    else println(ingredients)
  }
  //def SetIngredients(ingredients: List[String]) = { ingredientList = ingredients } //setter
  def CheckIfChangeable(ingredients: List[String]): Boolean
  def ReplaceIngredients(ingredients: List[String]): List[String]
  def RemoveIngredients(ingredients: List[String]): Unit
  
  def Bake() = {
    Prepare()
    Cook()
  }
  def Prepare(): Unit
  def Cook(): Unit
}

trait Vegetarian {
  def CheckIfChangeable(ingredients: List[String]): Boolean = {
    if(ingredients.contains("pepperoni") ||ingredients.contains("salmon"))
    return true
    else false
  }
  def ReplaceIngredients(ingredients: List[String]): List[String] = {
    val newList=ingredients.map { case "pepperoni" => "mushroom"; case x => x }
    return newList
  }
  def RemoveIngredients(ingredients: List[String]) = {
  val newList = ingredients.filter(_ != "salmon")
    println(newList)
  }
}
trait Vegan {
  def CheckIfChangeable(ingredients: List[String]): Boolean = {
    if(ingredients.contains("milk") ||ingredients.contains("egg"))
    return true
    else false
  }
  def ReplaceIngredients(ingredients: List[String]): List[String] = {
    val newList=ingredients.map { case "milk" => "almondMilk"; case "cheese" => "veganCheese"; case x => x}
    return newList
  }
  def RemoveIngredients(ingredients: List[String]) = {
  val newList = ingredients.filter(_ != "egg")
    println(newList)
  }
}
trait NoneDiet {
  def CheckIfChangeable(ingredients: List[String]): Boolean = {
    return false
  }
  def ReplaceIngredients(ingredients: List[String]): List[String] = {
    return ingredients
  }
  def RemoveIngredients(ingredients: List[String]) = {
    println(ingredients)
  }
}

trait PizzaStone {
  def Prepare() = {println("Reaching the needed temperature")}
  def Cook() = {println("The pizza is cooked on a pizza stone")}
}
trait WoodFiredOven {
  def Prepare() = {println("Reaching the needed temperature")}
  def Cook() = {println("The pizza is cooked in a wood fired oven")}
}

class Vegetarian_PizzaStonePizza extends Pizza with Vegetarian with PizzaStone{}
class Vegetarian_WoodFiredOvenPizza extends Pizza with Vegetarian with WoodFiredOven{}
class Vegan_PizzaStonePizza extends Pizza with Vegan with PizzaStone{}
class Vegan_WoodFiredOvenPizza extends Pizza with Vegan with WoodFiredOven{}
class NoneDiet_PizzaStonePizza extends Pizza with NoneDiet with PizzaStone{}
class NoneDiet_WoodFiredOvenPizza extends Pizza with NoneDiet with WoodFiredOven{}

val list = List("sauce", "pepperoni", "salmon", "milk")
var veg_pizzaStone = new Vegetarian_PizzaStonePizza();
veg_pizzaStone.MakePizza(list)
veg_pizzaStone.Bake()
