<!DOCTYPE html>
<html>
<head>
    <title>Sum of Digits</title>

</head>
<body>


<form action="" method="post">
    Input string: <input type="text" name="input" />
    <input type="submit" name="submit"/>
</form>

<?php
if( isset($_POST['submit'])){

$array = explode(',', $_POST['input']);

    echo '<table border="1px solid black">';
    foreach ( $array as $key => $value){
        if (is_numeric($value)){

            echo  '<tr>'.'<td>'.$value.'</td>'.'<td>'.getSumOfDigits($value).'</td>'.'</tr>';
        }else{
                echo  '<tr>'.'<td>'.$value.'</td>'.'<td>'.'I cannot sum that'.'</td>'.'</tr>';
            }
    }
    echo '</table>';
}

function getSumOfDigits($num) {
        return array_sum(str_split($num));
}
?>
</body>
</html>
