<!DOCTYPE html>
<html lang="en">


<head>
	<title>Homepage</title>
	<link rel= "stylesheet" href ="styles/createActivity.css">
	<script type="text/javascript" src="scripts/createActivityForm.js"></script>
	<link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300&display=swap" rel="stylesheet">  <!-- This is font style -->
</head>


<body>

<!-- Menu -->
<nav>
	<div class="logo" id="logo"><a href="index.php"><img class="logo" src="images/logo.png" alt="Logo" title="Back to Homepage" width="80" /></a></div>
        <ul>
            <li><a href="index.php">Homepage</a></li>
  			<li><a href="activity.php">Activities</a></li>
  			<li><a href="about.php">About Us</a></li>
  			<li><a href="chat.php">Chat</a></li>
  			<li><a href="login.php">Login</a></li>
        </ul>
</nav>


<section class="content">
	<p> 
		<form name="form" action="submit.php" method="post">
			<label for="name">Name: </label>
			<input type="text" id="name" name="name" required><br>
			<label for="activity">Choose an Activity: </label>
			<select id="activity" onchange="test()" name="activity">
				<option value="Football">Football</option>
				<option value="Tennis">Tennis</option>
				<option value="Gym Session">Gym Session</option>
				<option value="Running">Running</option>
				<option value="Dance Class">Dance Class</option>
				<option value="Gym Class">Gym Class</option>
				<option value="Swimming">Swimming</option>
				<option value="Basketball">Basketball</option>
				<option value="Volleyball">Volleyball</option>
				<option value="Badminton">Badminton</option>
				<option value="Walking">Walking</option>
				<option value="Other">Other</option>
			</select><br>
			<label for="other" class="other">Please specify: </label>
			<input type="text" class="other" name="other"><br>
			<label for="time">Specific a time for when the activity will begin: </label>
			<select id="time" name="time">
				<option value="6am"> 6:00am</option>
				<option value="6:30am"> 6:30am</option>
				<option value="7am"> 7:00am</option>
				<option value="7:30am"> 7:30am</option>
				<option value="8am"> 8:00am</option>
				<option value="8:30am"> 8:30am</option>
				<option value="9am"> 9:00am</option>
				<option value="9:30am"> 9:30am</option>
				<option value="10am">10:00am</option>
				<option value="10:30am">10:30am</option>
				<option value="11am">11:00am</option>
				<option value="11:30am">11:30am</option>
				<option value="12pm">12:00pm</option>
				<option value="12:30pm">12:30pm</option>
				<option value="1pm"> 1:00pm</option>
				<option value="1:30pm"> 1:30pm</option>
				<option value="2pm"> 2:00pm</option>
				<option value="2:30pm"> 2:30pm</option>
				<option value="3pm"> 3:00pm</option>
				<option value="3:30pm"> 3:30pm</option>
				<option value="4pm"> 4:00pm</option>
				<option value="4:30pm"> 4:30pm</option>
				<option value="5pm"> 5:00pm</option>
				<option value="5:30pm"> 5:30pm</option>
				<option value="6pm"> 6:00pm</option>
				<option value="6:30pm"> 6:30pm</option>
				<option value="7pm"> 7:00pm</option>
			</select><br>
			<input type="submit">
		</form>
		</p>
</section>
<section class="content"> 
	<img class="image" src="images/left3.jpg" alt="Image"/>
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