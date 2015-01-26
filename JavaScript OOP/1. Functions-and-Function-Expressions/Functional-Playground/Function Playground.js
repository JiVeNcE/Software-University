/**
 * Created by Zhivko on 28.10.2014 г..
 */
function playGround() {

    var i.
		obj;

    console.log("Numbers of arguments: " + arguments.length);
    for (i = 0; i < arguments.length; i++) {
        console.log("Argument" + (i + 1) + ":");
        console.log("Value: " + arguments[i] + " Type: " + typeof  arguments);
    }
    console.log();
}

    var func = function(){
        obj = {};
        obj.name = "Pesho";
        return obj;
    };

playGround("Pesho", "Hristo", func().name);

playGround(123456, "Hristo" , "Zhivko");

playGround(3546, 455 , 1);

playGround(this);

playGround.call(null, 1234, "Nikolai");

playGround.apply(null, [1234, "Toshkoo"]);