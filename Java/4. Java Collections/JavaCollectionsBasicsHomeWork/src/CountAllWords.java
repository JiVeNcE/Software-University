import java.util.Scanner;

public class CountAllWords {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String str = scan.nextLine();	
		String[] words = str.split("\\W+");
		
		System.out.println(words.length);
	}

}
