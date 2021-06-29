<?php
//Order class
class Order extends Controller
{
    //Initial UI screen
    function Welcome()
    {
        if (!isset($_SESSION['login_username'])) {
            $this->view("layout_login", [
                "Page" => "user_login",
                "Login" => "false"
            ]);
        } else {
            $database = $this->model("order_model");
            if (isset($_SESSION['cart_update_2'])) {
                $value = $_SESSION['cart_update_2'];

                $this->view("layout_main", [
                    "Page" => "order_view",
                    "Result" => $database->Order($value)
                ]);
            } else {
                header("location:../new/product");
            }
        }
    }

    function Creating_Order($a)
    {
        // Call Models
        $database = $this->model("order_model");
        //Getting the list of orders
        $value = "";
        $value_2 = "";
        $value .= $a . ",";
        $_SESSION['cart_update'] .= $value;
        $value_2 = $_SESSION['cart_update'];
        $value_2 = substr($value_2, 0, -1);
        //Save and update order lists
        $_SESSION['cart_update_2'] = $value_2;
        header("location:../order");

        $this->view("layout_main", [
            "Page" => "order_view",
            "Result" => $database->Order($value_2)
        ]);
    }

    //Payment function which can be used by other objects
    function Payment_Order()
    {
        // Call Models
        $this->User_Model = $this->model("order_model");
        //Get the data from submitted payment form
        if (isset($_POST["payment_button"])) {
            $username = $_SESSION['login_username'];
            $order = $_SESSION['cart_update_2'];
            $total = $_POST["total_price"];
            $status = "paid";
        }
        //Processing payment with the database
        $result = $this->User_Model->Insert($username, $order, $total, $status);

        // Call Views
        $database = $this->model("order_model");
        if (isset($_SESSION['cart_update_2'])) {
            $value = $_SESSION['cart_update_2'];

            $this->view("layout_main", [
                "Page" => "order_view",
                "Result" => $database->Order($value)
            ]);
        }
        return $result;
    }
    //Deleted function which used to clear order lists
    function Delete_Order()
    {
        // Call Models
        unset($_SESSION['cart_update']);
        unset($_SESSION['cart_update_2']);
        header("location:../home");
    }
}
?>