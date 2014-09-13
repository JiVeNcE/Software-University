<!DOCTYPE html>
<head>
    <title>What a wonderful world!</title>
    <style type="text/css">
        .red{
             color:red;
        }
        .blue{
             color:blue;
        }
    </style>
</head>
<body>
<p>What a wonderful world!</p>

<form action="" method="post">
    <textarea type="text" name="textarea"></textarea><br>
    <input type="submit" name="submit" value="Color text"/>
</form>

<?php
if (isset($_POST['submit'])):
$text = $_POST['textarea'];

$text = str_replace(' ', '', $text);

for ($i = 0;$i < strlen($text);$i++):
$num = ord($text[$i]);
if ($num % 2 == 0): ?>
    <span class="red"><?= chr($num) ?></span>
    <?php else: ?>
    <span class="blue"><?= chr($num) ?></span>
    <?php endif ?>
    <?php endfor?>
    <?php endif; ?>
</body>
</html>
