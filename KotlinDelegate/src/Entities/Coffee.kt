import java.time.LocalDate
import java.time.LocalDateTime
import java.time.LocalTime
import java.time.Month

open class Coffee() {
    var size: Char = 's'
	var beanName: String = "Arabica"
	var created = LocalDateTime.now()
	var ingredients = mutableListOf("flour")
}