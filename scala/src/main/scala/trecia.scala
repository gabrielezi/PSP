import org.joda.time.DateTime
import org.joda.time.format._

class Pizza {
  var date : DateTime=_
  var ingredientList : List[String]=_
  var size: Char =_

  def SetIngredients(ingredients: List[String]) = { ingredientList = ingredients }
  def SetDate(creationDate: DateTime) = { date = creationDate }
}

abstract class Coffee {
  var date : DateTime=_
  var ingredientList : List[String]=_
  var beanName : String =_
  var size: Char =_
  
  def SetIngredients(ingredients: List[String]) = { ingredientList = ingredients }
  def SetDate(creationDate: DateTime) = { date = creationDate }
  def SetBeanName(name: String) = { beanName = name }
  def SetSize(size1: Char) = { size = size1 }
}
abstract class Bread {
  var date : DateTime=_
  var ingredientList : List[String]=_
  var breadType : String =_
  var size: Char =_

  def SetIngredients(ingredients: List[String]) = { ingredientList = ingredients }
  def SetDate(creationDate: DateTime) = { date = creationDate }
  def SetBreadType(btype: String) = { breadType = btype }
  def SetSize(size1: Char) = { size = size1 }
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

val vegetarian_pizzaStone = new Pizza with Vegetarian with PizzaStone with Time
vegetarian_pizzaStone.SetIngredients(list)

if (vegetarian_pizzaStone.CheckIfChangeable(vegetarian_pizzaStone.ingredientList)) {
        var list = vegetarian_pizzaStone.ReplaceIngredients(vegetarian_pizzaStone.ingredientList)
        vegetarian_pizzaStone.RemoveIngredients(list)
  }
vegetarian_pizzaStone.Prepare()
vegetarian_pizzaStone.Cook()
println(vegetarian_pizzaStone.TimePassed(date))
