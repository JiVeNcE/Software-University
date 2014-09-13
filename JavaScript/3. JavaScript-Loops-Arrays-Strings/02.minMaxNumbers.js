/**
 * Created by Zhivko on 20.7.2014 г..
 */

function findMinAndMax(n) {

 var min = Math.min.apply(null, n);
 var max = Math.max.apply(null, n);

    return ["Min -> " + min + " " +  "Max -> " + max];
}
    console.log(findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]));
    console.log(findMinAndMax([2, 2, 2, 2, 2]));
    console.log(findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]));