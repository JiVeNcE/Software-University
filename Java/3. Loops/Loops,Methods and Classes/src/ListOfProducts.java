import java.util.ArrayList;
import java.util.Collections;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.FileReader;
public class ListOfProducts {
 
        public static void main(String[] args) {
                ArrayList<products> products = new ArrayList<products>();
                BufferedReader reader;
                BufferedWriter writer = null;
                try {
                        reader = new BufferedReader(new FileReader("src/inputProducts.txt"));
                        String line = null;
                        while ((line = reader.readLine()) != null) {
                           String[] splittedLine = line.split(" ");
                           products.add(new products(splittedLine[0], Double.parseDouble(splittedLine[1])));
                        }
                        Collections.sort(products);
                       
                        writer = new BufferedWriter(new FileWriter("src/outputProducts.txt"));
                        for(products product : products){
                                writer.write(product.getPrice() + " " + product.getName() + "\r\n");
                        }
                        writer.close();
                }
                catch (Exception e) {
                        System.out.println("Error");
                }
 
        }
 
}