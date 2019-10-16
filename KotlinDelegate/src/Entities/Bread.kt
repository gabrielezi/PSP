import java.time.LocalDate
import java.time.LocalDateTime
import java.time.LocalTime
import java.time.Month

open class Bread() {
    var type: String = "Brioche"
	var created = LocalDateTime.now()
	var ingredients = mutableListOf("flour")
}