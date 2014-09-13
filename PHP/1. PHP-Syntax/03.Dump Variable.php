<?php

$variable =  1.234;

if (is_numeric($variable)){
    var_dump($variable);
}else {
    echo gettype($variable);
}

?>