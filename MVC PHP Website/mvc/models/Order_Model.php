<?php
//Order model which used to connect to the database, get data
class Order_Model extends DB
{
    public function Order($a)
    {
        $qr = "SELECT * FROM db_product WHERE id in ($a)";
        return mysqli_query($this->con, $qr);
    }

    public function Insert($a, $b, $c, $d)
    {
        $qr = "INSERT INTO db_order VALUE (NULL, '$a', '$b', '$c','$d')";
        $result = false;
        if (mysqli_query($this->con, $qr) == true) {
            $result = true;
        }
        return $result;
    }
}?>
