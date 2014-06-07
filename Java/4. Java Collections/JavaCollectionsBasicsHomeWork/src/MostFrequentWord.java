import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;
public class MostFrequentWord {

	public static void main(String[] args) {

		Scanner scan = new Scanner(System.in);
		String[] text = scan.nextLine().toLowerCase().split("\\W+");
		
	
		Map<String, Integer> setWords = new HashMap<String, Integer>();

		int maxCount = 0;
		for (String word : text) {
			  Integer count = setWords.get(word);
			  if (count == null) {
			    count = 0; 
			  }
			  if (count + 1 > maxCount) {
					maxCount = count + 1;
				    }
			  setWords.put(word, count+1);
			}

		for (Map.Entry<String, Integer> max : setWords.entrySet()) {
		    if (max.getValue() == maxCount) {
			System.out.printf("%s -> %d times\n", max.getKey(),
				max.getValue());
		    }
		}	
	}

}
