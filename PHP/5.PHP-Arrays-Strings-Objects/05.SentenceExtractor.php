<!DOCTYPE html>
<head>
    <title>Sentence Extractor</title>
</head>
<body>
<p>This is my cat! And this is my dog. We happily live in Paris - the most beautiful city in the world! Isn't it great? Well it is :)
</p>
<form action="" method="post">
    <textarea type="text" name="text"></textarea><br>
    <input type="text" name="word" /><br>
    <input type="submit" name="submit" value="submit"/>
</form>

<?php
if (isset($_POST['submit'])):
        $text = $_POST['text'];
        $word = $_POST['word'];

    $sentences = preg_split("/(?<=[.?!])\s*/", $_POST['text'], -1, PREG_SPLIT_NO_EMPTY);
    $sentences = array_map('trim', $sentences);

foreach ($sentences as $sentence){
    if (preg_match("/\s+$word\s+.*[.?!]+$/", $sentence)) {
        echo "<p>$sentence</p>";
    }
}
    ?>
<?php endif; ?>
</body>
</html>
