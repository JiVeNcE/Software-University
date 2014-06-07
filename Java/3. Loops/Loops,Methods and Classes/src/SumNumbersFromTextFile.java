import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class SumNumbersFromTextFile {

	public static void main(String[] args) {
		
		try{
            BufferedReader reader = new BufferedReader(new FileReader("src/Input.txt"));
            String line = null;
            int result = 0;
            while ((line = reader.readLine()) != null) {
                result+=Integer.parseInt(line);
            }
            System.out.println(result);
    }
    catch(Exception ex){
            System.out.println("(missing file)");
    }
}       	
	}
