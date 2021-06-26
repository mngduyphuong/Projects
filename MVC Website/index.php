<!-- Main index page, other components will display through this -->
<?php
session_start();
// require the connection from other components
require_once "./mvc/Bridge.php";
$myApp = new App();
?>