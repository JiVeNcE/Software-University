<?php

$name = 'Gosho';
$phone = '0882-321-423';
$age = 24;
$address = 'Hadji Dimitar';

echo "<table border='1' width='240px' style = 'border-collapse: collapse;'";

    echo "<tr>";
        echo "<td style='background: orange'>Name</td>";
        echo "<td align='right'>$name</td>";
     echo "</tr>";

    echo "<tr>";
        echo "<td style='background: orange'>Phone Number</td>";
        echo "<td align='right'>$phone</td>";
    echo "</tr>";

    echo "<tr>";
        echo "<td style='background: orange'>Age</td>";
        echo "<td align='right'>$age</td>";
    echo "</tr>";

    echo "<tr>";
        echo "<td style='background: orange'>Address</td>";
        echo "<td align='right'>$address</td>";
    echo "</tr>";

    echo "</tr>";

echo "</table>";

?>