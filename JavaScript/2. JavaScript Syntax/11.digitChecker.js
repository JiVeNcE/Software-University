/**
 * Created by Zhivko on 18.7.2014 г..
 */

    function checkDigit(value) {

    var thirdDigit =  Math.floor(value/100) % 10;

    if (thirdDigit == 3){
        return (true);
    }
    else {
        return (false);
    }
}

    console.log(checkDigit(1235));
    console.log(checkDigit(25368));
    console.log(checkDigit(123456));