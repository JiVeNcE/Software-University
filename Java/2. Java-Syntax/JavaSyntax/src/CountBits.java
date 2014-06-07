import java.util.Scanner;
public class CountBits {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int bit = scanner.nextInt();
		scanner.close();
		
		String result = String.format("%16s", Integer.toBinaryString(bit)).replace(' ', '0');
	
		int count =0;
		while(bit!=0)
        {
                if(bit%2==1)
                {
                        count++;
                }
                bit/=2;
        }
	
		System.out.println("binary representation of n: " + result);
		System.out.println("count of bits 1 : " + count);		
		
	}

}
