<!DOCTYPE html>
<head>
    <title>What a wonderful world!</title>
    <style type="text/css">
        body {
                margin: 0px;
                padding: 0px;
            }
        div {
            display: block;
            width: 150px;
            border:2px solid black;
            border-radius: 10px;
            margin-bottom: 20px;
            margin-left: 40px;
            background-image: -webkit-gradient(
                linear,
                left top,
                left bottom,
                color-stop(0.46, #CBD9EB),
                color-stop(0.61, #92AFD6),
                color-stop(0.76, #CBD9EB),
                color-stop(0.94, #92AFD6)
            );
        }
        div hr{
            margin-left:15px;
            color: black;
            border-style:solid;
            margin-top: 0px;
        }
        div h2 {
            font-size:15pt;
            margin-bottom: 0px;
            margin-left: 15px;
        }
        div ul li {
            list-style-type: circle;
            text-decoration: underline;
        }
    </style>
</head>
<body>
<p>Sidebar Builder</p>

<table border="1px solid black">
    <tr><td>categories</td><td>Knitting, Cycling, Swimming, Dancing</td></tr>
    <tr><td>tags</td><td>person, free time, love, peace, protest</td></tr>
    <tr><td>months</td><td>April, May, June, July</td></tr>
</table></br>

<form action="" method="post">
    <label for="categories">categories:</label></label><input type="text" name="categories" id="categories" /> <br>
    <label for="tags">tags:</label><input type="text" name="tags" id="tags" /> <br>
    <label for="months">months:</label><input type="text" name="months" id="months" /> <br>
    <input type="submit" name="submit" value="Generate"/>
</form>

<?php
if (isset($_POST['submit'])):?>
    <?php
    $categories = explode(', ', $_POST['categories']);
    $tags = explode(', ', $_POST['tags']);
    $months = explode(', ', $_POST['months']);
    ?>
    <div id="categories" clas="sidebar">
        <h2>Categories</h2>
        <hr>
        <ul>
    <?php foreach ( $categories as $key => $value):
        echo '<li>'.$value.'</li>';
        endforeach;
        ?>
        </ul>
    </div>

    <div id="tags" clas="sidebar">
        <h2>Tags</h2>
        <hr style="color: black">
        <ul>
            <?php foreach ( $tags as $key => $value):
                echo '<li>'.$value.'</li>';
            endforeach;
            ?>
        </ul>
    </div>

    <div id="months" clas="sidebar">
        <h2>Months</h2>
        <hr>
        <ul>
            <?php foreach ( $months as $key => $value):
                echo '<li>'.$value.'</li>';
            endforeach;
            ?>
        </ul>
    </div>
<?php endif; ?>
</body>
</html>
