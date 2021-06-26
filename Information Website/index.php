<!DOCTYPE html>
<html lang="en">


<head>
	<title>Homepage</title>
	<link rel= "stylesheet" href ="styles/index.css">
	<script type="text/javascript" src="scripts/index.js"></script>
	<link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300&display=swap" rel="stylesheet">  <!-- This is font style -->
	<script src="https://kit.fontawesome.com/40ee252bb3.js" crossorigin="anonymous"></script>
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

<section class="search">
        <article id="search_content">
            <h1>Welcome to Burn - Functional fitness</h1>
            <p>Find Gym location, Activities and Gym buddies.</p>
            <div class="searchbar">
                <input type="text" class="input" id="search" placeholder="What do you want to search?">
                <button onclick="test()">Search<i class="fas fa-search"></i></button>
            </div>
        </article>
    </section>

<section class="content">
	<p> <h1> Welcome to Burn! </h1><br>
		Looking to lose a few kilos? You've come to the right place! <br>
		Join one of the activities in your area to both get fit as well as get social. <br><br>
		<h1> New Acitivities Daily! </h1>

	</p>
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