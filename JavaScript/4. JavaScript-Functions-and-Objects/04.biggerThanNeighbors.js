/**
 * Created by Zhivko on 27.7.2014 г..
 */

    function  biggerThanNeighbors(index,  arr) {


    for (var i = 0; i < arr.length; i++) {
        if ( index ==0 || index==arr.length - 1){
            return "only one neighbor" ;
        }

        if (index >= arr.length){
            return "invalid index";
        }
        if ( i == index ) {
            if ( arr[i] > arr[i + 1]  && arr[i] > arr[i - 1] ){
                 return "bigger";
            }
            else {
                return "not bigger" ;
            }
        }

    }
}

    console.log(biggerThanNeighbors(2, [1, 2, 3, 3, 5]));
    console.log(biggerThanNeighbors(2, [1, 2, 5, 3, 4]));
    console.log(biggerThanNeighbors(5, [1, 2, 5, 3, 4]));
    console.log(biggerThanNeighbors(0, [1, 2, 5, 3, 4]));
