/**
 * Created by Zhivko on 20.7.2014 г..
 */

function printNumbers(n) {

    var resultNumbers = [];

        for (var i = 1; i <= n; i++) {
            if (i % 4 != 0 && i % 5 != 0) {
                resultNumbers.push(i);
            }
        }

    if(n <= 0){
        resultNumbers.push('no');
    }
    console.log(resultNumbers.join(', '));
}

    printNumbers(20);
    printNumbers(-5);
    printNumbers(13);


