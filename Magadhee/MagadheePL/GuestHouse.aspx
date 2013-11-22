<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GuestHouse.aspx.cs" Inherits="GuestHouse" %>

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
    
<title>Lodging Available</title>

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
    <a class="navbar-brand" href="#">www.snsholidayhomes.com</a>
  </div>

  <!-- Collect the nav links, forms, and other content for toggling -->
  <div class="collapse navbar-collapse navbar-ex1-collapse ">
    <ul class="nav navbar-nav ">
      <li><a href="Index.aspx"><i class="icon-home"></i> HOME</a></li>
      <li><a href="#"><i class="icon-phone-sign"></i> CONTACT US</a></li>
      <li><a href="#"><i class="icon-legal"></i> TERMS & CONDITIONS</a></li>
    </ul>
   
    
  </div><!-- /.navbar-collapse -->
</nav>

<div class="container">
	<div class="col-lg-12 col-md-12 col-sm-12 h10"></div>
</div>
<div class="container">
	<div class="row">
    	<div class="col-lg-12 col-md-12 col-sm-12">
        	<div class="col-lg-8 col-md-8 col-sm-12" >
            <div class="row colored-div">
            	<div class="col-lg-3 col-md-3 col-sm-12">
                    <h1 class="text-left"> Facilities</h1>
                        <table class="table table-bordered table-condensed">
                    
                            <thead>
                                <tr>
                                    <th>Facility</th>
                                    <th>Availability</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr class="">
                                    <td>Adi</td>
                                    <td>Purdila</td>
                                </tr>
                                <tr class="error">
                                    <td>John</td>
                                    <td>Smith</td>
                                </tr>
                                <tr class="warning">
                                    <td>Adi</td>
                                    <td>Purdila</td>
                                </tr>
                                <tr class="info">
                                    <td>Adi</td>
                                    <td>Purdila</td>
                                </tr>
                                <tr class="">
                                    <td>Adi</td>
                                    <td>Purdila</td>
                                </tr>
                                <tr class="error">
                                    <td>John</td>
                                    <td>Smith</td>
                                </tr>
                                <tr class="warning">
                                    <td>Adi</td>
                                    <td>Purdila</td>
                                </tr>
                                <tr class="info">
                                    <td>Adi</td>
                                    <td>Purdila</td>
                                </tr>
                                <tr class="warning">
                                    <td>Adi</td>
                                    <td>Purdila</td>
                                </tr>
                                <tr class="info">
                                    <td>Adi</td>
                                    <td>Purdila</td>
                                </tr>
                            </tbody>
                    </table>
                    </div>
            
        		<div class="col-lg-9 col-md-9 col-sm-12" >
            <div class="row">
                <div><h1>
                    <asp:Label ID="lbl_head" runat="server" Text="Label"></asp:Label></h1></div>
            	<div class="carousel slide" id="my-carousel">
                    <ol class="carousel-indicators">
                        <li data-target="#my-carousel" data-slide-to="0" class=""></li>
                        <li data-target="#my-carousel" data-slide-to="1" class=""></li>
                        <li data-target="#my-carousel" data-slide-to="2" class="active"></li>
                    </ol>
                
                    <div class="carousel-inner">
                        <asp:PlaceHolder ID="Plc_items" runat="server"></asp:PlaceHolder>
                    </div>
			
                    <a href="#my-carousel" class="carousel-control left col-lg-12 col-md-12 col-sm-12" data-slide="prev">&lsaquo;</a>
                    <a href="#my-carousel" class="carousel-control right col-lg-12 col-md-12 col-sm-12" data-slide="next">&rsaquo;</a>
				</div>
            	
            </div>
            </div>
            </div>
            
            
            <div class="row colored-div">
            
            	
            	<div class="col-lg-12 col-md-12 col-sm-12">
            
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                          <tr>
                            <td><h2 class="h3"><i class="icon-double-angle-right"></i> Price Per Day Without Breakfast</h2></td>
                            <td><h2 class="h3 pull-left">
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                </h2></td>
                          </tr>
                          <tr>
                            <td><h2 class="h3"><i class="icon-double-angle-right"></i> Price Per Day With Breakfast</h2></td>
                            <td><h2 class="h3 pull-left">
                                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                </h2></td>
                          </tr>
                          <tr>
                            <td><h2 class="h3"><i class="icon-double-angle-right"></i> Rooms Available</h2></td>
                            <td><h2 class="h3 pull-left">
                                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                                </h2></td>
                          </tr>
                          
                          <tr>
                            <td><h2 class="h3"><i class="icon-double-angle-right"></i> Contact Person</h2></td>
                            <td><h2 class="h3 pull-left">
                                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                                </h2></td>
                          </tr>

                          <tr>
                            <td><h2 class="h3"><i class="icon-double-angle-right"></i> Contact Number </h2></td>
                            <td><h2 class="h3 pull-left">
                                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                                </h2></td>
                          </tr>
                          
                    </table>

            	</div>
           
            
            </div>
            
            <div class="row colored-div">
            
            	
            	<div class="col-lg-12 col-md-12 col-sm-12">
            
                    <p><asp:Label ID="lbl_desc" runat="server" Text="Label"></asp:Label></p>
            	</div>
           
            
            </div>
            
            <div class="row colored-div">
                <div class="col-lg-12 col-md-6 col-sm-12">
                <div class="row">
                    <div class="col-lg-12 col-md-6 col-sm-12">
                        <h1>Attractions In The Area</h1>
                    </div>
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
					<a href="#my-carousel" class="carousel-control car-plain left col-lg-12 col-md-12 col-sm-12" data-slide="prev">&lsaquo;</a>
                    <a href="#my-carousel" class="carousel-control car-plain right col-lg-12 col-md-12 col-sm-12" data-slide="next">&rsaquo;</a>
                    
				</div>
                
                </div>
                </div>
                <div class="row colored-div">
                <div class="col-lg-12 col-md-6 col-sm-12">
                <div class="row">
                    <div class="col-lg-12 col-md-6 col-sm-12">
                        <h1>Latest News</h1>
                    </div>
                </div>
                <div class="carousel slide" id="my-attraction-carousel">
                    <ol class="carousel-indicators">
                        <li data-target="#my-attraction-carousel" data-slide-to="0" class=""></li>
                        <li data-target="#my-attraction-carousel" data-slide-to="1" class=""></li>
                        <li data-target="#my-attraction-carousel" data-slide-to="2" class="active"></li>
                    </ol>
                
                    <div class="carousel-inner">
                                              
                        <asp:PlaceHolder ID="Plc_News" runat="server"></asp:PlaceHolder>                   
                        
                    </div>
			
                    <a href="#my-attraction-carousel" class="carousel-control car-plain left col-lg-12 col-md-12 col-sm-12" data-slide="prev">&lsaquo;</a>
                    <a href="#my-attraction-carousel" class="carousel-control car-plain right col-lg-12 col-md-12 col-sm-12" data-slide="next">&rsaquo;</a>
				</div>
                
                </div>
            </div>
            </div>
            <div class="col-lg-4 col-md-4 col-sm-12">
            	<div class="row color-div-lodge">
                    
                    <div class="col-lg-12 col-md-12 col-sm-12">
                        <div class="row">
                            <div class="col-lg-12 col-md-6 col-sm-12">
                                <h1 class="text-left">Lodging Available</h1>
                            </div>
                        </div>
                    
                    	<div id="DivGuestId" class="row">
                        
                            <div class="col-lg-12 col-md-12 col-sm-12 h10">
                                <div class="row">
                                    <asp:PlaceHolder ID="Plc_Lodge" runat="server"></asp:PlaceHolder>  
                                </div>
                            </div>
                            
                        </div>
                    
                    </div>
            	</div>
                
                
            	<div runat="server" id="promo" class="row color-div-lodge">
                    
                    <div  class="col-lg-12 col-md-12 col-sm-12">
                        <div class="row">
                            <div class="col-lg-12 col-md-6 col-sm-12">
                                <h1 class="text-left">Promotions</h1>
                            </div>
                        </div>
                    
                    	<div id="DivGuestId" class="row">
                        
                            <div class="col-lg-12 col-md-12 col-sm-12 h10">
                                
                                    <asp:PlaceHolder ID="PlcPromo" runat="server"></asp:PlaceHolder>
                                
                            </div>
                            
                        </div>
                    
                    </div>
            	</div>
                
            	<div class="row color-div-forms">
               		<div class="col-lg-12 col-md-12 col-sm-12">
                        <div class="row">
                        <div class="col-lg-12 col-md-12 col-sm-12">
                            <h1 class="text-left">Make A Request</h1>
                        </div>
                        </div>
                    </div>
                	<div class="col-lg-12 col-md-12 col-sm-12 ">
                    	<form class="form-horizontal" runat="server">
                        
                        <div class="control-group">
                            <label class="control-label">With or Without Breakfast</label>
                            <div class="controls">
                            
                            <div class="input-group">
        							<span class="input-group-addon"><i class="icon-collapse"></i></span>
        							<asp:DropDownList ID="DropDownList3" class="btn btn-default form-control" runat="server">
                                        <asp:ListItem>With Breakfast</asp:ListItem>
                                        <asp:ListItem>Without Breakfast</asp:ListItem>
                                    </asp:DropDownList>	
      							</div>
                            
                            
                                
                            </div>			
                        </div>
                                               
                        <div class="control-group">
                            <label class="control-label">First Name</label>
                            <div class="controls">
                            <div class="input-group">
        							<span class="input-group-addon"><i class="icon-pencil"></i></span>
        							<asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="First Name"></asp:TextBox>
      							</div>
                            </div>			
                        </div>

                        <div class="control-group">
                            <label class="control-label">Last Name</label>
                            <div class="controls">
                            <div class="input-group">
        							<span class="input-group-addon"><i class="icon-pencil"></i></span>
        							<asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="Last Name"></asp:TextBox>
      							</div>
                            </div>			
                        </div>
            
                        <div class="control-group">
                            <label class="control-label">E-Mail</label>
                            <div class="controls">
                            <div class="input-group">
        							<span class="input-group-addon"><i class="icon-envelope"></i></span>
        							<asp:TextBox ID="TextBox3" runat="server" class="form-control" placeholder="E-mail"></asp:TextBox>
      							</div>
                            </div>			
                        </div>

						<div class="control-group">
							<label class="control-label">Conatct Number</label>
							<div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-phone"></i></span>
        							<asp:TextBox ID="TextBox4" runat="server" class="form-control" placeholder="Contact 01"></asp:TextBox>
      							</div>
                            </div>			
						</div>
            
                        <div class="control-group">
                            <label class="control-label">Mobile Number</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-phone"></i></span>
        							<asp:TextBox ID="TextBox5" runat="server" class="form-control" placeholder="Mobile"></asp:TextBox>
      							</div>
                            </div>			
                        </div>
                        
                        <div class="control-group">
                            <label class="control-label">Fax Number</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-print"></i></span>
        							<asp:TextBox ID="TextBox6" runat="server" class="form-control" placeholder="Fax"></asp:TextBox>
      							</div>
                            </div>			
                        </div>
                        
 						<div class="control-group">
                            <label class="control-label">From Date</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-calendar"></i></span>
        							<asp:TextBox ID="dpf" runat="server" class="form-control" placeholder="From"></asp:TextBox> 
      							</div>
                            </div>			
                        </div>
                        
            
            			<div class="control-group">
                            <label class="control-label">To Date</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-calendar"></i></span>
        							<asp:TextBox ID="dpt" runat="server" class="form-control" placeholder="To"></asp:TextBox> 
      							</div>
                            </div>			
                        </div>
            			
                        <div class="control-group">
                            <label class="control-label">Select Your Country</label>
                            <div class="controls">
                            
                            <div class="input-group">
        							<span class="input-group-addon"><i class="icon-collapse"></i></span>                                
                                    <asp:DropDownList ID="DropDownList4" class="btn btn-default form-control" runat="server">
                                        
                                        <asp:ListItem>Country...</asp:ListItem>
                                        <asp:ListItem>Afghanistan</asp:ListItem>
                                        <asp:ListItem>Albania</asp:ListItem>
                                        <asp:ListItem>Algeria</asp:ListItem>
                                        <asp:ListItem>American Samoa</asp:ListItem>
                                        <asp:ListItem>Andorra</asp:ListItem>
                                        <asp:ListItem>Angola</asp:ListItem>
                                        <asp:ListItem>Anguilla</asp:ListItem>
                                        <asp:ListItem>Antigua &amp; Barbuda</asp:ListItem>
                                        <asp:ListItem>Argentina</asp:ListItem>
                                        <asp:ListItem>Armenia</asp:ListItem>
                                        <asp:ListItem>Aruba</asp:ListItem>
                                        <asp:ListItem>Australia</asp:ListItem>
                                        <asp:ListItem>Austria</asp:ListItem>
                                        <asp:ListItem>Azerbaijan</asp:ListItem>
                                        <asp:ListItem>Bahamas</asp:ListItem>
                                        <asp:ListItem>Bahrain</asp:ListItem>
                                        <asp:ListItem>Bangladesh</asp:ListItem>
                                        <asp:ListItem>Barbados</asp:ListItem>
                                        <asp:ListItem>Belarus</asp:ListItem>
                                        <asp:ListItem>Belgium</asp:ListItem>
                                        <asp:ListItem>Belize</asp:ListItem>
                                        <asp:ListItem>Benin</asp:ListItem>
                                        <asp:ListItem>Bermuda</asp:ListItem>
                                        <asp:ListItem>Bhutan</asp:ListItem>
                                        <asp:ListItem>Bolivia</asp:ListItem>
                                        <asp:ListItem>Bonaire</asp:ListItem>
                                        <asp:ListItem>Bosnia &amp; Herzegovina</asp:ListItem>
                                        <asp:ListItem>Botswana</asp:ListItem>
                                        <asp:ListItem>Brazil</asp:ListItem>
                                        <asp:ListItem>British Indian Ocean Ter</asp:ListItem>
                                        <asp:ListItem>Brunei</asp:ListItem>
                                        <asp:ListItem>Bulgaria</asp:ListItem>
                                        <asp:ListItem>Burkina Faso</asp:ListItem>
                                        <asp:ListItem>Burundi</asp:ListItem>
                                        <asp:ListItem>Cambodia</asp:ListItem>
                                        <asp:ListItem>Cameroon</asp:ListItem>
                                        <asp:ListItem>Canada</asp:ListItem>
                                        <asp:ListItem>Canary Islands</asp:ListItem>
                                        <asp:ListItem>Cape Verde</asp:ListItem>
                                        <asp:ListItem>Cayman Islands</asp:ListItem>
                                        <asp:ListItem>Central African Republic</asp:ListItem>
                                        <asp:ListItem>Chad</asp:ListItem>
                                        <asp:ListItem>Channel Islands</asp:ListItem>
                                        <asp:ListItem>Chile</asp:ListItem>
                                        <asp:ListItem>China</asp:ListItem>
                                        <asp:ListItem>Christmas Island</asp:ListItem>
                                        <asp:ListItem>Cocos Island</asp:ListItem>
                                        <asp:ListItem>Colombia</asp:ListItem>
                                        <asp:ListItem>Comoros</asp:ListItem>
                                        <asp:ListItem>Congo</asp:ListItem>
                                        <asp:ListItem>Cook Islands</asp:ListItem>
                                        <asp:ListItem>Costa Rica</asp:ListItem>
                                        <asp:ListItem>Cote D'Ivoire</asp:ListItem>
                                        <asp:ListItem>Croatia</asp:ListItem>
                                        <asp:ListItem>Cuba</asp:ListItem>
                                        <asp:ListItem>Curacao</asp:ListItem>
                                        <asp:ListItem>Cyprus</asp:ListItem>
                                        <asp:ListItem>Czech Republic</asp:ListItem>
                                        <asp:ListItem>Denmark</asp:ListItem>
                                        <asp:ListItem>Djibouti</asp:ListItem>
                                        <asp:ListItem>Dominica</asp:ListItem>
                                        <asp:ListItem>Dominican Republic</asp:ListItem>
                                        <asp:ListItem>East Timor</asp:ListItem>
                                        <asp:ListItem>Ecuador</asp:ListItem>
                                        <asp:ListItem>Egypt</asp:ListItem>
                                        <asp:ListItem>El Salvador</asp:ListItem>
                                        <asp:ListItem>Equatorial Guinea</asp:ListItem>
                                        <asp:ListItem>Eritrea</asp:ListItem>
                                        <asp:ListItem>Estonia</asp:ListItem>
                                        <asp:ListItem>Ethiopia</asp:ListItem>
                                        <asp:ListItem>Falkland Islands</asp:ListItem>
                                        <asp:ListItem>Faroe Islands</asp:ListItem>
                                        <asp:ListItem>Fiji</asp:ListItem>
                                        <asp:ListItem>Finland</asp:ListItem>
                                        <asp:ListItem>France</asp:ListItem>
                                        <asp:ListItem>French Guiana</asp:ListItem>
                                        <asp:ListItem>French Polynesia</asp:ListItem>
                                        <asp:ListItem>French Southern Ter</asp:ListItem>
                                        <asp:ListItem>Gabon</asp:ListItem>
                                        <asp:ListItem>Gambia</asp:ListItem>
                                        <asp:ListItem>Georgia</asp:ListItem>
                                        <asp:ListItem>Germany</asp:ListItem>
                                        <asp:ListItem>Ghana</asp:ListItem>
                                        <asp:ListItem>Gibraltar</asp:ListItem>
                                        <asp:ListItem>Great Britain</asp:ListItem>
                                        <asp:ListItem>Greece</asp:ListItem>
                                        <asp:ListItem>Greenland</asp:ListItem>
                                        <asp:ListItem>Grenada</asp:ListItem>
                                        <asp:ListItem>Guadeloupe</asp:ListItem>
                                        <asp:ListItem>Guam</asp:ListItem>
                                        <asp:ListItem>Guatemala</asp:ListItem>
                                        <asp:ListItem>Guinea</asp:ListItem>
                                        <asp:ListItem>Guyana</asp:ListItem>
                                        <asp:ListItem>Haiti</asp:ListItem>
                                        <asp:ListItem>Hawaii</asp:ListItem>
                                        <asp:ListItem>Honduras</asp:ListItem>
                                        <asp:ListItem>Hong Kong</asp:ListItem>
                                        <asp:ListItem>Hungary</asp:ListItem>
                                        <asp:ListItem>Iceland</asp:ListItem>
                                        <asp:ListItem>India</asp:ListItem>
                                        <asp:ListItem>Indonesia</asp:ListItem>
                                        <asp:ListItem>Iran</asp:ListItem>
                                        <asp:ListItem>Iraq</asp:ListItem>
                                        <asp:ListItem>Ireland</asp:ListItem>
                                        <asp:ListItem>Isle of Man</asp:ListItem>
                                        <asp:ListItem>Israel</asp:ListItem>
                                        <asp:ListItem>Italy</asp:ListItem>
                                        <asp:ListItem>Jamaica</asp:ListItem>
                                        <asp:ListItem>Japan</asp:ListItem>
                                        <asp:ListItem>Jordan</asp:ListItem>
                                        <asp:ListItem>Kazakhstan</asp:ListItem>
                                        <asp:ListItem>Kenya</asp:ListItem>
                                        <asp:ListItem>Kiribati</asp:ListItem>
                                        <asp:ListItem>Korea North</asp:ListItem>
                                        <asp:ListItem>Korea South</asp:ListItem>
                                        <asp:ListItem>Kuwait</asp:ListItem>
                                        <asp:ListItem>Kyrgyzstan</asp:ListItem>
                                        <asp:ListItem>>Laos</asp:ListItem>
                                        <asp:ListItem>Latvia</asp:ListItem>
                                        <asp:ListItem>Lebanon</asp:ListItem>
                                        <asp:ListItem>Lesotho</asp:ListItem>
                                        <asp:ListItem>Liberia</asp:ListItem>
                                        <asp:ListItem>Libya</asp:ListItem>
                                        <asp:ListItem>Liechtenstein</asp:ListItem>
                                        <asp:ListItem>Lithuania</asp:ListItem>
                                        <asp:ListItem>Luxembourg</asp:ListItem>
                                        <asp:ListItem>Macau</asp:ListItem>
                                        <asp:ListItem>Macedonia</asp:ListItem>
                                        <asp:ListItem>Madagascar</asp:ListItem>
                                        <asp:ListItem>Malaysia</asp:ListItem>
                                        <asp:ListItem>Malawi</asp:ListItem>
                                        <asp:ListItem>Maldives</asp:ListItem>
                                        <asp:ListItem>Mali</asp:ListItem>
                                        <asp:ListItem>Malta</asp:ListItem>
                                        <asp:ListItem>Marshall Islands</asp:ListItem>
                                        <asp:ListItem>Martinique</asp:ListItem>
                                        <asp:ListItem>Mauritania</asp:ListItem>
                                        <asp:ListItem>Mauritius</asp:ListItem>
                                        <asp:ListItem>Mayotte</asp:ListItem>
                                        <asp:ListItem>Mexico</asp:ListItem>
                                        <asp:ListItem>Midway Islands</asp:ListItem>
                                        <asp:ListItem>Moldova</asp:ListItem>
                                        <asp:ListItem>Monaco</asp:ListItem>
                                        <asp:ListItem>Mongolia</asp:ListItem>
                                        <asp:ListItem>Montserrat</asp:ListItem>
                                        <asp:ListItem>Morocco</asp:ListItem>
                                        <asp:ListItem>Mozambique</asp:ListItem>
                                        <asp:ListItem>Myanmar</asp:ListItem>
                                        <asp:ListItem>Nambia</asp:ListItem>
                                        <asp:ListItem>Nauru</asp:ListItem>
                                        <asp:ListItem>Nepal</asp:ListItem>
                                        <asp:ListItem>Netherland Antilles</asp:ListItem>
                                        <asp:ListItem>Netherlands (Holland, Europe)</asp:ListItem>
                                        <asp:ListItem>Nevis</asp:ListItem>
                                        <asp:ListItem>New Caledonia</asp:ListItem>
                                        <asp:ListItem>New Zealand</asp:ListItem>
                                        <asp:ListItem>Nicaragua</asp:ListItem>
                                        <asp:ListItem>Niger</asp:ListItem>
                                        <asp:ListItem>Nigeria</asp:ListItem>
                                        <asp:ListItem>Niue</asp:ListItem>
                                        <asp:ListItem>Norfolk Island</asp:ListItem>
                                        <asp:ListItem>Norway</asp:ListItem>
                                        <asp:ListItem>Oman</asp:ListItem>
                                        <asp:ListItem>Pakistan</asp:ListItem>
                                        <asp:ListItem>Palau Island</asp:ListItem>
                                        <asp:ListItem>Palestine</asp:ListItem>
                                        <asp:ListItem>Panama</asp:ListItem>
                                        <asp:ListItem>Papua New Guinea</asp:ListItem>
                                        <asp:ListItem>Paraguay</asp:ListItem>
                                        <asp:ListItem>Peru</asp:ListItem>
                                        <asp:ListItem>Philippines</asp:ListItem>
                                        <asp:ListItem>Pitcairn Island</asp:ListItem>
                                        <asp:ListItem>Poland</asp:ListItem>
                                        <asp:ListItem>Portugal</asp:ListItem>
                                        <asp:ListItem>Puerto Rico</asp:ListItem>
                                        <asp:ListItem>Qatar</asp:ListItem>
                                        <asp:ListItem>Republic of Montenegro</asp:ListItem>
                                        <asp:ListItem>Republic of Serbia</asp:ListItem>
                                        <asp:ListItem>Reunion</asp:ListItem>
                                        <asp:ListItem>Romania</asp:ListItem>
                                        <asp:ListItem>Russia</asp:ListItem>
                                        <asp:ListItem>Rwanda</asp:ListItem>
                                        <asp:ListItem>St Barthelemy</asp:ListItem>
                                        <asp:ListItem>St Eustatius</asp:ListItem>
                                        <asp:ListItem>St Helena</asp:ListItem>
                                        <asp:ListItem>St Kitts-Nevis</asp:ListItem>
                                        <asp:ListItem>St Lucia</asp:ListItem>
                                        <asp:ListItem>St Maarten</asp:ListItem>
                                        <asp:ListItem>St Pierre &amp; Miquelon</asp:ListItem>
                                        <asp:ListItem>St Vincent &amp; Grenadines</asp:ListItem>
                                        <asp:ListItem>Saipan</asp:ListItem>
                                        <asp:ListItem>Samoa</asp:ListItem>
                                        <asp:ListItem>Samoa American</asp:ListItem>
                                        <asp:ListItem>San Marino</asp:ListItem>
                                        <asp:ListItem>Sao Tome &amp; Principe</asp:ListItem>
                                        <asp:ListItem>Saudi Arabia</asp:ListItem>
                                        <asp:ListItem>Senegal</asp:ListItem>
                                        <asp:ListItem>Serbia</asp:ListItem>
                                        <asp:ListItem>Seychelles</asp:ListItem>
                                        <asp:ListItem>Sierra Leone</asp:ListItem>
                                        <asp:ListItem>Singapore</asp:ListItem>
                                        <asp:ListItem>Slovakia</asp:ListItem>
                                        <asp:ListItem>Slovenia</asp:ListItem>
                                        <asp:ListItem>Solomon Islands</asp:ListItem>
                                        <asp:ListItem>Somalia</asp:ListItem>
                                        <asp:ListItem>South Africa</asp:ListItem>
                                        <asp:ListItem>Spain</asp:ListItem>
                                        <asp:ListItem>Sri Lanka</asp:ListItem>
                                        <asp:ListItem>Sudan</asp:ListItem>
                                        <asp:ListItem>Suriname</asp:ListItem>
                                        <asp:ListItem>Swaziland</asp:ListItem>
                                        <asp:ListItem>Sweden</asp:ListItem>
                                        <asp:ListItem>Switzerland</asp:ListItem>
                                        <asp:ListItem>Syria</asp:ListItem>
                                        <asp:ListItem>Tahiti</asp:ListItem>
                                        <asp:ListItem>Taiwan</asp:ListItem>
                                        <asp:ListItem>Tajikistan</asp:ListItem>
                                        <asp:ListItem>Tanzania</asp:ListItem>
                                        <asp:ListItem>Thailand</asp:ListItem>
                                        <asp:ListItem>Togo</asp:ListItem>
                                        <asp:ListItem>Tokelau</asp:ListItem>
                                        <asp:ListItem>Tonga</asp:ListItem>
                                        <asp:ListItem>Trinidad &amp; Tobago</asp:ListItem>
                                        <asp:ListItem>Tunisia</asp:ListItem>
                                        <asp:ListItem>Turkey</asp:ListItem>
                                        <asp:ListItem>Turkmenistan</asp:ListItem>
                                        <asp:ListItem>Turks &amp; Caicos Is</asp:ListItem>
                                        <asp:ListItem>Tuvalu</asp:ListItem>
                                        <asp:ListItem>Uganda</asp:ListItem>
                                        <asp:ListItem>Ukraine</asp:ListItem>
                                        <asp:ListItem>United Arab Emirates</asp:ListItem>
                                        <asp:ListItem>United Kingdom</asp:ListItem>
                                        <asp:ListItem>United States of America</asp:ListItem>
                                        <asp:ListItem>Uruguay</asp:ListItem>
                                        <asp:ListItem>Uzbekistan</asp:ListItem>
                                        <asp:ListItem>Vanuatu</asp:ListItem>
                                        <asp:ListItem>Vatican City State</asp:ListItem>
                                        <asp:ListItem>Venezuela</asp:ListItem>
                                        <asp:ListItem>Vietnam</asp:ListItem>
                                        <asp:ListItem>Virgin Islands (Brit)</asp:ListItem>
                                        <asp:ListItem>Virgin Islands (USA)</asp:ListItem>
                                        <asp:ListItem>Wake Island</asp:ListItem>
                                        <asp:ListItem>Wallis &amp; Futana Is</asp:ListItem>
                                        <asp:ListItem>Yemen</asp:ListItem>
                                        <asp:ListItem>Zaire</asp:ListItem>
                                        <asp:ListItem>Zambia</asp:ListItem>
                                        <asp:ListItem>Zimbabwe</asp:ListItem>

                                    </asp:DropDownList>	
      							</div>
                            
                            
                                
                            </div>			
                        </div>

                        <div class="control-group">
                            <label class="control-label">Number Of Adults</label>
                            <div class="controls">
                            
                            <div class="input-group">
        							<span class="input-group-addon"><i class="icon-collapse"></i></span>                                
                                    <asp:DropDownList ID="DropDownList1" class="btn btn-default form-control" runat="server">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                        <asp:ListItem>7</asp:ListItem>
                                    </asp:DropDownList>	
      							</div>
                            
                            
                                
                            </div>			
                        </div>
                        
                        <div class="control-group">
                            <label class="control-label">Number of Children</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-collapse"></i></span>
        							<asp:DropDownList ID="DropDownList2" class="btn btn-default form-control" runat="server">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                        <asp:ListItem>7</asp:ListItem>
                                    </asp:DropDownList>
      							</div>
                            </div>			
                        </div>
                        
                                               
						<hr/>
                        <div class="control-group">
                            <div class="controls">
                                <asp:Button ID="BtnReq" runat="server" Text="Make a Request" 
                                    class="btn btn-info btn-lg" onclick="BtnReq_Click"/>               
                                
                            </div>
                        </div>		
                        </form>
                        
                        
                    </div>
                </div>
            </div>
            
            
        </div>
    </div>
