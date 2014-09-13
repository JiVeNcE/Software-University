/**
 * Created by Zhivko on 21.7.2014 г..
 */

function compareChars(firstArr, secondArr){

   var result = 'Equal';

    if (firstArr.length != secondArr.length) {
            return 'Not Equal';
    }

    var lengthArr = firstArr.length,
        i;

        for (var i= 0; i < lengthArr; i+=1){
            if (firstArr[i] != secondArr[i]){
                result = 'Not Equal'
            }
        }
    return result;
}


console.log(compareChars(['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'], ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']));
console.log(compareChars(['3', '5', 'g', 'd'], ['5', '3', 'g', 'd']));
console.log(compareChars(['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'], ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']));
