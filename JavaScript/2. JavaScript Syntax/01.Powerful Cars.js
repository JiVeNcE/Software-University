/**
 * Created by Zhivko on 17.7.2014 г..
 */

   function convertHPtoKw(value) {
    return Math.round(value / 0.746 *100) /100;
}

    console.log(convertHPtoKw(75));
    console.log(convertHPtoKw(150));
    console.log(convertHPtoKw(1000));
