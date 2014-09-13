/**
 * Created by Zhivko on 17.7.2014 г..
 */

   function bitChecker(value){

    var bits = value >> 3 ;

    if ( (bits & 1) == 1 ){
        return (true);
    }
    else {
        return (false);
    }
}

    console.log(bitChecker(333));
    console.log(bitChecker(425));
    console.log(bitChecker(2567564754));