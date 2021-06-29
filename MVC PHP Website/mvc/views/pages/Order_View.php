<!-- Web view of order page with Display order list and Payment form -->
<div class="menu-container">
        <h1 style="text-align: center;">Order list: </h1> <br>
        <?php
        //Values to calculate the total price of the order
        $total_price = 0;

        //Display the table with data from Order class
        echo "<table class ='order_table' >";
        echo "<tr>";
        echo "  <th>Item</th>";
        echo "  <th>Price</th>";
        echo "</tr>";
        //Get the data from order class
        while ($row = mysqli_fetch_array($data['Result'])) {
                echo "<tr>";
                echo "<td>";
                echo "<h5 class='item-title'><a href='Product/Detail/{$row["id"]}'>{$row["title"]}</a></h5>";
                echo "<p class='item-text'>{$row["text"]}</p>";
                echo "</td>";
                echo "<td>";
                echo "<p>Price: {$row["price"]}</p>";
                $total_price += $row["price"];
                echo "</td>";
        }
        echo "<tr>";
        echo "<td>";
        echo "<p style ='font-weight:bold;'class='item-text'>Total price: </p>";
        echo "</td>";
        echo "<td>";
        echo $total_price;
        echo "</td>";
        echo "</table>";
        ?>

        <!-- Delete function to clear the order list -->
        <h3 style="text-align:right; margin-top: 10px;"><a href='order/Delete_Order'>Delete product in cart</a></h3>
        <br>

        <!-- Payment function with form submition -->
        <div class="payment">
                <h1>
                        <p>Payment details</p>
                </h1>
                <br />
                <form action="Order/Payment_Order" method="POST">
                        <!-- Form sumission with basic input validation -->
                        <p>
                                <label for="cardtype">Card Type:</label>
                                <select name="cardtype" id="cardtype" required="required">
                                        <option value="">Chose your card type</option>
                                        <option value="visa">Visa</option>
                                        <option value="master">MasterCard</option>
                                        <option value="amex">American Express</option>
                                </select>
                        </p>
                        <p>
                                <label for="cardname">Name on Card:</label>
                                <input type="text" name="cardname" id="cardname" pattern="[a-zA-Z\s]{1,25}" required="required">
                        </p>
                        <p>
                                <label for="cardnumber">Card Number:</label>
                                <input type="text" name="cardnumber" id="cardnumber" pattern="\d{10,}" required="required">
                        </p>
                        <p>
                                <label for="cardexpiry">Card Expiry date:</label>
                                <input type="text" name="cardexpiry" id="cardexpiry" pattern="\d{2}-\d{2}$" placeholder="mm-yy" size="8" required="required">
                                <label for="cardCVV">CVV:</label>
                                <input type="text" name="cardCVV" id="cardCVV" pattern="\d{3}$" size="5" required="required">
                        </p>
                        <p><input type="hidden" name="total_price" value="<?php echo $total_price ?>"></p>
                        <input type="submit" name="payment_button" value="Pay the order" /><br />
                </form>

                <!-- Message to inform Succesfully paid -->
                <h1 style="color: red;"> <?php
                                                if (isset($_POST["payment_button"])) {
                                                        $iPayment = new Order();
                                                        $result = $iPayment->Payment_Order();
                                                        if ($result == "true") {
                                                                echo "<br>";
                                                                echo "Succesfully Paid";
                                                        } else
                                                                echo "Fail to paid";
                                                }
                                                ?></h1>
        </div>
</div>