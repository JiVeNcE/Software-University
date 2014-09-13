/**
 * Created by Zhivko on 27.7.2014 г..
 */

    function countDivs(html) {

         var div = document.getElementsByTagName("div");
         return div.length;
}
console.log(countDivs());