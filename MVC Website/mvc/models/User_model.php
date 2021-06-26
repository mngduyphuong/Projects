<?php
//Order model which used to connect to the database, get data
class User_Model extends DB{
    public function Get(){
        $qr = "SELECT * FROM db_user";
        return mysqli_query($this->con, $qr);
    }

    public function Check($username,$password){
        $qr = "SELECT * FROM db_user WHERE username='$username'AND password='$password'";	
        $test = mysqli_query($this->con, $qr);
        $result = false;
        if ( mysqli_num_rows($test) > 0)
        {
            $result = true;
            $_SESSION['login_username'] = $username;
		    $_SESSION['login_password'] = $password;
        }
        return $result;
    }

    public function Insert($username,$password,$email,$phone ){
        $qr = "INSERT INTO db_user VALUE (NULL, '$username', '$password', '$email', '$phone')";
        $result = false;
        if (mysqli_query($this->con, $qr) == true)
        {
            $result = true;
        }
        return $result;
    }

}
?>