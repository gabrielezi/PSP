import java.time.LocalDate
import java.time.LocalDateTime
import java.time.LocalTime
import java.time.Month

interface ITime {
	fun TimePassed(time: LocalDateTime) : String
}