import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
public class ExtractEmails {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String inputText = scan.nextLine();
		
		Pattern emailPattern = Pattern.compile("[\\w-+]+(?:\\.[\\w-+]+)*[@]+\\w+[ .]+\\w+");
			Matcher matcher = emailPattern.matcher(inputText);
			while (matcher.find()) {
			    System.out.println(matcher.group());
			}
	}
}
