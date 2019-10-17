import org.joda.time.DateTime
import org.joda.time.format._

abstract class Pizza {
  var date : DateTime=_
  var ingredientList : List[String]=_
  var size: Char =_
  
  def MakePizza(ingredients: List[String]) = {
      if (CheckIfChangeable(ingredients)) {
        var list = ReplaceIngredients(ingredients)
        RemoveIngredients(list)
      }
    else println(ingredients)
  }
  def SetIngredients(ingredients: List[String]) = { ingredientList = ingredients }
  def SetDate(creationDate: DateTime) = { date = creationDate }
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
  var date : DateTime=_
  var ingredientList : List[String]=_
  var beanName : String =_
  var size: Char =_
  
  def MakeCoffee(ingredients: List[String]) = {
      if (CheckIfChangeable(ingredients)) {
        var list = ReplaceIngredients(ingredients)
        RemoveIngredients(list)
      }
    else println(ingredients)
  }
  def SetIngredients(ingredients: List[String]) = { ingredientList = ingredients }
  def SetDate(creationDate: DateTime) = { date = creationDate }
  protected def CheckIfChangeable(ingredients: List[String]): Boolean
  protected def ReplaceIngredients(ingredients: List[String]): List[String]
  protected def RemoveIngredients(ingredients: List[String]): Unit
}
abstract class Bread {
  var date : DateTime=_
  var ingredientList : List[String]=_
  var breadType : String =_
  var size: Char =_
  
  def MakeCoffee(ingredients: List[String]) = {
      if (CheckIfChangeable(ingredients)) {
        var list = ReplaceIngredients(ingredients)
        RemoveIngredients(list)
      }
    else println(ingredients)
  }
  def SetIngredients(ingredients: List[String]) = { ingredientList = ingredients }
  def SetDate(creationDate: DateTime) = { date = creationDate }
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

trait PizzaStone {
  def Prepare() = {println("Reaching the needed temperature")}
  def Cook() = {println("The pizza is cooked on a pizza stone")}
}

trait Time {
  def TimePassed(time: DateTime): String = {
    //var p : Period = new Period(time, DateTime.now, PeriodType.yearMonthDay());
    //return p.toString
    var hours = time.getHourOfDay()
    var minutes =time.getMinuteOfDay()
    var days =time.getDayOfMonth()
    var years =time.getYear()
    var months =time.getMonthOfYear()
    var passed : DateTime = DateTime.now.minusMinutes(minutes)
    passed = DateTime.now.minusHours(hours)
    passed = DateTime.now.minusDays(days)
    passed = DateTime.now.minusYears(years)
    passed = DateTime.now.minusMonths(months)
    return passed.toString
  }
}

var date = new DateTime(2019, 10, 15, 5, 20, 0, 0);
val list = List("sauce", "pepperoni", "salmon", "milk")
//var veg_pizzaStone = new Vegetarian_PizzaStonePizza();
//veg_pizzaStone.MakePizza(list)
//veg_pizzaStone.Bake()

//val coffeeList = List("coffee", "milk")
//val coffee = new VeganCoffee()
//coffee.MakeCoffee(coffeeList)

val vegetarian_pizzaStone = new Pizza with Vegetarian with PizzaStone with Time
vegetarian_pizzaStone.SetIngredients(list)

vegetarian_pizzaStone.MakePizza(vegetarian_pizzaStone.ingredientList)
vegetarian_pizzaStone.Bake()
println(vegetarian_pizzaStone.TimePassed(date))
