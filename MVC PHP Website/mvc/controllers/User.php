<?php
// User class
class User extends Controller
{
    //Initial welcome UI
    function Welcome()
    {
        // Call Views
        $this->view("layout_login", [
            "Page" => "user_login",
        ]);
    }
    //Register function which can be used by other objects. Redirect back to main register
    function Register()
    {
        // Call Models
        
        // Call Views
        $this->view("layout_login", [
            "Page" => "user_register",
        ]);
    }
    //Register function which can be used by other objects
    function Creating_Membership()
    {
        // Call Models
        $this->User_Model = $this->model("user_model");
        //Get input from submitted form
        if (isset($_POST["register_button"])) {
            $username = $_POST["username"];
            $password = $_POST["password"];
            $email = $_POST["email"];
            $phone = $_POST["phone"];
        }
        //Operating with Database
        $result = $this->User_Model->Insert($username, $password, $email, $phone);

        // Call Views
        $this->view("layout_login", [
            "Page" => "user_register"
        ]);
        return $result;
    }
    //Checking the login input from the user
    function Checking_Membership()
    {
        // Call Models
        $this->User_Model = $this->model("user_model");
        //Get input from submitted form
        if (isset($_POST["login_button"])) {
            $username = $_POST["username"];
            $password = $_POST["password"];
        }
        //Operating with Database
        $result = $this->User_Model->Check($username, $password);

        // Call Views
        $this->view("layout_login", [
            "Page" => "user_login",
            "Result" => $result
        ]);
        return $result;
    }

    //Logout function
    function Logout_Membership()
    {
        // Call Models
        require_once "./mvc/models/user_model.php";
        unset($_SESSION['login_username']);
        unset($_SESSION['login_username']);
        header("location:../home");
    }
}

class Customer extends User
{
}
?>