<?php

echo '<table border="1px solid black;">';
echo '<tr>'.'<td style="font-weight: bold;">'. 'Number'.'</td>'.'<td style="font-weight: bold;">'.'Square'.'</td>'.'</tr>';

$count = 0;
for ($i = 0; $i <= 100; $i++){
    if ($i % 2 == 0){
        echo '<tr>';
        echo '<td>'. $i.'</td>';
        $result = sqrt($i);
        echo '<td>'. round($result, 2).'</td>';
        echo '</tr>';
        $count += $result;
    }
}
echo '<tr>'.'<td style="font-weight: bold;">'. 'Total'.'</td>'.'<td>'.round($count, 2).'</td>'.'</tr>';
echo '</table>';

?>