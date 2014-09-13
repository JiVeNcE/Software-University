<!DOCTYPE html>
<head>
    <title>URL Replacer</title>
</head>
<body>
<form method="post">
    <textarea name="text"></textarea><br>
    <input type="submit" name="submit" value="Replace URL's"/>
</form>

<?php
if (isset($_POST['submit'])):
    $text = preg_replace('/<\s*\/\s*a\s*>/', '[/URL]', $_POST["text"]);
    echo htmlentities(preg_replace('/<a(.*?)href=(\'|")([^>]+)(\'|")(.*?)>/', '[URL=\3]', $text));
    ?>
<?php endif; ?>
</body>
</html>
