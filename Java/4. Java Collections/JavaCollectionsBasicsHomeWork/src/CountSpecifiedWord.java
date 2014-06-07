import java.util.Scanner;

public class CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String inputText = scan.nextLine();	
		String match = scan.nextLine();
		
		String[] words = inputText.split(" "); 
		int count = 0;
		for(int i=0; i < words.length; i++){
		   if(words[i].equalsIgnoreCase(match))
		         count++;
		}
		System.out.println(count);
		
	}
}
	
	

