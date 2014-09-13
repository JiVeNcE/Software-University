<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Calculate Interest</title>
    <meta charset="UTF-8">
</head>
<body>
<form method="post" action="">
    <label for="amount">Enter Amount</label>
    <input type="text" name="amount" id="amount">
    </br>
    <label for="USD">USD</label><input type="radio" name="curency" value="USD" id="USD">
    <label for="EUR">EUR</label><input type="radio" name="curency" value="EUR" id="EUR">
    <label for="BGN">BGN</label><input type="radio" name="curency" value="BGN" id="BGN">
    </br>
    <label for="interest">Compound Interest Amount</label>
    <input type="text" name="interest" id="interest"></br>
    <select name="period">
        <option value="6 months">6 Months</option>
        <option value="12 months">1 Year</option>
        <option value="24 months">2 Year</option>
        <option value="60 months">5 Year</option>
    </select>
    <input type="submit" name="calculate" value="Calculate">

<?php
if(isset($_POST['amount']) && isset($_POST['curency']) && isset($_POST['interest']) && isset($_POST['calculate'])){
    $amount = htmlentities($_POST['amount']);
    $curency = htmlentities($_POST['curency']);
    $interest = htmlentities($_POST['interest']);
    $period = htmlentities($_POST['period']);
    $period = preg_replace('/[^0-9]/', '', $period);

    for ($i = 1; $i <= $period; $i++) {
        $amount *= (1 + ($interest / 12) / 100);
    }

    $curSymbol = '';
    switch($curency){

        case 'USD': $curSymbol = "\$ ";
        echo $curSymbol . number_format($amount, 2, '.', '');
        break;
        case 'EUR': $curSymbol = " € ";
           echo  $curSymbol . number_format($amount, 2, '.', '');
        break;
        case 'BGN': $curSymbol = " лв.";
           echo number_format($amount, 2, '.', ''). $curSymbol;
        break;
        default:
         break;
    }
}
?>
</form>

</body>
</html>
