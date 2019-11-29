import java.time.LocalDate
import java.time.LocalDateTime
import java.time.LocalTime
import java.time.Month

open class Pizza() {
    var size: Char = 's'
	var created = LocalDateTime.now()
	var ingredients = mutableListOf("flour")
}