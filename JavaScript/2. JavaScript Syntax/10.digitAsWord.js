/**
 * Created by Zhivko on 18.7.2014 г..
 */

function convertDigitToWord(value) {

    switch (value){

        case 1: return ("one"); break;
        case 2: return ("two"); break;
        case 3: return ("three"); break;
        case 4: return ("four"); break;
        case 5: return ("five"); break;
        case 6: return ("six"); break;
        case 7: return ("seven"); break;
        case 8: return ("eight"); break;
        case 9: return ("night"); break;
        default: return ("Error" )
    }
}

    console.log(convertDigitToWord(8));
    console.log(convertDigitToWord(3));
    console.log(convertDigitToWord(5));