<?php
class App
{

    public $controller = "Home";
    public $action = "Welcome";
    public $params = [];

    function __construct()
    {

        $arr = $this->UrlProcess();
        //print_r ($arr[2]);
        // Controller
        if (isset($arr)) {
            if (file_exists("./mvc/controllers/" . $arr[0] . ".php")) {
                $this->controller = $arr[0];
                unset($arr[0]);
            }
        }

        require_once "./mvc/controllers/" . $this->controller . ".php";
        $this->controller = new $this->controller;

        // Action
        if (isset($arr[1])) {
            if (method_exists($this->controller, $arr[1])) {
                $this->action = $arr[1];
            }
            unset($arr[1]);
        }

        // Params
        $this->params = $arr ? array_values($arr) : [];

        call_user_func_array([$this->controller, $this->action], $this->params);
        if (isset($arr[2])) {
            return $arr[2];
        }
    }
    // function GetParam(){
    //     $arr = $this->UrlProcess();
    //     if (isset($arr)){

    //     }  
    // }
    function UrlProcess()
    {
        if (isset($_GET['url'])) {
            return explode("/", filter_var(trim($_GET['url'], "/")));
        }
    }
}
?>
