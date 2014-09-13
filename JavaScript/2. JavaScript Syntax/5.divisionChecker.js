/**
 * Created by Zhivko on 17.7.2014 г..
 */

    function divisionBy3(value){

      var sum = 0;
        while ( value >9){
            sum += value % 10;
            value = Math.floor(value / 10);
        }
    if (sum % 3 == 0) {
        console.log("the number is divided by 3 without remainder");
    } else {
        console.log("the number is not divided by 3 without remainder");
    }
}

    divisionBy3(12);
    divisionBy3(199);
    divisionBy3(591);