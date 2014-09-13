/**
 * Created by Zhivko on 21.7.2014 г..
 */

 function findMaxSequence(value){

    var maxCounter = 1;
    var maxElement =  value[0];
    var element = value[0];

    for (var i = 1; i < value.length ;i++){

        if (value[i] == element) {
            caounter++;

            if (caounter > maxCounter) {
                maxCounter = caounter;
                maxElement = element;
            }
        }

        else {
            caounter = 1;
            element = value[i];
        }
    }

    var output = "";
    for (var j = 1; j <= maxCounter ; j++) {
        if (j != maxCounter) {
            output += maxElement + ", ";
        }
        else {
            output += maxElement;
        }
    }
    return output;
}

console.log(findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));
console.log(findMaxSequence(['happy']));
console.log(findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']));
