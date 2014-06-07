import java.util.Scanner;


public class RectangleArea {
   
	 public static void main(String args[]) {

	Scanner firstNum = new Scanner(System.in);
	int a;
	a  = firstNum.nextInt();
	
	Scanner secondNum = new Scanner(System.in);
	int b;
	b  = secondNum.nextInt();
	firstNum.close();
	secondNum.close();
	
	int sum = a * b;
	
	System.out.println(sum);
	
	}

	}
	

