 
public class products implements Comparable<products>{
        private String name;
        private double price;
       
        public products(String name, double price){
                this.name = name;
                this.price = price;
        }
       
        public String getName(){
                return name;
        }
       
        public double getPrice(){
                return price;
        }
       
        public int compareTo(products compareFruit) {
                 
                double otherPrice = ((products) compareFruit).getPrice();
 
                //ascending order
                if(this.price>otherPrice) return 1;
                else
                if(this.price==otherPrice) return 0;
                return -1;
        }      
}
