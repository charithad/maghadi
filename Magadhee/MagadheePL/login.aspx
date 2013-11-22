<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>


<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8">
<!--[if lt IE 9]>
    <script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
<![endif]-->
    <link href="css/common.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
    <link href="dist/css/bootstrap-theme.css" rel="stylesheet">
    <link href="dist/css/jquery-ui.css" rel="stylesheet">
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <link href="font-awesome/css/font-awesome-ie7.css" rel="stylesheet"> 
    <link href="dist/css/bootstrap.css" rel="stylesheet">
    
<title>Login</title>

<link rel="stylesheet" href="dist/css/jquery-ui.css" />

    <script type='text/javascript' src="dist/js/respond.src.js"></script>
    <script type='text/javascript' src="dist/js/modernizr.custom.84719.js"></script>
  <!--<link rel="stylesheet" href="/resources/demos/style.css" />-->
  
</head>

<body>



<nav class="navbar-inverse navbar-default" role="navigation">
  <!-- Brand and toggle get grouped for better mobile display -->
  <div class="navbar-header">
    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
      <span class="sr-only">Toggle navigation</span>
      <span class="icon-bar"></span>
      <span class="icon-bar"></span>
      <span class="icon-bar"></span>
    </button>
    <a class="navbar-brand" href="#">www.lodging.lk</a>
  </div>

  <!-- Collect the nav links, forms, and other content for toggling -->
  <div class="collapse navbar-collapse navbar-ex1-collapse ">
    <ul class="nav navbar-nav ">
      <li class="active"><a href="#"><i class="icon-home"></i> HOME</a></li>
      <li><a href="#"><i class="icon-coffee"></i> ABOUT</a></li>
      <li><a href="#"><i class="icon-phone-sign"></i> CONTACT US</a></li>
      <li><a href="#"><i class="icon-legal"></i> TERMS & CONDITIONS</a></li>
    </ul>
   
    
  </div><!-- /.navbar-collapse -->
</nav>

<div class="container">
	<div class="col-lg-12 col-md-12 col-sm-12 h10"></div>
</div>
<div class="container">
<form id="form2" class="form-horizontal" runat="server">
	<div class="row">
    
        <div class="col-lg-4 col-md-6 col-sm-12">
        	
      	</div>
        
        <div class="col-lg-8 col-md-6 col-sm-12">
        	
        
       	  <div class="col-lg-6 col-md-12 col-sm-12">
                
                	<div class="col-lg-12 col-md-12 col-sm-12 Login visible-lg visible-md">
                	
       				</div>
            			<div class="control-group">
                            <label class="control-label">User Name</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-print"></i></span>
        							<asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="User name"></asp:TextBox>
      							</div>
                            </div>			
                        </div>
                        
                        <div class="control-group">
                            <label class="control-label">Password</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-print"></i></span>
        							<asp:TextBox ID="TextBox2" runat="server" class="form-control" 
                                        placeholder="Password" TextMode="Password"></asp:TextBox>
      							</div>
                            </div>			
                    </div>
                    
                     
                    <hr/>
                        <div class="control-group">
                            <div class="controls">
                            <div class="row">
                                <div class="col-lg-4 col-md-4 col-sm-4">
                            
                                    <asp:Button ID="BtnSignUp" runat="server" Text="Sign In" 
                                            class="btn btn-info btn-lg" Width="120px" onclick="BtnSignUp_Click" />
                                </div>    
                            
                                <div class="col-lg-4 col-md-4 col-sm-4 ">    
                                     <asp:Button ID="BtnCancel" runat="server" Text="Cancel" 
                                            class="btn btn-info btn-lg" Width="120px"/> 
							    </div> 
                                  
                            </div>    
                                    
                                                               
                            </div>
                            
                        </div>	
                    <div class="col-lg-12 col-md-12 col-sm-12">
                        <p><asp:Label ID="Label1" runat="server" Text=""></asp:Label></p>
                    </div> 
            	</div>
			           
            
            
        </div>
        
    </div>
 </form>
</div>



	<script src="Index/Js/jquery-1.4.3.min.js"></script>
	<script src="dist/js/jquery.js"></script>
	<script src="dist/js/bootstrap.js"></script>
  	<script src="dist/js/holder.js"></script>
  	

  
  	<script src="Index/Js/jquery-ui-1.9.0.custom.min.js"></script>
  	<script src="dist/js/jquery-ui.js"></script>
    
	
	

	<script>


	    $(function () {
	        $("#dpf").datepicker();
	    });

	    $(function () {
	        $("#dpt").datepicker();
	    });

	    $('#my-carousel').carousel({

	        interval: 5000,
	        cycle: true

	    });

	    $('#my-news-carousel').carousel({

	        interval: 4000,
	        cycle: true

	    });
	    $('#my-attraction-carousel').carousel({

	        interval: 4000,
	        cycle: true

	    });
			

			
  	</script>

</body>
</html>
