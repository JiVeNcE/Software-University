<!DOCTYPE html>
<html>
<head>
    <title>Show Annual Expenses</title>
    <style>
        table {
            margin-top:40px;
        }
        td, th {
            padding:5px;
        }
    </style>
</head>
<body>

<form action="" method="post">
    Enter number of years: <input type="text" name="years" />
    <input type="submit" name="submit" value="Show costs" />
</form>

<?php
if( isset($_POST['submit']) )
{
    $years = $_POST['years'];
    $year = 2014;


    echo '<table border="1px solid black;">';
    echo '<tr>'.'<td>'.'Year'.'</td>'.'<td>'.'January'.'</td>'.'<td>'.'February'.'</td>'.'<td>'.'March'.'</td>'.
         '<td>'.'April'.'</td>'.'<td>'.'May'.'</td>'.'<td>'.'June'.'</td>'.
         '<td>'.'July'.'</td>'.'<td>'.'August'.'</td>'.'<td>'.'September'.'</td>'.'<td>'.'October'.'</td>'.
         '<td>'.'November'.'</td>'.'<td>'.'December'.'</td>'.'<td>'.'Total'.'</td>'.'</tr>';

for ($i = 0; $i <= $years; $i++){
    echo '<tr>'.'<td>'.$year.'</td>';
    $count = 0;
        for ($j = 0; $j < 12; $j++){
            $total = rand(0, 999);
        echo '<td>'.$total.'</td>';
            $count+= $total;
    }
    echo '<td>'.$count.'</td>'.'</tr>';
    $year--;
}
    echo '</table>';
}
?>
</body>
</html>
