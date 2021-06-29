<?php
//Product model which used to connect to the database, get data
class Product_Model extends DB{


    public function Get(){
        $qr = "SELECT * FROM db_product";
        return mysqli_query($this->con, $qr);
    }

    public function Detail($a){
        $qr = "SELECT * FROM db_product WHERE id = '$a'";
        return mysqli_query($this->con, $qr);
    }

}
?>