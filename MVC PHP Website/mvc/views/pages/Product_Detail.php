<!-- Web view to check detail of each product -->
<div class="menu-container">
    <form method="POST">
        <div class="item-deck">
            <!-- Object from Product class -->
            <?php
            $getParam = new App();
            $param = $getParam->__construct();
            $iProduct_detail = new Product();
            $list = $iProduct_detail->Detail($param);
            //Display product details
            while ($row = mysqli_fetch_array($list)) {
                echo "<img class='item-detail-img' src='mvc/views/images/{$row["id"]}.jpg' >";
                echo "<div>";
                echo "<h5 class='item-title'>{$row["title"]}</h5>";
                echo "<p class='item-text'>{$row["text"]}</p>";
                echo "<p class='item-detail-text'>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In rutrum, enim et venenatis mattis, ipsum risus interdum sapien, nec iaculis orci tortor et lorem. Curabitur id vehicula ante. Mauris ultricies, justo condimentum iaculis viverra, neque libero eleifend dui, non aliquet magna ante nec nunc. Suspendisse potenti. Phasellus nec congue metus, semper venenatis nisl. Quisque sed elit molestie, commodo lectus eget, ornare odio. Pellentesque laoreet in elit finibus faucibus. Praesent non elit auctor ante ornare sagittis.</p>";
                echo "<p class='item-price'>Price: {$row["price"]}</p>";
                echo "<a href='order/Creating_Order/{$row["id"]}'>Order</a>";
                echo "</div>";
            }
            ?>
        </div>
    </form>
</div>