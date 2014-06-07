
import java.util.Scanner;
 import org.joda.time.DateTime;
 import org.joda.time.Days;
 import org.joda.time.LocalDate;
 import org.joda.time.format.DateTimeFormat;
 import org.joda.time.format.DateTimeFormatter;

public class DaysBetweenTwoDates {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String startDate = scanner.nextLine();
		String endDate = scanner.nextLine();
			
	    DateTimeFormatter dateStringFormat = DateTimeFormat.forPattern("dd-MM-yyyy");    
	    DateTime firstTime = dateStringFormat.parseDateTime(startDate);
	    DateTime secondTime = dateStringFormat.parseDateTime(endDate);	    
	    int days = Days.daysBetween(new LocalDate(firstTime), new LocalDate(secondTime)).getDays();    
	    System.out.println(days);
	   }
	}

