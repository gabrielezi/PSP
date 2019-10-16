import java.time.LocalDate
import java.time.LocalDateTime
import java.time.LocalTime
import java.time.Month
import java.time.temporal.ChronoUnit;

class Time() : ITime {
    override fun TimePassed(time: LocalDateTime) : String{
		var from = time
        var to = LocalDateTime.now()
		var fromTemp = LocalDateTime.from(from);
		
		var days = fromTemp.until(to, ChronoUnit.DAYS)
        fromTemp = fromTemp.plusDays(days)
		var hours = fromTemp.until(to, ChronoUnit.HOURS)
        fromTemp = fromTemp.plusHours(hours)
		var minutes = fromTemp.until(to, ChronoUnit.MINUTES)
        fromTemp = fromTemp.plusMinutes(minutes)
        var seconds = fromTemp.until(to, ChronoUnit.SECONDS)
        fromTemp = fromTemp.plusSeconds(seconds)

		var timeCreated = "days:" + days + " hours:" + hours + " minutes:" + minutes
		return timeCreated
	}
}