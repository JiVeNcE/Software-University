<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Most Frequent Tag</title>
</head>
<body>
<div>Pesho, homework, homework, exam, course, PHP</div><br/>
<div>Enter tags:</div><br/>

<form method="post">

    <input type="text" name="name">
    <input type="submit" name="submit"><br/><br/>

    <?php
    if (isset($_POST['submit'])){
    $tags = explode(", ", $_POST['name']);
    $c = array_count_values($tags);
    $val = array_search(max($c), $c);
    arsort($c);
    foreach ($c as $key => $value) {
        echo "$key : $value times <br>";

    }
        echo "<p>Most Frequent Tag is: $val </p>";
    }
    ?>
</form>
</body>
</html>
