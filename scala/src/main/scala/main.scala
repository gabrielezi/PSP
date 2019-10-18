abstract class Pizza {
  var ingredientList : List[String] = _
  def MakePizza(ingredients: List[String]) = {
      if (CheckIfChangeable(ingredients)) {
        var list = ReplaceIngredients(ingredients)
        RemoveIngredients(list)
      }
    else println(ingredients)
  }
  def SetIngredients(ingredients: List[String]) = { ingredientList = ingredients } 
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
  var ingredientList : List[String] = _
  def MakeCoffee(ingredients: List[String]) = {
      if (CheckIfChangeable(ingredients)) {
        var list = ReplaceIngredients(ingredients)
        RemoveIngredients(list)
      }
    else println(ingredients)
  }
  def SetIngredients(ingredients: List[String]) = { ingredientList = ingredients } 
  protected def CheckIfChangeable(ingredients: List[String]): Boolean
  protected def ReplaceIngredients(ingredients: List[String]): List[String]
  protected def RemoveIngredients(ingredients: List[String]): Unit
}

trait Vegetarian {
  protected def CheckIfChangeable(ingredients: List[String]): Boolean = {
    if(ingredients.contains("pepperoni") ||ingredients.contains("salmon"))
    return true
    else false
  }
  protected def ReplaceIngredients(ingredients: List[String]): List[String] = {
    val newList=ingredients.map { case "pepperoni" => "mushroom"; case x => x }
    return newList
  }
  protected def RemoveIngredients(ingredients: List[String]) = {
  val newList = ingredients.filter(_ != "salmon")
    println(newList)
  }
}
trait Vegan {
  protected def CheckIfChangeable(ingredients: List[String]): Boolean = {
    if(ingredients.contains("milk") ||ingredients.contains("egg"))
    return true
    else false
  }
  protected def ReplaceIngredients(ingredients: List[String]): List[String] = {
    val newList=ingredients.map { case "milk" => "almondMilk"; case "cheese" => "veganCheese"; case x => x}
    return newList
  }
  protected def RemoveIngredients(ingredients: List[String]) = {
  val newList = ingredients.filter(_ != "egg")
    println(newList)
  }
}
trait NoneDiet {
  protected def CheckIfChangeable(ingredients: List[String]): Boolean = {
    return false
  }
  protected def ReplaceIngredients(ingredients: List[String]): List[String] = {
    return ingredients
  }
  protected def RemoveIngredients(ingredients: List[String]) = {
    println(ingredients)
  }
}

trait PizzaStone {
  protected def Prepare() = {println("Reaching the needed temperature")}
  protected def Cook() = {println("The pizza is cooked on a pizza stone")}
}
trait WoodFiredOven {
  protected def Prepare() = {println("Reaching the needed temperature")}
  protected def Cook() = {println("The pizza is cooked in a wood fired oven")}
}

val list = List("sauce", "pepperoni", "salmon", "milk")

val coffeeList = List("coffee", "milk")
val veganCoffee = new Coffee() with Vegan
veganCoffee.SetIngredients(coffeeList)
veganCoffee.MakeCoffee(veganCoffee.ingredientList)

val vegetarian_pizzaStone = new Pizza with Vegetarian with PizzaStone
vegetarian_pizzaStone.SetIngredients(list)
vegetarian_pizzaStone.MakePizza(vegetarian_pizzaStone.ingredientList)
vegetarian_pizzaStone.Bake()
