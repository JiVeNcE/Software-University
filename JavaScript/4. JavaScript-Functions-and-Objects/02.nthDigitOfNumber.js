/**
 * Created by Zhivko on 26.7.2014 г..
 */

    function findNthDigit(arr) {

    var first = arr[0];
    var num = arr[1];

    if ( num < 0 ) {
        num *= -1;
    }

//    var str = num;
//    while( num != parseInt(num)){
//        num *= 10;
//    }

    var str = num.toString();
    str = str.split('.').join('').toString();
    str = parseInt(str);

    for (var i = 0; i < first- 1; i++) {

      str = Math.floor(str/10);

        if ( str == 0) {
            return ("The number doesn’t have 6 digits");
        }
    }
    return str %10 ;
}



        console.log(findNthDigit([1, 6]));
        console.log(findNthDigit([2, -55]));
        console.log(findNthDigit([6, 923456]));
        console.log(findNthDigit([3, 1451.78]));
        console.log(findNthDigit([6, 888.88]));