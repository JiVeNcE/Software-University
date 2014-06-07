
import java.util.Scanner;

public class LargestSequenceEqualStrings {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String str = scan.nextLine();
		String[] arr = str.split(" "); 
		
		int counterTemp = 1;
		int counter = 1;
		int position = 0;
	
		for (int i = 1; i < arr.length; i++) {
			if (arr[i].equals(arr[i - 1])){
				counterTemp ++;
			}else{
				counterTemp = 1;
			}
			if (counterTemp > counter){
				counter = counterTemp;
				position = i;
			}
		}
		
		for (int i = 0; i < counter - 1; i++) {
			System.out.print(arr[position] + " ");			
		}
		System.out.println(arr[position]);

	}
	}
