/**
 * Created by Zhivko on 27.7.2014 г..
 */

 function reverseWordsInString(str) {

    var arr = str.split(" ");

    for (var i = 0; i < arr.length; i++) {
       arr[i]= arr[i].split("").reverse().join("");
    }
    return arr.join(" ");
}

    console.log(reverseWordsInString("Hello, how are you."));
    console.log(reverseWordsInString("Life is pretty good, isn’t it?"));