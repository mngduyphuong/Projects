<!DOCTYPE html>
<html lang="en">

<?php include("includes/header.inc"); ?>

<!-- //same code from assignment 1 and 2. changed to php file and used include function to display basic common items such as menu, footer and header -->


<body>

<?php include("includes/menu.inc"); ?>

<article>					<!-- for user easy to check the price and range of product -->
	<section class="content">
		<h1>Enquiry form</h1>
		<button id="totop">
			<i class="material-icons">arrow_upward</i>
		</button>
<section>	<aside id="product_aside">
		<h2>Renting price</h2>
		<p>Have a quick check on our range and renting price.</p>

		<ol>
			<li><a href="product.php#audio">Audio equipment</a></li>
			<li><a href="product.php#visual">Visual equipment</a></li>
			<li><a href="product.php#combo">Combo equipment</a></li>
		</ol>
<p>Audio:</p>
			<ul>
			<li>Option 1: Small system $100/day</li>
			<li>Option 2: Large system $300/day</li>
		</ul>


		<p>Visual:</p>
			<ul>
			<li>Option 1: Small system $100/day</li>
			<li>Option 2: Large system $300/day</li>
		</ul>
		
		<p>Combo:</p>
			
		<ul>
			<li>Option 1: Small system $180/day</li>
			<li>Option 2: Large system $500/day</li>
		</ul>
		
	</aside></section>


<!-- form submit to store the informtaion using localstorage and transfer it to payment.html -->
<form method="post" action="payment.php" id="enquireForm" novalidate="novalidate">

	
	<fieldset class="enquire_form">
			<legend>Personal details</legend>			<!-- some basic information -->
			<p>
				 <label for="firstname">First Name:</label>
                 <input type="text" name="firstname" id="firstname" maxlength="25" size="40" pattern="[a-zA-Z\s]{1,25}" required="required" />
			</p>

			<p>
                 <label for="lastname">Last Name:</label>
                 <input type="text" name="lastname" id="lastname" maxlength="25" size="40" pattern="[a-zA-Z]{1,25}" required="required" />
            </p>

           	 <p>
               		<label for="email">Email:</label>
                <input type="email" name="email" id="email" maxlength="40" size="40" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2, 4}$" required="required" />
             </p>

             <p>
             	<label for="phone">Phone Number:</label>
                <input type="text" name="phone" id="phone" maxlength="20" size="20" pattern="\d{10}" required="required" placeholder="04XXXXXXXX" />
             </p>

             <div id="contactMethod">
             <p>Preferred Contact:
             <input type="radio" id="byemail" name="contact_type" value="By Email" checked='checked' required="required">
			 <label for="byemail">Email</label>
			                    
			 <input type="radio" id="bypost" name="contact_type" value="By Post"/>
			 <label for="bypost">Post</label>
			                    
			 <input type="radio" id="byphone" name="contact_type" value="By Phone"/>
			 <label for="byphone">Phone</label>
             </p>
             </div>

	</fieldset>

	<fieldset class="enquire_form">
		<legend>Address details</legend>				<!-- Address details -->
			<p>
	            <label for="address">Street Address:</label>
	            <input type="text" name="address" id="address" maxlength="40" size="40" pattern="[A-Za-z0-9\s]{1,40}" required="required" />
	        </p>

	         <p>
	            <label for="suburb">Suburb/Town:</label>
	            <input type="text" name="suburb" id="suburb" maxlength="20" size="40" pattern="[a-zA-Z\s]{1,20}" required="required" />
	        </p>

	        <p>
	            <label for="state">State:</label>
	            <select id="state" name="state" required='required'>
			        <option value="">Please select</option>
			        <option value="VIC">VIC</option>
			        <option value="NSW">NSW</option>
			        <option value="QLD">QLD</option>
			        <option value="NT">NT</option>
			        <option value="WA">WA</option>
			        <option value="SA">SA</option>
			        <option value="TAS">TAS</option>
			        <option value="ACT">ACT</option>
            	</select>
	        </p>

            <p>
                    <label for="postcode">Post Code</label>
                    <input type="text" name="postcode" id="postcode" maxlength="4" size="4" pattern="\d{4}" required="required" />
            </p>
		
	</fieldset>


	<fieldset class="enquire_form">
		<legend>Other information</legend>					<!-- Product order section. User can chose renting time and their options -->

		<p>
        <label for="product">Product:</label>
	        <select  id="product" name="product" required='required'>
			    <option value="">What products you want to hire?</option>
			    <option value="audio">Audio</option>
			    <option value="visual">Visual</option>
			    <option value="combo">Audio - Visual combo</option>
        	</select>
         </p>



		<p>Product features:
 			<input type="checkbox" name="option1" value="True" id="option1" checked="checked" >
			 <label for="option1">Option 1</label>
			                    
			 <input type="checkbox" name="option2" value="True" id="option2" >
			 <label for="option2">Option 2</label>

			 <p>
			 	<label for="visualadd">Visual add on: $50/day</label>
	        <select  id="visualadd" name="visualadd" >
	        	<option value="">What products you want to add?</option>
			    <option value="Controller">Controller</option>
			    <option value="Moving Light">Moving Light</option>
			    <option value="Camera">Camera</option>
			    
        	</select>
			 </p>

			 <p>
			 	<label for="audioadd">Audio add on: $10/day</label>
	        <select  id="audioadd" name="audioladd" >
	        	<option value="">What products you want to add?</option>
			    <option value="Microphone">Microphone</option>
			    <option value="Headphone">Headphone</option>
			    <option value="Connect Cable">Connect cable</option>
        	</select>
			 </p>


        </p>

        <p>
        	<label for="rent_time">Renting time</label>
        	<input type="text" name="rent_time" id="rent_time" maxlength="20" size="20" required="required" pattern="\d{1-10}" placeholder="How many days?">
        	
        </p>
     <p>
		<label>
			Comment field:<br>
			<textarea id="textarea_1" name="description" rows="5" cols="70" placeholder="Write something to specify your request..."></textarea>
		</label>
	</p>


	</fieldset>


               <section id="submit_button">									<!-- 	submit button to payment.html or reset the form -->
               	 <input class="button" type="submit" value="Checkout" />
                <input class="button" type="reset" value="Reset Form" />
               </section>



</form>

		

	</section>

</article>
<?php include("includes/footer.inc"); ?>
</body>



</html>