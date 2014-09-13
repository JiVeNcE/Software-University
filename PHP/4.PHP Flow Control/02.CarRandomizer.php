<!DOCTYPE html>
<html>
<head>
    <title>Rich People’s Problems</title>
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

<div>Mitsubishi, Maseratti, Maybach</div>
<form action="" method="post">
    Enter cars: <input type="text" name="cars" />
    <input type="submit" name="submit" value="Show result" />
</form>

<?php
if( isset($_POST['submit']) )
{
    echo '<table border="1px solid black;">';
    echo '<tr>'.'<td>'.'Car'.'</td>'.'<td>'.'Color'.'</td>'.'<td>'.'Count'.'</td>'.'</tr>';

    $array = explode(", ", $_POST['cars']);
    $colors = ['aqua', 'black', 'blue', 'fuchsia', 'gray', 'green', 'lime', 'maroon', 'navy',
        'olive', 'orange', 'purple', 'red', 'silver', 'teal', 'white', 'yellow'];
    $count = ["1", "2", "3", "4", "5"];

    foreach ($array as $key => $value) {
        echo '<tr>'.'<td>'.$value.'</td>'.'<td>'.$colors[array_rand($colors)].'</td>'.'<td>'.$count[rand(0, count($count) - 1)].'</td>'.'</tr>';
    }

    echo '</table>';
}
?>
</body>
</html>
