<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>
<html lang="en">
<head id="Head1" runat="server">
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

<title>SNS Holiday Homes</title>

    <script type='text/javascript' src="dist/js/respond.src.js"></script>
    <script type='text/javascript' src="dist/js/modernizr.custom.84719.js"></script>

</head>
<body>
<form id="form1" runat="server">
  <nav class="navbar-inverse navbar-default" role="navigation">
    <!-- Brand and toggle get grouped for better mobile display -->
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse"> <span class="sr-only">Toggle navigation</span> <span class="icon-bar"></span> <span class="icon-bar"></span> <span class="icon-bar"></span> </button>
      <a class="navbar-brand" href="#">www.snsholidayhomes.com</a> </div>
    <!-- Collect the nav links, forms, and other content for toggling -->
    <div class="collapse navbar-collapse navbar-ex1-collapse ">
      <ul class="nav navbar-nav ">
        <li class="active"><a href="#"><i class="icon-home"></i> HOME</a></li>
        <li><a href="#"><i class="icon-phone-sign"></i> CONTACT US</a></li>
        <li><a href="#"><i class="icon-legal"></i> TERMS & CONDITIONS</a></li>
      </ul>
    </div>
    <!-- /.navbar-collapse -->
  </nav>
  <img class="img-responsive visible-lg " src="Images/Home/1.jpg" width="100%" longdesc="Images/Home/1.jpg" /> <img class="img-responsive visible-sm " src="Images/Home/3.jpg" width="100%" longdesc="Images/Home/3.jpg" /> <img class="img-responsive visible-md" src="Images/Home/2.jpg" width="100%" longdesc="Images/Home/2.jpg" />
  </div>
  <div class="container">
    <div class="col-lg-12 col-md-12 col-sm-12 h10"></div>
  </div>
  <div class="container">
    <div class="row">
      <div class="col-lg-12 col-md-12 col-sm-12">
      	<div class="row">
        	
            	<div class="col-lg-4 col-md-6 col-sm-12">
                	<div class="row color-div-lodge">
                      <div class="col-lg-12 col-md-12 col-sm-12">
                        <div class="row">
                          <div class="col-lg-12 col-md-6 col-sm-12">
                            <h1 class="ColorBack">Lodging Available</h1>
                          </div>
                        </div>
                        <div id="DivGuestId" class="row">
                          <div class="col-lg-12 col-md-12 col-sm-12 h10">
                            
                              <asp:PlaceHolder ID="Plc_Lodge" runat="server"></asp:PlaceHolder>
                            
                          </div>
                        </div>
                      </div>
                    </div>
                    
                    
                    
                    <div class="row color-div-lodge">
                      <div class="col-lg-12 col-md-12 col-sm-12">
                        <div class="row">
                          <div class="col-lg-12 col-md-6 col-sm-12">
                            <h1 class="ColorBack">Send Message</h1>
                          </div>
                        </div>
                        <div id="DivGuestId" class="row">
                          <div class="col-lg-12 col-md-12 col-sm-12 h10">
                            
                            <div class="control-group">
                              <label class="control-label">Name</label>
                                <div class="controls">
                                    <div class="input-group">
        							    <span class="input-group-addon"><i class="icon-pencil"></i></span>
        							    <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="Name"></asp:TextBox>
      							    </div>
                                </div>			
                            </div>

                            <div class="control-group">
                              <label class="control-label">E-Mail</label>
                                <div class="controls">
                                    <div class="input-group">
        							    <span class="input-group-addon"><i class="icon-envelope"></i></span>
        							    <asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="E-Mail"></asp:TextBox>
      							    </div>
                                </div>			
                            </div>

                            

                            <div class="control-group">
                              <label class="control-label">Message</label>
                               
        							    
        					    <asp:TextBox ID="TextBox13" Rows=3 class="form-control" runat="server" TextMode="MultiLine" placeholder="Message"></asp:TextBox>
      									
                            </div>

                            <hr/>
                        <div class="control-group">
                            <div class="controls">
                                <asp:Button ID="BtnSub" runat="server" Text="Submit" 
                                    class="btn btn-info btn-lg" onclick="BtnSub_Click"/>               
                                
                            </div>
                        </div>		
                          </div>
                        </div>
                      </div>
                    </div>
                    
                </div>
                
            	
          	
              
          <div class="col-lg-8 col-md-6 col-sm-12">
          	<div class="row">
            
            	<div class="col-lg-6 col-md-6 col-sm-12">
                	<div class="row color-div-lodge">
                        <div class="col-lg-12 col-md-12 col-sm-12">
                            <div class="row">
                              <div class="col-lg-12 col-md-12 col-sm-12">
                                <h1 class="ColorBack">Whats on Offer</h1>
                              </div>
                            </div>
                            <div class="carousel slide" id="my-attraction-carousel">
                              <div class="carousel-inner" id="lguest">
                                <asp:PlaceHolder ID="Plc_Guest" runat="server"></asp:PlaceHolder>
                              </div>
                            </div>
              			</div>
                      </div>
                </div>
                
                <div class="col-lg-6 col-md-6 col-sm-12">
                
                	<div class="row color-div-lodge">
                    	  <div class="col-lg-12 col-md-6 col-sm-12">
                            <h1 class="ColorBack">Lodging Available</h1>
                          </div>
                     </div>
                </div>
              </div>
            
            
            
              <div class="col-lg-12 col-md-12 col-sm-12">
                <div class="row colored-div">
                  <div class="col-lg-12 col-md-12 col-sm-12">
                    <h1 class="ColorBack">Latest News</h1>
                  </div>
                
                <div class="carousel slide" id="my-attraction-carousel">
                  <div class="carousel-inner" id="lnews">
                    <asp:PlaceHolder ID="Plc_News" runat="server"></asp:PlaceHolder>
                  </div>
                </div>
              </div>
            </div>
            
              <div class="col-lg-12 col-md-12 col-sm-12">
                <div class="row colored-div">
                  <div class="col-lg-12 col-md-12 col-sm-12">
                    <h1 class="ColorBack">Attractions In The Area</h1>
                  </div>
                
                <div class="carousel slide" id="my-news-carousel">
                  <ol class="carousel-indicators">
                    <li data-target="#my-news-carousel" data-slide-to="0" class=""></li>
                    <li data-target="#my-news-carousel" data-slide-to="1" class=""></li>
                    <li data-target="#my-news-carousel" data-slide-to="2" class="active"></li>
                  </ol>
                  <div class="carousel-inner">
                    <asp:PlaceHolder ID="Plc_Attractions" runat="server"></asp:PlaceHolder>
                  </div>
                  <a href="#my-carousel" class="carousel-control car-plain left col-lg-12 col-md-12 col-sm-12" data-slide="prev">&lsaquo;</a> <a href="#my-carousel" class="carousel-control car-plain right col-lg-12 col-md-12 col-sm-12" data-slide="next">&rsaquo;</a> </div>
              </div>
            </div>
          </div>
     </div>
     </div>
    </div>
  </div>
