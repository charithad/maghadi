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

<link href="css/common.css" rel="stylesheet" type="text/css" />
<link href="dist/css/bootstrap-theme.css" rel="stylesheet">
<link href="dist/css/jquery-ui.css" rel="stylesheet">
<link href="font-awesome/css/font-awesome.min.css" rel="stylesheet">
<link href="font-awesome/css/font-awesome-ie7.css" rel="stylesheet">
<link href="dist/css/bootstrap.css" rel="stylesheet">
<link href="css/theme.css" rel="stylesheet">
<link rel="stylesheet" type="text/css" href="dist/css/jquery.fullPage.css" />
<link rel="stylesheet" type="text/css" href="dist/css/page-slide.css" />

	<title>SNS Holiday Homes</title>
	<script type='text/javascript' src="dist/js/respond.src.js"></script>
	<script type='text/javascript' src="dist/js/modernizr.custom.84719.js"></script>

	<script type="text/javascript"  src="Index/Js/jquery-1.4.3.min.js"></script>
	<script type="text/javascript"  src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
  <script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.9.1/jquery-ui.min.js"></script>	
  
	<script type="text/javascript"  src="dist/js/bootstrap.js"></script>
  <script type="text/javascript"  src="dist/js/holder.js"></script>
  
  <script type="text/javascript" src="dist/js/jquery.fullPage.js"></script>
  <script type="text/javascript"  src="dist/js/rotator.js"></script>
  <script type="text/javascript"  src="dist/js/main_js.js"></script>
	
</head>
<body>
<script>!function(d,s,id){var js,fjs=d.getElementsByTagName(s)[0],p=/^http:/.test(d.location)?'http':'https';if(!d.getElementById(id)){js=d.createElement(s);js.id=id;js.src=p+'://platform.twitter.com/widgets.js';fjs.parentNode.insertBefore(js,fjs);}}(document, 'script', 'twitter-wjs');</script>

<form id="form1" runat="server">
  <nav class="navbar-inverse navbar-default navbar-fixed-top" role="navigation">
      <!-- Brand and toggle get grouped for better mobile display -->
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse"> <span class="sr-only">Toggle navigation</span> 
      <span class="icon-bar"></span> 
      <span class="icon-bar"></span> 
      <span class="icon-bar"></span> </button>
      <a class="navbar-brand" href="#">SNS Holiday Homes</a> </div>
    <!-- Collect the nav links, forms, and other content for toggling -->
    <div class="collapse navbar-collapse navbar-ex1-collapse ">
      <ul id="menu" class="nav navbar-nav ">
        <li data-menuanchor="firstPage" class="active"><a href="#firstPage"><i class="icon-home"></i> HOME</a></li>
        <li data-menuanchor="secondPage"><a href="#secondPage"><i class="icon-phone-sign"></i> PLACES</a></li>
        <li data-menuanchor="3rdPage"><a href="#3rdPage"><i class="icon-phone-sign"></i> NEWS</a></li>
        <li data-menuanchor="4thpage"><a href="#4thpage"><i class="icon-phone-sign"></i> CONTACT US</a></li>
        <li data-menuanchor="lastPage"><a href="#lastPage"><i class="icon-legal"></i> TERMS & CONDITIONS</a></li>
      </ul>
    </div>
    <!-- /.navbar-collapse -->
  </nav>
  <div class="row row-margin">
  <div class="section" id="section0">
    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 col-margin ">
    	<div class="h30"></div>
    	<div class="background-dark-blue h100 hidden-sm hidden-xs">
      	<h1 class="h1-white">Home away from home</h1>
      </div>
      <div class="background-dark-blue h100 hidden-lg hidden-md">
      	<h1 class="whites text-center">Home away from home</h1>
      </div>
    </div>
	
	  <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
      <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
        	<div class="hidden-sm hidden-xs">
          	<div class="h500"></div>
          </div>
        </div>
    	</div>
    	<div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
        <div class="row row-margin">
          <div class="hidden-sm hidden-xs">
            <div class="h100"></div>
          </div>
          <asp:PlaceHolder ID="Plc_Lodge" runat="server"></asp:PlaceHolder>
        </div>
      </div>  
    </div> 
    </div>
  </div>
  <div class="row row-margin">
    <div class="section" id="section1">
      <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 col-margin ">
          <div class="h30"></div>
        <div class="background-dark-blue h100 hidden-sm hidden-xs">
          <h1 class="h1-white">Places to visit</h1>
        </div>
        <div class="background-dark-blue h100 hidden-lg hidden-md">
          <h1 class="whites text-center">Places to visit</h1>
        </div>
        <div class="row row-margin">
        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 col-margin background-white-content">
          <div class="carousel slide" id="my-news-carousel">
            <div class="carousel-inner">
              <asp:PlaceHolder ID="Plc_Attractions" runat="server"></asp:PlaceHolder>
            </div>
            <a href="#my-carousel" class="carousel-control car-plain left col-lg-12 col-md-12 col-sm-12" data-slide="prev">&lsaquo;</a> <a href="#my-carousel" class="carousel-control car-plain right col-lg-12 col-md-12 col-sm-12" data-slide="next">&rsaquo;</a> 
          </div>
          </div>
        </div>
        </div>
      </div>
  	<div class="row row-margin h600">
    </div>

  </div>
  
  <div class="row row-margin">
  <div class="section" id="section2">
  <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 col-margin ">
    	<div class="h30"></div>
    <div class="background-dark-blue h100 hidden-sm hidden-xs">
      <h1 class="h1-white">Latest News</h1>
    </div>
    <div class="background-dark-blue h100 hidden-lg hidden-md">
      <h1 class="whites text-center">Latest News</h1>
    </div>
    <div class="row row-margin">
      <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 col-margin background-white-content">
        <div class="row row-margin">
          <div class="carousel slide" id="my-attraction-carousel">
            <div class="carousel-inner" id="lnews">
              <asp:PlaceHolder ID="Plc_News" runat="server"></asp:PlaceHolder>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
  </div>
    <div class="row row-margin h560">
    </div>
  </div>
  
  <div class="row row-margin">
    <div class="section" id="section3">
      <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 col-margin ">
        <div class="background-dark-blue h100 visible-lg visible-md">
          <h1 class="h1-white m0">Contacts</h1>
        </div>
      	<div class="background-dark-blue h100 visible-sm visible-xs">
        	<h1 class="whites text-center">Contacts</h1>
      	</div>
        <div class="row row-margin">
        	<div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 col-margin background-white-content">
            <div id="DivGuestId" class="row row-margin">
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
                        <asp:Button ID="BtnSub" runat="server" Text="Submit" class="btn btn-info btn-lg" onclick="BtnSub_Click"/>                
                    </div>
                  </div>		
               </div>
            </div>
          </div>
        </div>
    	</div>
    </div>
  </div>
  <div class="row row-margin">
  <div class="section" id="section4">
  <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 col-margin ">
        <div class="h30"></div>
    <div class="background-dark-blue h100 hidden-sm hidden-xs">
      <h1 class="h1-white">Terms and conditions</h1>
    </div>
    <div class="background-dark-blue h100 hidden-lg hidden-md">
      <h1 class="whites text-center">Terms and conditions</h1>
    </div>
    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 col-margin background-white-content h600">
    	<div id="DivGuestId" class="row row-margin">
      <div class="h100"></div>
      	<div class="col-lg-12 col-md-12 col-xs-12 col-sm-12">
        	Charitha
        </div>
      </div>
    </div>
  </div>
  </div>
  </div>
  </form>
</body>
</html>
