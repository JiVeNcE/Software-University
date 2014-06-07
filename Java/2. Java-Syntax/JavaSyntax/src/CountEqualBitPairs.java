import java.util.Scanner;


public class CountEqualBitPairs {

		 
        public static void main(String[] args) {
                Scanner scanner = new Scanner(System.in);
                int n = scanner.nextInt();
                scanner.close();
        int bit = 0;
        int counter = 0;
        int foundPairs = 0;
 
        while (n > 0)
        {
           
            if ((n & 1) == 1 && bit == 0)
            {
                counter = 0;
                bit = 1;
            }
 
            if ((n & 1) == 0 && bit == 1)
            {
                counter = 0;
                bit = 0;
            }
 
            if ((n & 1) == 1)
            {
                bit = 1;
            }
            else
            {
                bit = 0;
            }
 
            if ((n & 1) == 1 && bit == 1)
            {
                counter++;
                if (counter == 2)
                {
                    foundPairs++;
                    counter = 1;
                }
            }
 
            if ((n & 1) == 0 && bit == 0)
            {
                counter++;
                if (counter == 2)
                {
                    foundPairs++;
                    counter = 1;
                }
            }
 
            n = n >> 1;
        }
                System.out.println(foundPairs);
        }
}


