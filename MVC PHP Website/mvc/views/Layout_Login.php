<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
    <!-- Set the base URL to navigate and use CSS, styling file -->
    <base href="https://localhost:4433/new/">
    <!-- Adding the CSS, Styling to the project -->
    <link rel="stylesheet" type="text/css" href="mvc/views/styles/styles.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
</head>

<body>
    <!-- Login, Register page don't have header and footer -->
    <div id="content">
        <!-- Content section -->
        <?php require_once "./mvc/views/pages/" . $data["Page"] . ".php" ?>
    </div>

</body>

</html>