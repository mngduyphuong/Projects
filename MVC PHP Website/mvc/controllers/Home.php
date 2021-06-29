<?php
//Initial welcome screen of project, doesn't need model to connect to database.
class Home extends Controller
{
    function Welcome()
    {
        // Call Views
        $this->view("layout_main", [
            "Page" => "home_view",
        ]);
    }
}
?>