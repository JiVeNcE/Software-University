import java.util.Arrays;
import java.util.Scanner;
public class SequencesEqualStrings {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String str = scan.nextLine();
		String[] arr = str.split(" ");
				
		System.out.print(arr[0]);		
		for (int i = 1; i < arr.length; i++) {			
			if (arr[i].equals(arr[i - 1])){
				System.out.print(" " + arr[i]);
			}else {
				System.out.println();
				System.out.print(arr[i]);
			}					
		}
		
	}
}
