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
  protected def CheckIfChangeable(ingredients: List[String]): Boolean
  protected def ReplaceIngredients(ingredients: List[String]): List[String]
  protected def RemoveIngredients(ingredients: List[String]): Unit
  
  def Bake() = {
    Prepare()
    Cook()
  }
  protected def Prepare(): Unit
  protected def Cook(): Unit
}
abstract class Coffee {
  //var ingredientList : List[String]
  def MakeCoffee(ingredients: List[String]) = {
      if (CheckIfChangeable(ingredients)) {
        var list = ReplaceIngredients(ingredients)
        RemoveIngredients(list)
      }
    else println(ingredients)
  }
  //def SetIngredients(ingredients: List[String]) = { ingredientList = ingredients } //setter
  protected def CheckIfChangeable(ingredients: List[String]): Boolean
  protected def ReplaceIngredients(ingredients: List[String]): List[String]
  protected def RemoveIngredients(ingredients: List[String]): Unit
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

class VegetarianCoffee extends Coffee with Vegetarian
class VeganCoffee extends Coffee with Vegan
class NoneDietCoffee extends Coffee with NoneDiet


val list = List("sauce", "pepperoni", "salmon", "milk")
//var veg_pizzaStone = new Vegetarian_PizzaStonePizza();
//veg_pizzaStone.MakePizza(list)
//veg_pizzaStone.Bake()

val coffeeList = List("coffee", "milk")
val coffee = new VeganCoffee()
coffee.MakeCoffee(coffeeList)

//------be klasiu

val vegetarian_pizzaStone = new Pizza with Vegetarian with PizzaStone
vegetarian_pizzaStone.MakePizza(list)
vegetarian_pizzaStone.Bake()
