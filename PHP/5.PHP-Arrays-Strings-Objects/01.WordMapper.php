<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/html">
<head>
    <title>Word Mapping</title>
</head>
<body>
<p>The quick brows fox.!!! jumped over..// the lazy dog.!</p>
<form action="" method="post">

    <textarea type="text" name="textarea" style="width:500px;"></textarea><br>
    <input type="submit" name="submit" value="Count words" />
</form>

<?php
    if(isset($_POST['submit'])):
        $text = strtolower($_POST['textarea']);
        $array = str_word_count($text, 1);
        $count = array_count_values($array);
       ?>
        <table border="1px solid black;">
    <?php foreach ( $count as $key => $value): ?>

      <tr><td><?= htmlentities($key) ?></td><td><?=htmlentities($value)?></td></tr>
   <?php endforeach;?>
        </table>
    <?php endif; ?>


</body>
</html>
