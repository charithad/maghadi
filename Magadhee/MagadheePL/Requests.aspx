<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Requests.aspx.cs" Inherits="Requests" %>

<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8">

    <link href="css/common.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
    <link href="dist/css/bootstrap-theme.css" rel="stylesheet">
    <link href="dist/css/jquery-ui.css" rel="stylesheet">
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <link href="font-awesome/css/font-awesome-ie7.css" rel="stylesheet"> 
    <link href="dist/css/bootstrap.css" rel="stylesheet">
    
<title>Requester</title>

<link rel="stylesheet" href="dist/css/jquery-ui.css" />

  <script type='text/javascript' src="dist/js/respond.src.js"></script>
    <script type='text/javascript' src="dist/js/modernizr.custom.84719.js"></script>
  <!--<link rel="stylesheet" href="/resources/demos/style.css" />-->
  
    <style type="text/css">

td {vertical-align:top;}

    </style>
  
</head>

<body>

<form id="form1" runat="server">

<nav class="navbar-inverse navbar-default" role="navigation">
  <!-- Brand and toggle get grouped for better mobile display -->
  <div class="navbar-header">
    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
      <span class="sr-only">Toggle navigation</span>
      <span class="icon-bar"></span>
      <span class="icon-bar"></span>
      <span class="icon-bar"></span>
    </button>
    
  </div>

  <!-- Collect the nav links, forms, and other content for toggling -->
  <div class="collapse navbar-collapse navbar-ex1-collapse ">
    <ul class="nav navbar-nav ">
      <li class="active"><a href="#">REQUESTER</i></a></li>
      <li><a href="AddGuestHouse.aspx">ADD LODGE</a></li>
      <li><a href="AddPromotions.aspx">ADD PROMOTION</a></li>
      <li><a href="AddAttractions.aspx">ADD ATTRACTION</a></li>
      <li><a href="AddClientTestimonial.aspx">ADD CLIENT TESTIMONIAL</a></li>
      <li><a href="AddHomeContent.aspx">ADD HOME CONTENT</a></li>
      <li><a href="AddNews.aspx">ADD NEWS</a></li>
      <li><a href="AddLocations.aspx">ADD LOCATION</a></li>
    </ul>
   
    
  </div><!-- /.navbar-collapse -->
</nav>
<div class="container">
	<div class="col-lg-12 col-md-12 col-sm-12 h10"></div>
