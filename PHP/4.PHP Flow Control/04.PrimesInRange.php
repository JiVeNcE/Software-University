<!DOCTYPE html>
<html>
<head>
    <title>Find Primes in Range</title>
    <style>
        #content{
            width:900px;
            height: 500px;
            display: inline-block;
        }
    </style>
</head>
<body>


<form action="" method="post">
    Starting index: <input type="text" name="start" />
    End: <input type="text" name="end" />
    <input type="submit" name="submit"/>
</form>

<?php
function IsPrime($number)
{
    if ($number < 2) {
        return false;
    }
    for ($i=2; $i<=($number / 2); $i++) {
        if($number % $i == 0) {
            return false;
        }
    }
    return true;
}

if( isset($_POST['submit'])){

    $start = $_POST['start'];
    $end = $_POST['end'];
echo '<div id="content">';
    for ($i = $start; $i <= $end; $i++){
        if(isPrime($i) == true){
            $result[] = '<strong>'.$i.'</strong>';
        }else {
            $result[] = '<span>'.$i.'</span>';
        }
    }
    echo implode(', ', $result);
    echo '</div>';
}
?>
</body>
</html>
