
public class FullHouse {

	public static void main(String[] args) {
		
		String[] numbers = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J",
				"Q", "K"};
		char[] colors = {'♣', '♦', '♥', '♠' };
		int counter = 0;
		
		for (int i = 0; i < numbers.length; i++) {
			for (int j = 0; j < numbers.length; j++) {
				for (int k = 0; k < colors.length; k++) {
					for (int m = k + 1; m < colors.length; m++) {
						for (int l = m + 1; l < colors.length; l++) {
							for (int n = 0; n < colors.length; n++) {
								for (int o = n + 1 ; o < colors.length; o++) {
									if(i !=j){
									System.out.printf(											
											"(%s%c %s%c %s%c %s%c %s%c) ", 
											numbers[i], colors[k], numbers[i],
											colors[m], numbers[i], colors[l],
											numbers[j], colors[n], numbers[j],
											colors[o]);
									counter++;
											}
								}								
							}														
						}															
					}				
				}				
			}			
		}
		
		System.out.println();
		System.out.println("full houses: " + counter);
	}
}
