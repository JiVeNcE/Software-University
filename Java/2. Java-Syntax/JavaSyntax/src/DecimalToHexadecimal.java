import java.util.Scanner;

public class DecimalToHexadecimal {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int hex = scanner.nextInt();
		scanner.close();

	String result = Integer.toHexString(hex).toUpperCase();;
		System.out.println(result);

	}

}
