<!DOCTYPE html>
<head>
    <title>Text Filter</title>

</head>
<body>
<p>It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux!
    Sincerely, a Windows client
</p>
<p>Linux, Windows</p>
<form action="" method="post">
    <textarea type="text" name="text"></textarea><br>
    <input type="text" name="banned" /><br>
    <input type="submit" name="submit" value="submit"/>
</form>

<?php
if (isset($_POST['submit'])):
    $text = $_POST['text'];
    $bannedList = preg_split('/[ ,]+/', $_POST['banned'], - 1, PREG_SPLIT_NO_EMPTY);

    foreach ( $bannedList as $key => $value){
        $str = str_repeat('*', strlen($value));
        $text = str_replace($value, $str, $text);
    }
        echo $text;
    ?>
<?php endif; ?>
</body>
</html>
