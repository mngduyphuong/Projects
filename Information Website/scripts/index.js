function test() {
	var $x = document.getElementById("search").value;
	$test = "http://www.google.com/search?q=" + $x;
	window.location.href = $test;
	
}