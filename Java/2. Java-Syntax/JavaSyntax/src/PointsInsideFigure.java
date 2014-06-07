import java.util.Scanner;
public class PointsInsideFigure {

	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		float fP = scanner.nextFloat();
		float sP = scanner.nextFloat();
		scanner.close();


			
		if ((fP >= 12.5 && fP<= 22.5 && sP>= 6 && sP <= 8.5) || 
		( fP >=12.5 && sP <= 17.5 && sP >= 8.5 && sP <= 13.5 )||
		( fP >= 20 && sP <= 22.5 && sP >= 8.5 && sP <= 13.5 ))
		{
			
			System.out.println("inside");
		}		
		
		else {
			System.out.println("outside");
		}
	}
}

