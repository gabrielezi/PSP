
class PizzaStone() : IPizzaStone {
    override fun Cook() { print("Reaching the needed temperature\n") }
    override fun Prepare() { println("The dish is cooked on a pizza stone\n") }
}