</form>
<div class="col-lg-12 col-md-12 col-sm-12 footer-back-color footer-height">
    <div class="col-lg-12 col-md-12 col-sm-12  h10">
    </div>
     <p class="text-center">All rights reserved www.snsholidayhomes.com</p>
    
</div>

    <script src="Index/Js/jquery-1.4.3.min.js"></script>
	<script src="dist/js/jquery.js"></script>
	<script src="dist/js/bootstrap.js"></script>
  	<script src="dist/js/holder.js"></script>
  	
  	<script src="Index/Js/jquery-ui-1.9.0.custom.min.js"></script>
  	<script src="dist/js/jquery-ui.js"></script>
    
    <script src="dist/js/rotator.js"></script>
    

<script>


    

    $('#my-carousel').carousel({

        interval: 5000,
        cycle: true

    });

    $('#my-news-carousel').carousel({

        interval: 7000,
        cycle: true

    });
	
    $("#BtnSub").click(function () {

	        var t1 = $("#TextBox1").val();
	        var t2 = $("#TextBox2").val();
	        var t13 = $("#TextBox13").val();
	        


	        if (t1 == "") {
	            alert("First Name Field Can Not be Empty");
	            return false;
	        }

	        if (t2 == "") {
	            alert("Last Name Field Can Not be Empty");
	            return false;
	        }

	        if (t13 == "") {
	            alert("E-Mail Field Can Not be Empty");
	            return false;
	        }

	        

	    });


			
  	</script>


</body>
