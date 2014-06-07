import java.util.Scanner;
import java.util.Arrays;

public class SortArrayOfNumbers {

	public static void main(String[] args) {
			Scanner scan = new Scanner(System.in);
			int n = scan.nextInt();
			scan.nextLine();			
			int[] arr = new int[n];
			
			for (int i = 0; i < arr.length; i++) {
				arr[i] = scan.nextInt();	
			}
			
			Arrays.sort(arr);
			
			for (int j = 0; j < arr.length; j++) {
				System.out.print(arr[j] + " ");
			}					
	}
}
