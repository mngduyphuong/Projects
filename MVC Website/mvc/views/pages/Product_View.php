<!-- Web view display all product from the database -->
<div class="menu-container">
    <form method="POST">
        <div class="item-deck">
            <div class="row">
                <?php
                //Object from Product class
                $iProduct_list = new Product();
                $list = $iProduct_list->Welcome();
                //Display all products from the database
                while ($row = mysqli_fetch_array($list)) {
                    echo "<div class='item'>";
                    echo "<img class='item-img-top' src='mvc/views/images/{$row["id"]}.jpg' alt='item image cap'>";
                    echo "<div class='item-body'>";
                    echo "<h5 class='item-title'><a href='Product/Detail/{$row["id"]}'>{$row["title"]}</a></h5>";
                    echo "<p class='item-text'>{$row["text"]}</p>";
                    echo "<p class='item-price'>Price: {$row["price"]}</p>"; 
                    echo "<a href='order/Creating_Order/{$row["id"]}'>Order</a>";
                    echo "</div>";
                    echo "</div>";
                }
                ?>

            </div>

        </div>

    </form>


</div>