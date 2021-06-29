<!-- Web view of User login function -->
<div class="login" style="height: 100%; text-align: center">
  <h1>
    <p>Login to your account</p>
  </h1>
  <br />
  <form action="User/Checking_Membership" method="POST">
    <!-- Form submition with to check the membership with the database -->
    <p>
      <label for="username">Username</label>
      <input type="text" id="username" name="username" required="required" />
    </p>
    <p>
      <label for="password">Password</label>
      <input type="password" id="password" name="password" required="required" />
    </p>
    <input type="submit" id="login_button" name="login_button" value="Login" /><br />
  </form>

  <!-- Message section -->

  <!-- Display error when user try to order but not logged in yet -->
  <h1 style="color: red;">
    <?php
    if (isset($data["Login"])) {
      if ($data["Login"] == "false") {
        echo "Please login first";
      }
    }

    // Display message to inform success/fail operation
    if (isset($_POST["login_button"])) {
      $iUser_Login = new User();
      $result = $iUser_Login->Checking_Membership();
      if ($result == "true") {
        echo "Succesfully login";
        header("location:../home");
      } else
        echo "Fail to login";
    }
    //Navigation links
    ?></h1>
  <p><a href="Home">Home page</a></p>
  <p><a href="User/Register">Creating your membership</a></p>
</div>