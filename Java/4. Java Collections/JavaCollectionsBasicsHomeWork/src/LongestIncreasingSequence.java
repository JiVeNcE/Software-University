import java.util.Scanner;
public class LongestIncreasingSequence {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String inputLine = scan.nextLine();
		String[] arr = inputLine.split(" ");
		int[] nums = new int[arr.length];
		
		for (int i = 0; i < nums.length; i++) {
			nums[i] = Integer.parseInt(arr[i]);
		}
		
		int counter = 1;
		int maxCounter = 1;
		int position = 0;
		
		System.out.print(nums[0]);
		for (int i = 1; i < nums.length; i++) {
			if (nums[i] > nums[i - 1]) {
				System.out.print(" " + nums[i]);
				counter++;
			}

			else {
				counter = 1;
				System.out.println();
				System.out.print(nums[i]);
			}
			if (maxCounter < counter) {
				maxCounter = counter;
				position = i;
			}
		}

		System.out.println();
		System.out.print("Longest: ");
		for (int j = 0; j < counter - 1; j++) {
			System.out.print(nums[position - counter + 1 + j] + " ");
		}
		System.out.println(nums[position]);
		
		
	}
}
