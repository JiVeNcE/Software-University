import java.util.Scanner;
public class FormattingNumbers {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int a = scanner.nextInt();
		double b = scanner.nextDouble();
		double c = scanner.nextDouble();
		scanner.close();
		
		String resultHex = Integer.toHexString(a).toUpperCase();;
		String resultBinary = String.format("%10s", Integer.toBinaryString(a)).replace(' ', '0');
		
		if (a>= 0 && a <= 500){
			System.out.printf("|%-10s|%s|%10.2f|%-10.3f|", resultHex, resultBinary, b, c);
		}
		else{
			System.out.println("First number have to be (0 ≤ a ≤ 500)");
		}

	}

}
