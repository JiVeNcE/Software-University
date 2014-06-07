import java.util.Scanner;

public class CountSubstringOccurrences {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String inputText = scan.nextLine().toLowerCase();
		String match = scan.nextLine().toLowerCase();
		
	    int lastIndex = 0;
	    int count = 0;

	    while ((lastIndex = inputText.indexOf(match, lastIndex)) != -1) {
	        count++;
	        lastIndex ++;
	    }

	    System.out.println(count);	
	}

}
