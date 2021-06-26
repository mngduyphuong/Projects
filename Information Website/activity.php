<!DOCTYPE html>
<html lang="en">


<head>
	<title>Homepage</title>
	<link rel= "stylesheet" href ="styles/activity.css">
	<script type="text/javascript" src="scripts/activity.js"></script>
	<link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300&display=swap" rel="stylesheet">  <!-- This is font style -->
</head>


<body>

<!-- Menu -->
<nav>
	<div class="logo"><a href="index.php"><img class="logo" src="images/logo.png" alt="Logo" title="Back to Homepage" width="80" /></a></div>
        <ul>
            <li><a href="index.php">Homepage</a></li>
  			<li><a href="activity.php">Activities</a></li>
  			<li><a href="about.php">About Us</a></li>
  			<li><a href="chat.php">Chat</a></li>
  			<li><a href="login.php">Login</a></li>
        </ul>
</nav>


<section class="content">
	<!-- <div class="columns">  -->
	<button class="btnRefresh" onclick="location.href='activity.php'">Refresh </button>
	<button class="btnCreateActivity" onclick="location.href='createActivityForm.php'">Create Activity </button>
	<br><br>
<?php 
	$servername= "localhost";
	$username = "root";
	$password = "";
	$dbname = "activity";

	$conn = new mysqli($servername, $username, $password, $dbname);

	if ($conn->connect_error) {
		die("Connection failed: " .$conn->connect_error);

}
	$sql = "SELECT Name, Activity, Time, Other FROM activity";
	$result = $conn->query($sql);

	echo "<table>";
	echo "<tr><th>Name</th><th>Activity</th><th>Time</th><th>Other Info</th><th>Join</th></tr>";
		while($row = $result->fetch_assoc()) {
			// echo "<tr><td>" . $row["Name"]." </td></td>" . $row["Activity"]."</td></td> " . $row["Time"]."</td><td>" . $row["Other"]."</td></tr>"; 
			echo "<tr><td>" .$row["Name"]. "</td><td>".$row["Activity"]."</td><td>".$row["Time"]."</td><td>".$row["Other"]."</td>";
?>
	<td><button onclick="test()"> Click to Join </button></td>
<?php
		}
	// echo "</table>";
?>
	</tr></table>
<!-- 	</div>
	<div class="columns"> <img class="image" src="images/left1.jpg" alt="Image"></div> -->
</section>
<section class="content">
	<img class="image" src="images/left1.jpg" alt="Image"/>
</section>
<!-- Footer -->
	<footer>
	<p>
		SWE20001 - Development Project 1<br>
		Swinburne Gym - D/HD Project<br>
		Group 3<br>
		<a href="https://www.swinburne.edu.au">&copy; Swinburne University of Technology</a>
	</p>
    </footer>
</body>
</html>