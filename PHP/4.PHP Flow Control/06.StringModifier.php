<!DOCTYPE html>
<html>
<head>
    <title>Modify String</title>

</head>
<body>


<form action="" method="post">
    Input string: <input type="text" name="input" />
    <input type="radio" name="modifier" value="palindrome"/><label>Check Palindrome</label>
    <input type="radio" name="modifier" value="reverse"/><label>Reverse String</label>
    <input type="radio" name="modifier" value="split"/><label>Split</label>
    <input type="radio" name="modifier" value="hash"/><label>Hash String </label>
    <input type="radio" name="modifier" value="shiffle"/><label>Shuffle String </label>
    <input type="submit" name="submit"/>

</form>

<?php
if(isset($_POST['submit'])){
    $input = $_POST['input'];
    $modifier = $_POST['modifier'];
    switch($modifier){
        case 'palindrome' :
            echo $input  . isPalindrome($input);
            break;
        case 'reverse' :
            echo reverse($input);
            break;
        case 'split' :
            echo spliter($input);
            break;
        case 'hash' :
            echo hashString($input);
            break;
        case 'shiffle' :
            echo shuffleString($input);
            break;
    }
}

function isPalindrome($str) {
    $a = strtolower(preg_replace("/[^A-Za-z0-9]/","",$str));
    if($a==strrev($a)){
        echo ' is palindrome!';
    }else{
        echo ' is not palindrome!';
    }
}

function reverse($str){
    return strrev($str);
}
function spliter($str) {
    $str = trim($str);
    $arr = str_split($str);
    return implode(" ", $arr);
}
function hashString($str) {
    $crypted = crypt($str);
    return $crypted;
}
function shuffleString($str) {
    $arr = str_split($str);
    shuffle($arr);
    return implode("", $arr);
}

?>
</body>
</html>