</div>
<div class="container">
	<div class="row">
    	<div class="col-lg-12 col-md-12 col-sm-12">
        	<div class="row">
            	<div class="col-lg-12 col-md-12 col-sm-12">
        			<div class="row color-div-forms">
                    	<h1 class="h1">
    						New Requests
                        </h1>
            		</div>
        		</div>
                
                <div class="col-lg-12 col-md-12 col-sm-12">
        			
                    <div class="row color-div-lodge">
                	
                    <asp:GridView ID="GVReqNew" runat="server" AutoGenerateColumns="False" 
                    onrowcommand="GVReqNew_RowCommand">
                    
                    <Columns >
                        <asp:BoundField DataField="Request_Id" HeaderText="Request Id">
                        
                        </asp:BoundField>
                        <asp:BoundField DataField="Guest_name" HeaderText="Guest House">
                        <ControlStyle CssClass="visible-lg visible-md" />
                        <FooterStyle CssClass="visible-lg visible-md" />
                        <HeaderStyle CssClass="visible-lg visible-md" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Requester_Last_Name" HeaderText="Last Name">
                        <ControlStyle CssClass="visible-lg visible-md" />
                        <FooterStyle CssClass="visible-lg visible-md" />
                        <HeaderStyle CssClass="visible-lg visible-md" />
                        <ItemStyle Font-Names="Arial" Font-Size="11pt" CssClass="visible-lg visible-md" />
                        </asp:BoundField>
                         <asp:BoundField DataField="Requester_First_Name" HeaderText="First Name">
                        <ControlStyle CssClass="visible-lg visible-md" />
                        <FooterStyle CssClass="visible-lg visible-md" />
                        <HeaderStyle CssClass="visible-lg visible-md" />
                        </asp:BoundField>

                         <asp:BoundField DataField="Request_Date" HeaderText="Date">
                        <ControlStyle CssClass="visible-lg visible-md" />
                        <FooterStyle CssClass="visible-lg visible-md" />
                        <HeaderStyle CssClass="visible-lg visible-md" />
                        <ItemStyle   CssClass="visible-lg visible-md" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkDet0" runat="server" CausesValidation="false" 
                                    CommandArgument="<%# Container.DataItemIndex %>" CommandName="cmdBind">Edit Details</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                   </asp:GridView>
            		</div>
        		</div>
                
            </div>
            
            
            <div class="row">
            	<div class="col-lg-12 col-md-12 col-sm-12">
        			<div class="row color-div-forms">
                    	<h1>Edit</h1>
            		</div>
        		</div>
                
                <div class="col-lg-12 col-md-12 col-sm-12">
        			<div class="row">
                    	<div class="col-lg-6 col-md-12 col-sm-12 ">
        					<div class="row color-div-lodge">  
                                                                         
                        	
							
                            <div class="control-group">
                            	<label class="control-label">Lodge</label>
                                <div class="controls">
                                <div class="input-group">
                                        <h3><asp:Label ID="Label1" runat="server"></asp:Label></h3>
                                    </div>
                                </div>			
                        	</div>
                            
                        	<div class="control-group">
                            	<label class="control-label">Request_Id</label>
                                <div class="controls">
                                <div class="input-group">
                                        <h3><asp:Label ID="Label2" runat="server"></asp:Label></h3>
                                    </div>
                                </div>			
                        	</div>
            			
                        <div class="control-group">
                            <label class="control-label">First Name</label>
                                <div class="controls">
                                    <div class="input-group">
                                            <span class="input-group-addon"><i class="icon-pencil"></i></span>
                                            <asp:TextBox ID="TextBox1" runat="server" class="form-control" 
                                                placeholder="First Name" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
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
                            <label class="control-label">Country</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-print"></i></span>
        							<asp:DropDownList ID="TextBox7" class="btn btn-default form-control" runat="server">
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
                            
                            
                                          			

            				</div>
        				</div>
                        <div class="col-lg-6 col-md-12 col-sm-12">
        					<div class="row color-div-lodge">
                            
                            <div class="input-group">
        							<span class="input-group-addon"><i class="icon-collapse"></i></span>
        							<asp:DropDownList ID="DropDownList3" class="btn btn-default form-control" runat="server">
                                        <asp:ListItem>With Breakfast</asp:ListItem>
                                        <asp:ListItem>Without Breakfast</asp:ListItem>
                                    </asp:DropDownList>	
      							</div>

                            <div class="control-group">
                            <label class="control-label">From Date</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-calendar"></i></span>
        							<asp:TextBox ID="TextBox8" runat="server" class="form-control" placeholder="From"></asp:TextBox> 
      							</div>
                            </div>			
                        </div>
                        
            
            			<div class="control-group">
                            <label class="control-label">To Date</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-calendar"></i></span>
        							<asp:TextBox ID="TextBox9" runat="server" class="form-control" placeholder="To"></asp:TextBox> 
      							</div>
                            </div>			
                        </div>

                          <div class="control-group">
                            <label class="control-label">Adults</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-collapse"></i></span>                                
                                    <asp:DropDownList ID="TextBox10" class="btn btn-default form-control" runat="server">
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
                            <label class="control-label">Children</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-collapse"></i></span>                                
                                    <asp:DropDownList ID="TextBox11" class="btn btn-default form-control" runat="server">
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
                            <label class="control-label">Request Was Placed On</label>
                            <div class="controls">
                            	<div class="input-group">
        							<asp:Label ID="Label3" runat="server"></asp:Label>
      							</div>
                            </div>			
                        </div>
                        
                        <div class="control-group">
                            <label class="control-label">Amount</label>
                            <div class="controls">
                            	<div class="input-group">
        							<asp:Label ID="Label5" runat="server"></asp:Label>
      							</div>
                            </div>			
                        </div> 
                        
                         <div class="control-group">
                            <label class="control-label">Promotions</label>
                            <div class="controls">
                            	<div class="input-group">
        							<asp:Label ID="Label4" runat="server" Text=""></asp:Label>
      							</div>
                            </div>			
                        </div>   
                            
                    			 
                            </div>
                        
                            <div class="row color-div-lodge">
                                <table border="0" cellspacing="0" cellpadding="0" class="table table-condensed">
                                    <tr>
                                    <td><asp:Button ID="Button4" runat="server" Text="Edit" 
                                    class="btn btn-info btn-md" onclick="Button4_Click"/>
                                    
                                    <asp:Button ID="Button5" runat="server" Text="Confirm Request" 
                                    class="btn btn-info btn-md" onclick="Button5_Click"/>
                                    
                                    <asp:Button ID="Button6" runat="server" Text="Cancel Request" 
                                    class="btn btn-info btn-md" onclick="Button6_Click"/>
                                    
                                    </td>
                                    
                                    
                                    
                                  </tr>
                               </table>
                              
                            </div>

        				</div>
            		</div>
        		</div>
                
            </div>
            
            <div class="row color-div-forms">
                    	<h2 class="h2">Send Mail</h2>
            		</div>
        		
                
                	<div class="row color-div-lodge">
                	<div class="control-group">
                            <label class="control-label">Name</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-edit"></i></span>
        							<asp:TextBox ID="TextBox48" runat="server" class="form-control" placeholder="Name"></asp:TextBox> 
      							</div>
                            </div>			
                     </div>
                     
                     <div class="control-group">
                            <label class="control-label">E-mail-Address</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-envelope"></i></span>
        							<asp:TextBox ID="TextBox49" runat="server" class="form-control" placeholder="E-Mail"></asp:TextBox> 
      							</div>
                            </div>			
                     </div>
                     
                     <div class="control-group">
                            <label class="control-label">Message</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-edit"></i></span>
        							<asp:TextBox ID="TextBox50" Rows=3 class="form-control" runat="server" 
                            TextMode="MultiLine" ></asp:TextBox>
      							</div>
                            </div>			
                        </div>
                
        			</div>
                    	

                    
					<div class="row color-div-lodge">
                    
                    <asp:Button ID="Button25" runat="server" Text="Send" 
                                    class="btn btn-info btn-md" onclick="Button25_Click" />
                                    
                    <asp:Button ID="Button26" runat="server" Text="Clear" 
                                    class="btn btn-info btn-md"/>
                    </div>

                     <div class="row color-div-forms">

                        <asp:Label ID="Label7" runat="server" Text=""></asp:Label>

                     </div>
                   
            		
        		

            
            <div class="row">
            	<div class="col-lg-12 col-md-12 col-sm-12">
        			<div class="row color-div-forms">
                    	<h2 class="h2">
    						Comments
                        </h2>
            		</div>
        		</div>
                
                               
                 <div class="col-lg-12 col-md-12 col-sm-12">
        			<div class="row color-div-lodge">
                        <asp:TextBox ID="TextBox13" Rows=3 class="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
            		</div>

                    <div class="row color-div-lodge">

                    <asp:Button ID="Button1" runat="server" Text="Submit Comment" 
                                    class="btn btn-info btn-md" onclick="Button1_Click"/>
                                    
                    <asp:Button ID="Button2" runat="server" Text="Clear" 
                                    class="btn btn-info btn-md" onclick="Button5_Click"/>
                        
                    </div>
                    
                    <div class="row color-div-lodge">

                    
                        
                        <asp:Panel ID="Panel1" runat="server" CssClass="col-lg-12 col-md-12 col-sm-12">
                            <asp:Table ID="Table1" runat="server" CssClass="col-lg-12 col-md-12 col-sm-12 table table-condensed">
                            </asp:Table>
                        </asp:Panel>

                    
                        
                    </div>
                    
        		</div>
                
            </div>
                     
        </div>
        <br />
    </div>
    
    
    
    <div class="row">
    	<div class="col-lg-12 col-md-12 col-sm-12">
        	<div class="row">
            	<div class="col-lg-12 col-md-12 col-sm-12">
        			<div class="row color-div-forms">
                    	<h1 class="h1">
    						Confirmed Requests
                        </h1>
            		</div>
        		</div>
                
                <div class="col-lg-12 col-md-12 col-sm-12">
        			
                    <div class="row color-div-lodge">
                	
                    <asp:GridView ID="GVReqCon" runat="server" AutoGenerateColumns="False" 
                    onrowcommand="GVReqCon_RowCommand">
                    
                    <Columns >
                        <asp:BoundField DataField="Request_Id" HeaderText="Request Id">
                        
                        </asp:BoundField>
                        <asp:BoundField DataField="Guest_name" HeaderText="Guest House">
                        <ControlStyle CssClass="visible-lg visible-md" />
                        <FooterStyle CssClass="visible-lg visible-md" />
                        <HeaderStyle CssClass="visible-lg visible-md" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Requester_Last_Name" HeaderText="Last Name">
                        <ControlStyle CssClass="visible-lg visible-md" />
                        <FooterStyle CssClass="visible-lg visible-md" />
                        <HeaderStyle CssClass="visible-lg visible-md" />
                        <ItemStyle Font-Names="Arial" Font-Size="11pt" CssClass="visible-lg visible-md" />
                        </asp:BoundField>
                         <asp:BoundField DataField="Requester_First_Name" HeaderText="First Name">
                        <ControlStyle CssClass="visible-lg visible-md" />
                        <FooterStyle CssClass="visible-lg visible-md" />
                        <HeaderStyle CssClass="visible-lg visible-md" />
                        </asp:BoundField>

                         <asp:BoundField DataField="Request_Date" HeaderText="Date">
                        <ControlStyle CssClass="visible-lg visible-md" />
                        <FooterStyle CssClass="visible-lg visible-md" />
                        <HeaderStyle CssClass="visible-lg visible-md" />
                        <ItemStyle   CssClass="visible-lg visible-md" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkDet0" runat="server" CausesValidation="false" 
                                    CommandArgument="<%# Container.DataItemIndex %>" CommandName="cmdBind">Edit Details</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                   </asp:GridView>
            		</div>
        		</div>
                
            </div>
            
            
            <div class="row">
            	<div class="col-lg-12 col-md-12 col-sm-12">
        			<div class="row color-div-forms">
                    	<h1>Edit</h1>
            		</div>
        		</div>
                
                <div class="col-lg-12 col-md-12 col-sm-12">
        			<div class="row">
                    	<div class="col-lg-6 col-md-12 col-sm-12 ">
        					<div class="row color-div-lodge">  
                                                                         
                        	
							
                            <div class="control-group">
                            	<label class="control-label">Lodge</label>
                                <div class="controls">
                                <div class="input-group">
                                        <h3><asp:Label ID="Label10" runat="server"></asp:Label></h3>
                                    </div>
                                </div>			
                        	</div>
                            
                        	<div class="control-group">
                            	<label class="control-label">Request_Id</label>
                                <div class="controls">
                                <div class="input-group">
                                        <h3><asp:Label ID="Label11" runat="server"></asp:Label></h3>
                                    </div>
                                </div>			
                        	</div>
            			
                        <div class="control-group">
                            <label class="control-label">First Name</label>
                                <div class="controls">
                                    <div class="input-group">
                                            <span class="input-group-addon"><i class="icon-pencil"></i></span>
                                            <asp:TextBox ID="TextBox14" runat="server" class="form-control" placeholder="First Name"></asp:TextBox>
                                    </div>
                                </div>			
                        </div>
                        
                        <div class="control-group">
                            <label class="control-label">Last Name</label>
                                <div class="controls">
                                    <div class="input-group">
                                            <span class="input-group-addon"><i class="icon-pencil"></i></span>
                                            <asp:TextBox ID="TextBox15" runat="server" class="form-control" 
                                                placeholder="Last Name" ></asp:TextBox>
                                    </div>
                                </div>			
                        </div>
                        	
                        <div class="control-group">
                            <label class="control-label">E-Mail</label>
                            <div class="controls">
                            <div class="input-group">
        							<span class="input-group-addon"><i class="icon-envelope"></i></span>
        							<asp:TextBox ID="TextBox16" runat="server" class="form-control" placeholder="E-mail"></asp:TextBox>
      							</div>
                            </div>			
                        </div>

						<div class="control-group">
							<label class="control-label">Conatct Number</label>
							<div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-phone"></i></span>
        							<asp:TextBox ID="TextBox17" runat="server" class="form-control" placeholder="Contact 01"></asp:TextBox>
      							</div>
                            </div>			
						</div>
            
                        <div class="control-group">
                            <label class="control-label">Mobile Number</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-phone"></i></span>
        							<asp:TextBox ID="TextBox18" runat="server" class="form-control" placeholder="Mobile"></asp:TextBox>
      							</div>
                            </div>			
                        </div>
                        
                        <div class="control-group">
                            <label class="control-label">Fax Number</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-print"></i></span>
        							<asp:TextBox ID="TextBox29" runat="server" class="form-control" placeholder="Fax"></asp:TextBox>
      							</div>
                            </div>			
                        </div>
                        
 						            			
                        
                        <div class="control-group">
                            <label class="control-label">Country</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-print"></i></span>
        							 <asp:DropDownList ID="TextBox19" class="btn btn-default form-control" runat="server">
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
                            
                            
                                          			

            				</div>
        				</div>
                        <div class="col-lg-6 col-md-12 col-sm-12">
        					<div class="row color-div-lodge">
                            
                            <div class="input-group">
        							<span class="input-group-addon"><i class="icon-collapse"></i></span>
        							<asp:DropDownList ID="DropDownList1" class="btn btn-default form-control" runat="server">
                                        <asp:ListItem>With Breakfast</asp:ListItem>
                                        <asp:ListItem>Without Breakfast</asp:ListItem>
                                    </asp:DropDownList>	
      							</div>

                            <div class="control-group">
                            <label class="control-label">From Date</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-calendar"></i></span>
        							<asp:TextBox ID="TextBox30" runat="server" class="form-control" placeholder="From"></asp:TextBox> 
      							</div>
                            </div>			
                        </div>
                        
            
            			<div class="control-group">
                            <label class="control-label">To Date</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-calendar"></i></span>
        							<asp:TextBox ID="TextBox31" runat="server" class="form-control" placeholder="To"></asp:TextBox> 
      							</div>
                            </div>			
                        </div>

                          <div class="control-group">
                            <label class="control-label">Adults</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-collapse"></i></span>                                
                                    <asp:DropDownList ID="TextBox20" class="btn btn-default form-control" runat="server">
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
                            <label class="control-label">Children</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-collapse"></i></span>                                
                                    <asp:DropDownList ID="TextBox21" class="btn btn-default form-control" runat="server">
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
                            <label class="control-label">Request Was Placed On</label>
                            <div class="controls">
                            	<div class="input-group">
        							<asp:Label ID="Label22" runat="server"></asp:Label>
      							</div>
                            </div>			
                        </div>
                        
                        <div class="control-group">
                            <label class="control-label">Amount</label>
                            <div class="controls">
                            	<div class="input-group">
        							
        							<asp:Label ID="Label6" runat="server"></asp:Label>
      							</div>
                            </div>			
                        </div> 
                        
                         <div class="control-group">
                            <label class="control-label">Promotions</label>
                            <div class="controls">
                            	<div class="input-group">
        							<asp:Label ID="Labe17" runat="server" Text=""></asp:Label>
      							</div>
                            </div>			
                        </div>   
                            
                    			 
                            </div>
                        
                            <div class="row color-div-lodge">
                                <table border="0" cellspacing="0" cellpadding="0" class="table table-condensed">
                                    <tr>
                                    <td><asp:Button ID="Button7" runat="server" Text="Edit" 
                                    class="btn btn-info btn-md" onclick="Button7_Click"/>
                                    
                                    <asp:Button ID="Button10" runat="server" Text="Complete Request" 
                                    class="btn btn-info btn-md" onclick="Button10_Click" />
                                    
                                    <asp:Button ID="Button11" runat="server" Text="Cancel Request" 
                                    class="btn btn-info btn-md" onclick="Button11_Click" />
                                    
                                    </td>
                                    
                                    
                                    
                                  </tr>
                               </table>
                              
                            </div>

        				</div>
            		</div>
        		</div>
                
            </div>
            
            
            <div class="row color-div-forms">
                    	<h2 class="h2">Send Mail</h2>
            		</div>
        		
                
                	<div class="row color-div-lodge">
                	<div class="control-group">
                            <label class="control-label">Name</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-edit"></i></span>
        							<asp:TextBox ID="TextBox43" runat="server" class="form-control" placeholder="Name"></asp:TextBox> 
      							</div>
                            </div>			
                     </div>
                     
                     <div class="control-group">
                            <label class="control-label">E-mail-Address</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-envelope"></i></span>
        							<asp:TextBox ID="TextBox44" runat="server" class="form-control" placeholder="E-Mail"></asp:TextBox> 
      							</div>
                            </div>			
                     </div>
                     
                     <div class="control-group">
                            <label class="control-label">Message</label>
                            <div class="controls">
                            	<div class="input-group">
        							<span class="input-group-addon"><i class="icon-edit"></i></span>
        							<asp:TextBox ID="TextBox45" Rows=3 class="form-control" runat="server" 
                            TextMode="MultiLine" ></asp:TextBox>
      							</div>
                            </div>			
                        </div>
                
        			</div>
                    	

                    
					<div class="row color-div-lodge">
                    
                    <asp:Button ID="Button20" runat="server" Text="Send" 
                                    class="btn btn-info btn-md" onclick="Button13_Click1"/>
                                    
                    <asp:Button ID="Button21" runat="server" Text="Clear" 
                                    class="btn btn-info btn-md" onclick="Button5_Click"/>
                    </div>
                   
            		<div class="row color-div-lodge">
                        <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                    </div>
        		

            
            
            <div class="row">
            	<div class="col-lg-12 col-md-12 col-sm-12">
        			<div class="row color-div-forms">
                    	<h2 class="h2">
    						Comments
                        </h2>
            		</div>
        		</div>
                
                               
                 <div class="col-lg-12 col-md-12 col-sm-12">
        			<div class="row color-div-lodge">
                        <asp:TextBox ID="TextBox28" Rows=3 class="form-control" runat="server" 
                            TextMode="MultiLine" ></asp:TextBox>
            		</div>

                    <div class="row color-div-lodge">

                    <asp:Button ID="Button13" runat="server" Text="Submit Comment" 
                                    class="btn btn-info btn-md" onclick="Button13_Click1"/>
                                    
                    <asp:Button ID="Button14" runat="server" Text="Clear" 
                                    class="btn btn-info btn-md" onclick="Button5_Click"/>
                        
                    </div>
                    
                    <div class="row color-div-lodge">

                    
                        
                        <asp:Panel ID="Panel2" runat="server" CssClass="col-lg-12 col-md-12 col-sm-12">
                            <asp:Table ID="Table2" runat="server" CssClass="col-lg-12 col-md-12 col-sm-12 table table-condensed">
                            </asp:Table>
                        </asp:Panel>

                    
                        
                    </div>
                    
        		</div>
                
            </div>    
        </div>
        <br />
    </div>
    

