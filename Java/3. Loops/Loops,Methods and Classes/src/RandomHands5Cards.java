import java.util.Scanner;
import java.util.Random;
public class RandomHands5Cards {

	public static void main(String[] args) {
			Scanner scanner = new Scanner(System.in);
			int n = scanner.nextInt();
			
			String[] numbers = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J",
					"Q", "K"};
			char[] colors = {'♣', '♦', '♥', '♠'};
			Random random = new Random();
			
			for (int i = 0; i < n; i++) {
				for (int j = 0; j < 5; j++) {
					int numberCard = random.nextInt(numbers.length-1) + 1;
					int numberSuit = random.nextInt(colors.length-1) + 1 ;
					System.out.printf("%s%c ",numbers[numberCard], colors[numberSuit]);
				}
				System.out.println();
			}
			
		

		
	}

}
