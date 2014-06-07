import java.util.Scanner;
public class TheSmallestOf3Numbers {

	public static void main(String[] args) {

		Scanner scanner = new Scanner(System.in);
		float a = scanner.nextFloat();
		float b = scanner.nextFloat();
		float c = scanner.nextFloat();
		scanner.close();
		
		if (a < b && a < c && b>a && c > a){
			System.out.println(a);
		}
		else if  (b < a && b < c & c > b){
			System.out.println(b);
		}
		else {
			System.out.println(c);
		}	
	}
}
