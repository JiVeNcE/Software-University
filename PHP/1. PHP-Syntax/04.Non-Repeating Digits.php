<?php

$number = 1234;

if ($number < 100) {
    echo('no');
}else {
    for ($i=102; $i<= $number; $i++) {
        if ($i < 1000){

            $thirdDig = $i % 10 ;
            $secondDig = $i / 10 % 10 ;
            $firstDig = $i / 100 % 10 ;

            if ( $firstDig != $secondDig &&  $firstDig != $thirdDig && $secondDig != $thirdDig ){
                echo $i." ";
            }
        }
    }
}

?>