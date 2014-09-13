/**
 * Created by Zhivko on 26.7.2014 г..
 */

 function lastDigitAsText(number){

        if ( number < 0 ) {
            number *= -1;
        }

            var result = number % 10;

            switch (result) {
                case 1 :
                    console.log("One");
                    break;
                case 2 :
                    console.log("Two");
                    break;
                case 3 :
                    console.log("Three");
                    break;
                case 4 :
                    console.log("Four");
                    break;
                case 5 :
                    console.log("Five");
                    break;
                case 6 :
                    console.log("Six");
                    break;
                case 7 :
                    console.log("Seven");
                    break;
                case 8 :
                    console.log("Eight");
                    break;
                case 9 :
                    console.log("Nine");
                    break;
                default:
                    console.log("Wrong Number");
                    break;
            }

}

lastDigitAsText(6);
lastDigitAsText(-55);
lastDigitAsText(133);
lastDigitAsText(14567);