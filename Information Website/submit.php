<?php
$name = $_POST["name"];
$activity = $_POST["activity"];
$other = $_POST["other"];
$time = $_POST["time"];
$servername= "localhost";
$username = "root";
$password = "";
$dbname = "activity";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
	die("Connection failed: " .$conn->connect_error);

}

$sql = "INSERT INTO activity (Name, Activity, Time, Other) VALUES ('$name', '$activity', '$time', '$other')";


if ($conn->query($sql) === TRUE) {
  header("Location: activity.php");	
} else {
  echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn ->close();
?>