</div>



</form>

<div class="col-lg-12 col-md-12 col-sm-12 footer-back-color footer-height">
     <p class="text-center">All rights reserved www.snsholidayhomes.com</p>
</div>

	<script src="Index/Js/jquery-1.4.3.min.js"></script>
	<script src="dist/js/jquery.js"></script>
	<script src="dist/js/bootstrap.js"></script>
  	<script src="dist/js/holder.js"></script>
  	

  
  	<script src="Index/Js/jquery-ui-1.9.0.custom.min.js"></script>
  	<script src="dist/js/jquery-ui.js"></script>
    
	
	

	<script>


	    $(function () {
	        $("#TextBox8").datepicker();
	    });

	    $(function () {
	        $("#TextBox9").datepicker();
	    });

	    $(function () {
	        $("#TextBox30").datepicker();
	    });

	    $(function () {
	        $("#TextBox31").datepicker();
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

	    $("#Button4").click(function () {

	        var t1 = $("#TextBox1").val();
	        var t2 = $("#TextBox2").val();
	        var t3 = $("#TextBox3").val();
	        var t4 = $("#TextBox4").val();
	        var t5 = $("#TextBox5").val();
	        var t6 = $("#TextBox6").val();
	        var t7 = $("#TextBox7").val();
	        var t8 = $("#TextBox8").val();
	        var t9 = $("#TextBox9").val();
	        var t10 = $("#TextBox10").val();
	        var t11 = $("#TextBox11").val();


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
	            alert("Country Name Field Can Not be Empty");
	            return false;
	        }

	        if (t8 == "") {
	            alert("From Date Field Can Not be Empty");
	            return false;
	        }

	        if (t9 == "") {
	            alert("To Date Field Can Not be Empty");
	            return false;
	        }

	        if (t10 == "") {
	            alert("Adults Field Can Not be Empty");
	            return false;
	        }

	        if (t11 == "") {
	            alert("Children Field Can Not be Empty");
	            return false;
	        }

	        if (isNaN(t11)) {
	            alert("Value Has to be Numeric");
	            return false;
	        }



	    });

        $("#Button20").click(function ()
            
            var t43 = $("#TextBox43").val();
	        var t44 = $("#TextBox44").val();
	        var t45 = $("#TextBox45").val();

            if (t43 == "") {
	            alert("Name Field Can Not be Empty");
	            return false;
	        }

	        if (t44 == "") {
	            alert("E-mail Field Can Not be Empty");
	            return false;
	        }

	        if (t45 == "") {
	            alert("Message Field Can Not be Empty");
	            return false;
	        }

        });


        $("#Button25").click(function ()
            
            var t48 = $("#TextBox48").val();
	        var t49 = $("#TextBox49").val();
	        var t50 = $("#TextBox50").val();

            if (t43 == "") {
	            alert("Name Field Can Not be Empty");
	            return false;
	        }

	        if (t44 == "") {
	            alert("E-mail Field Can Not be Empty");
	            return false;
	        }

	        if (t45 == "") {
	            alert("Message Field Can Not be Empty");
	            return false;
	        }

        });

			
  	</script>

</body>
</html>
