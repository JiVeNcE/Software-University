import java.util.ArrayList;
import java.util.Scanner;
public class CombineListsLetters {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		ArrayList<Character> list1 = new ArrayList<>();
		ArrayList<Character> list2 = new ArrayList<>();
		
		for (char character : scan.nextLine().toCharArray()) {
			list1.add(character);
		}
		for (char character : scan.nextLine().toCharArray()) {
			list2.add(character);
		}
		ArrayList<Character> output = new ArrayList<>();
		output.addAll(list1);
		
		for (int i = 0; i < list2.size(); i++) {
		    if (!list1.contains(list2.get(i))) {
			output.add(' ');
			output.add(list2.get(i));
		    }
		}
		for (char character : output) {
		    System.out.print(character);
		}
	}

}
