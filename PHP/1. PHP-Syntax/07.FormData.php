<!DOCTYPE html>
<html>
<head>
    <title>Get Form Data</title>

</head>
<body>
<form action="" method="POST">
    <input type="text" name="name"><br>
    <input type="text" name="age"><br>
    <input type="radio" id="male" name="sex" value="male">Male<br>
    <input type="radio" id="female" name="sex" value="female">Female<br>
    <input type="submit" name="submit" value="Submit">
</form>

<?php
if(isset($_POST['submit'])) {
    $name = $_POST['name'];
    $age = $_POST['age'];
    $sex = $_POST['sex'];

    echo "My name is $name. I am $age years old. I am $sex.";
}
?>
</body>
</html>