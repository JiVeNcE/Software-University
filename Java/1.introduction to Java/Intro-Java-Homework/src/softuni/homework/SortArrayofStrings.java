package softuni.homework;
import java.util.Scanner;
import java.util.Arrays;

public class SortArrayofStrings {

	public static void main(String[] args) {
		System.out.print("Enter number n here:");
		Scanner num = new Scanner(System.in);
		int n;
		n  = num.nextInt();
		num.close();
		
		System.out.println("Enter "+ n + " names:");
		
		String[] masiv = new String[n];
		for (int i = 0; i < n; i++) {
			
		       masiv[i] = num.next();		     	       
		}
		Arrays.sort(masiv);
		
		for (int i = 0; i <n; i++) {
			System.out.println(masiv[i]);
		}
				
	}
}
