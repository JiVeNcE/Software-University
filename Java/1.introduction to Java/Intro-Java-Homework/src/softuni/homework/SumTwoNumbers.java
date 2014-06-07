package softuni.homework;
import java.util.Scanner;


public class SumTwoNumbers {

	public static void main(String[] args) {
		
		Scanner numOne = new Scanner(System.in);
		int firstN, secondN, result;
		firstN = numOne.nextInt();
		Scanner numTwo = new Scanner(System.in);
		secondN = numTwo.nextInt();
		numTwo.close();
		numOne.close();
		result = firstN + secondN;
		
		System.out.println(result);
		
	}

}
