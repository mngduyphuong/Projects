function test() {
	var x = document.getElementById('activity').value;
	var y = document.getElementsByClassName("other");
	if (x == "Gym Session"|| x == "Dance Class" || x == "Gym Class" || x == "Other") {
		y[0].style.display = "inline-block"; 
		y[1].style.display = "inline-block";
	}
	else {
		y[0].style.display = "none"; 
		y[1].style.display = "none";
		y[1].value = "";
	}
}

