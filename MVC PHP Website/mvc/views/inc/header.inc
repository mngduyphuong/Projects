<header>
    <nav class="navbar navbar-expand-lg navbar-dark" style="background-color: #55513d; height: 100px; padding: 10px; font-size:20px">
    <a class="navbar-brand" href="Home" style="font-weight: bold;font-size: 30px;">All your electronic</a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
    </button>

    <div class="collapse navbar-collapse" id="navbarSupportedContent" style="margin-left: 5%;">
        <ul class="navbar-nav mr-auto">
        <li class="nav-item">
            <a class="nav-link" href="Home">Home </a>
        </li>
         <li class="nav-item">
            <a class="nav-link" href="Product">Product</a>
        </li>
       
         <li class="nav-item">
            <a class="nav-link" href="Order">Order</a>
        </li>
        
        </ul>

       
           
            
        
    </div>
    <?php 
           if (isset($_SESSION['login_username']))
           {
               echo "<div style=' marin-left: 80%; width: 20%;'>";
               echo "<p style='color:red'>";
               echo "Account: ";
               echo $_SESSION['login_username'];
               echo "<a style='margin-left: 10%;' href='user/Logout_Membership'>Logout</a>";
               echo "</p>";
               echo "</div>";
           }
           else
           {
            echo "<a style= 'margin-right: 5%;'href='user'>Login</a>";
           }
    ?>
    </nav>
</header>