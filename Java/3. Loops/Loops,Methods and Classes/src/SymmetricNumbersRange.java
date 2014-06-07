import java.util.Scanner;

public class SymmetricNumbersRange {

	public static void main(String[] args) {

			Scanner scanner = new Scanner(System.in);
			int numOne = scanner.nextInt();
			int numTwo = scanner.nextInt();
			scanner.close();
			
			for (int i = numOne; i < numTwo; i++){
				    if (i < 10){
                   System.out.print(i+" ");                   
            }			
            else if(i > 11 && i < 100){
                    if(i % 10 == i/10){
                   System.out.print(i+" ");
                    }       
            }
            else if(i>=100){
                     if(i%10==i/100){
                   System.out.print(i+" ");
                   }
		 }		
			}
			System.out.print(numTwo);
			}
	}
					
	

