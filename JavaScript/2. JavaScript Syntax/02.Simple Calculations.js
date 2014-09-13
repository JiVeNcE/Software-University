/**
 * Created by Zhivko on 17.7.2014 г..
 */

    function roundNumber(value) {
    var floor = Math.floor(value);
    var round = Math.round(value);
    var result = (floor + "\n" + round);
    return (result);
}

    console.log(roundNumber(22.7)+ "\n");
    console.log(roundNumber(12.3)+ "\n");
    console.log(roundNumber(58.7));