/**
 * Created by Zhivko on 17.7.2014 г..
 */

    function primeChecker(value) {

    for(var i=2; i<= Math.sqrt(value); i++){
        if(value%i ==0){
            return false;
        }
    }
    return true;
}

    console.log(primeChecker(7));
    console.log(primeChecker(254));
    console.log(primeChecker(587));
