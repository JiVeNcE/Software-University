/**
 * Created by Zhivko on 18.7.2014 г..
 */

function calcSupply(minAge, maxAge, food){

    return ((maxAge - minAge)*365)*food  + "kg of chocolate would be enough until I am "+maxAge + " years old" ;
}

console.log(calcSupply(38, 118, 0.5))

console.log(calcSupply(20, 87, 2));

console.log(calcSupply(16, 102, 1.1));