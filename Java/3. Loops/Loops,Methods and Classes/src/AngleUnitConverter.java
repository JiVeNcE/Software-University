import java.util.Scanner;
import java.lang.Math;

public class AngleUnitConverter {

	public static void main(String[] args) {
	
		
		Scanner scanner = new Scanner(System.in);
		int n = scanner.nextInt();	
		
 		String[] measure = new String[n];
 		double[] numbers = new double[n];
 		
 		for (int i = 0; i < numbers.length; i++) {
 			numbers[i] = scanner.nextDouble();
 			measure[i] = scanner.next();	
 			convertAngle(numbers[i], measure[i]);			
		}				
	}
	
	private static void convertAngle(double number, String meas){
			if(meas.equals("rad")) {		
				double degree = Math.toDegrees(number);					
	            System.out.printf("%.6f deg", degree);
	            System.out.println();
			}
			else if (meas.equals("deg")) {			 
				double radians = Math.toRadians(number);
	            System.out.printf("%.6f rad", radians);	
	            System.out.println();
			}	
		}
}
