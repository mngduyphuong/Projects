<!-- User register web view -->
<div class="login" style="height: 100%; text-align: center">
  <h1>
    <p>Creating your membership</p>
  </h1>
  <br />
  <form action="User/Creating_Membership" method="POST">
    <!-- Form submition with validation input to create new membership -->
    <p>
      <label for="username">Username</label>
      <input type="text" id="username" name="username" required="required" />
    </p>
    <p>
      <label for="password">Password</label>
      <input type="password" id="password" name="password" required="required" />
    </p>

    <p>
      <label for="email">Email</label>
      <input type="email" id="email " name="email" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2, 4}$" required="required" />
    </p>

    <p>
      <label for="phone">Phone number</label>
      <input type="text" id="phone " name="phone" pattern="\d{10}" required="required" />
    </p>
    <input type="submit" id="login_button" name="register_button" value="Register" /><br />
  </form>

  <!-- Message section to inform user the operation of the system -->
  <h1 style="color: red;">
    <?php
    if (isset($_POST["register_button"])) {
      $iUser_Register = new User();
      $result = $iUser_Register->Creating_Membership();
      if ($result == "true")
        echo "Succesfully registered";
      else
        echo "Fail to register";
    }
    ?></h1>
<!-- Navigation link in the User Register page, use to back to home and navigate to login -->
  <p><a href="Home">Home page</a></p>
  <p><a href="User">Login to your account</a></p>
</div>