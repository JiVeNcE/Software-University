<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Print Tags</title>
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
    foreach ($tags as $key => $value) {
        echo $key . " : " . $value . "<br />";
    }
}
?>
</form>
</body>
</html>
