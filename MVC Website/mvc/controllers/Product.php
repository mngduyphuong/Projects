<?php
//Product class
class Product extends Controller
{
    //Initial UI screen
    function Welcome()
    {
        // Call Models
        $database = $this->model("product_model");
        // Call Views
        $this->view("layout_main", [
            "Page" => "product_view",
            "Information" => $database->get()
        ]);
        return $database->get();
    }

    //Function get details of a product, which can be used by other objects
    function Detail($a = '')
    {
        // Call Models
        $database = $this->model("product_model");


        // Call Views
        $this->view("layout_main", [
            "Page" => "product_detail",
            "Information" => $database->Detail($a)
        ]);
        return $database->Detail($a);
    }
}