</div>

<div class="col-lg-12 col-md-12 col-sm-12 footer-back-color footer-height">
    <div class="col-lg-12 col-md-12 col-sm-12  h10">
    </div>
     <p class="text-center">All rights reserved www.snsholidayhomes.com</p>
    
</div>
	
	<script type='text/javascript' src="dist/js/jquery.js"></script>
	<script type='text/javascript' src="dist/js/bootstrap.js"></script>
    <script type="text/javascript" src="dist/js/rotator.js"></script>
  	<script type='text/javascript' src="Index/Js/jquery-ui-1.9.0.custom.min.js"></script>
    <script type='text/javascript' src="dist/js/jquery-ui.js"></script>
  	
     
    
    
    
    

    
	
	

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


	    $("#BtnReq").click(function () {

	        var t1 = $("#TextBox1").val();
	        var t2 = $("#TextBox2").val();
	        var t3 = $("#TextBox3").val();
	        var t4 = $("#TextBox4").val();
	        var t5 = $("#TextBox5").val();
	        var t6 = $("#TextBox6").val();
	        var t7 = $("#dpf").val();
	        var t8 = $("#dpt").val();
	        var dc = $("#DropDownList4").val();



	        if (t1 == "") {
	            alert("First Name Field Can Not be Empty");
	            return false;
	        }

	        if (t2 == "") {
	            alert("Last Name Field Can Not be Empty");
	            return false;
	        }

	        if (t3 == "") {
	            alert("E-Mail Field Can Not be Empty");
	            return false;
	        }

	        if (t4 == "") {
	            alert("Contact Number 01 Field Can Not be Empty");
	            return false;
	        }

	        if (t5 == "") {
	            alert("Mobile Number Field Can Not be Empty");
	            return false;
	        }

	        if (t6 == "") {
	            alert("Fax Number Field Can Not be Empty");
	            return false;
	        }

	        if (t7 == "") {
	            alert("Star Data Can Not be Empty");
	            return false;
	        }

	        if (t8 == "") {
	            alert("End Date Date Can Not be Empty");
	            return false;
	        }

	        if (dc == "Country...") {

	            alert("Please Select A Country");

	            return false;

	        }





	    });


			
  	</script>

</body>
</html>

