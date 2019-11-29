import java.time.LocalDate
import java.time.LocalDateTime
import java.time.LocalTime
import java.time.Month


class VegetarianPizzaStonePizza(stone: IPizzaStone, veg: IVegetarian, time: ITime): Pizza(), IPizzaStone by stone, IVegetarian by veg, ITime by time

fun main() {
	val pizzaIngred = mutableListOf("pepperoni", "milk", "sauce", "flour")
	
	val vegStone = VegetarianPizzaStonePizza(PizzaStone(), Vegetarian(), Time())
	vegStone.created = LocalDateTime.of(2019, Month.OCTOBER, 15, 3, 15)
	vegStone.ingredients = pizzaIngred
	if(vegStone.CheckIfChangeable(vegStone.ingredients))
		{
			vegStone.ingredients = vegStone.ReplaceIngredients(vegStone.ingredients)
			vegStone.RemoveIngredients(vegStone.ingredients)
		}
	
	println(vegStone.ingredients)
	println(vegStone.TimePassed(vegStone.created))
}