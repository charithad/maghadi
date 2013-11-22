<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNews.aspx.cs" Inherits="AddNews" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1"/>
<meta name="keywords" content="security companies in sri lanka"/>
<meta name="keywords" content="provincial and city security service"/>
<meta name="generator" content="UltraEdit-32"/>
<meta name="author" content="charitha dias"/>
<meta name="description" content="sri lankan security ferms"/>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>ADD NEWS</title>

<link rel="stylesheet" type="text/css" href="css/AddNewsLay.css"/>
<link rel="stylesheet" type="text/css" href="Common/css/Widget.css" />
<link rel="stylesheet" type="text/css" href="Common/css/Appearance.css" />
<link rel="stylesheet" type="text/css" href="Index/css/style.css" />

<link rel="stylesheet" type="text/css" href="Index/css/flexcrollstyles.css" />
<link rel="stylesheet" type="text/css" href="Index/css/tutorsty.css" />

<script type='text/javascript' src="Index/Js/jquery-1.4.3.min.js"></script>
<script type='text/javascript' src="Index/Js/infinite-rotator.js"></script>
<script type='text/javascript' src="Index/Js/flexcroll.js"></script>
<script type="text/javascript" src="Index/Js/jquery.js"></script>

<script>
    $(document).ready(function () {

        //rotation speed and timer
        var speed = 5000;
        var run = setInterval('rotate()', speed);

        //grab the width and calculate left value
        var item_width = $('#slides li').outerWidth();
        var left_value = item_width * (-1);

        //move the last item before first item, just in case user click prev button
        $('#slides li:first').before($('#slides li:last'));

        //set the default item to the correct position 
        $('#slides ul').css({ 'left': left_value });

        //if user clicked on prev button
        $('#prev').click(function () {

            //get the right position            
            var left_indent = parseInt($('#slides ul').css('left')) + item_width;

            //slide the item            
            $('#slides ul:not(:animated)').animate({ 'left': left_indent }, 200, function () {

                //move the last item and put it as first item            	
                $('#slides li:first').before($('#slides li:last'));

                //set the default item to correct position
                $('#slides ul').css({ 'left': left_value });

            });

            //cancel the link behavior            
            return false;

        });


        //if user clicked on next button
        $('#next').click(function () {

            //get the right position
            var left_indent = parseInt($('#slides ul').css('left')) - item_width;

            //slide the item
            $('#slides ul:not(:animated)').animate({ 'left': left_indent }, 200, function () {

                //move the first item and put it as last item
                $('#slides li:last').after($('#slides li:first'));

                //set the default item to correct position
                $('#slides ul').css({ 'left': left_value });

            });

            //cancel the link behavior
            return false;

        });

        //if mouse hover, pause the auto rotation, otherwise rotate it
        $('#slides').hover(

		function () {
		    clearInterval(run);
		},
		function () {
		    run = setInterval('rotate()', speed);
		}
	);

    });

    //a simple function to click next link
    //a timer will call this function, and the rotation will begin :)  
    function rotate() {
        $('#next').click();
    }



    

</script>
	
<style>

#ftu
{
	position:absolute;
	top:2103px;
	left:486px;
	width: 461px;
	height: 255px;
}

#carousel {
	width:255px;
	height:290px;	
	margin:0 auto;
	overflow:hidden;
}

#slides {
	overflow:hidden;
	/* fix ie overflow issue */
	position:absolute;
	width:250px;
	height:250px;
	top:10px;
	left:10px;
	z-index:1;
}

/* remove the list styles, width : item width * total items */	
#slides ul {
	position:absolute;
	left:0;
	top:0;
	list-style:none;
	margin:0;
	padding:0;	
	width:750px;			
}

/* width of the item, in this case I put 250x250x gif */
#slides li {
	width:250px;
	height:250px;	
	float:left;
}

#slides li img {
	padding:4px;
}

/* Styling for prev and next buttons */
#buttons {
	padding:0 0 5px 0;	
	float:right;
}

#buttons a {
	display:block; 
	width:31px; 
	height:32px;
	text-indent:-999em;
	float:left;
	outline:0;
}

a#prev {
	background:url(arrow.gif) 0 -31px no-repeat; 
}

a#prev:hover {
	background:url(arrow.gif) 0 0 no-repeat;
}

a#next {
	background:url(arrow.gif) -32px -31px no-repeat; 
}

a#next:hover {
	background:url(arrow.gif) -32px 0 no-repeat;
}

.clear {clear:both}

    .style2
    {
        height: 166px;
    }

    .style3
    {
        width: 124px;
    }

    </style>




</head>

<body>

    <form id="form1" runat="server">

<div class="Container">
<div class="head">
<div class="banBig">
      <div class="links01">
        <table width="310" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="304"><a class="fooc" href="AddHomeContent.aspx">Add home content</a></td>
          </tr>
          <tr>
            <td><a class="fooc" href="AddClientTestimonial.aspx">Add client testimonials</a></td>
          </tr>
          <tr>
            <td><a class="fooc" href="AddAttractions.aspx">Add Attractions</a></td>
          </tr>
          <tr>
            <td><a class="fooc" href="AddGuestHouse.aspx">Add Guest House</a></td>
          </tr>
          <tr>
            <td><a class="fooc" href="AddNews.aspx">Add News</a></td>
          </tr>
          <tr>
            <td><a class="fooc" href="AddPromotions.aspx">Add Promotions</a></td>
          </tr>
          <tr>
            <td><a class="fooc" href="AddLocations.aspx">Add Locations</a></td>
          </tr>
          <tr>
            <td><a class="fooc" href="Requests.aspx">Requests</a></td>
          </tr>
        </table>
      </div>
</div>
  <div class="content">
  
  <div class="AddProj" id="AddProjId">
    <table width="449" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td><h2>edit news</h2></td>
      </tr>
      <tr>
        <td><p>News Id :&nbsp; 
            <asp:Label ID="Label1" runat="server"></asp:Label>
            </p></td>
      </tr>
      <tr>
        <td><p>News</p></td>
      </tr>
      <tr>
        <td>
            <asp:Panel ID="Panel4" runat="server" Height="138px" 
                Width="459px" ScrollBars="Vertical" >
                <asp:GridView ID="GVNews" runat="server" 
    AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" 
    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" 
    Height="16px" onrowcommand="GVNews_RowCommand" Width="440px" 
                    EnableModelValidation="True" >
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:BoundField DataField="News_Id" 
            HeaderText="ID">
                        <HeaderStyle BackColor="#62A8DB" BorderStyle="Solid" BorderWidth="1px" 
            Font-Names="Tahoma" Font-Size="12pt" ForeColor="#000066" Height="25px" 
            HorizontalAlign="Left" VerticalAlign="Middle" Width="75px" />
                        <ItemStyle Font-Names="Arial" Font-Size="11pt" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Heading" HeaderText="News Heading">
                        <HeaderStyle BackColor="#62A8DB" BorderStyle="Solid" BorderWidth="1px" 
            Font-Bold="True" Font-Names="Tahoma" Font-Size="12pt" ForeColor="#00008F" 
            HorizontalAlign="Left" VerticalAlign="Middle" Width="150px" />
                        <ItemStyle Font-Names="Arial" Font-Size="11pt" />
                        </asp:BoundField>
                        <asp:BoundField DataField="News_Date" HeaderText="Date">
                        <HeaderStyle BackColor="#62A8DB" Font-Names="Tahoma" Font-Size="12pt" 
                            ForeColor="#000066" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkDet0" runat="server" 
                    CausesValidation="false" CommandArgument="<%# Container.DataItemIndex %>" 
                    CommandName="cmdBind">Edit Details</asp:LinkButton>
                            </ItemTemplate>
                            <HeaderStyle BackColor="#62A8DB" BorderStyle="Solid" 
                BorderWidth="1px" Font-Names="Tahoma" Font-Size="12pt" ForeColor="#00007B" />
                            <ItemStyle Font-Names="Arial" Font-Size="11pt" />
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" 
        ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" 
        HorizontalAlign="Right" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" 
        ForeColor="#F7F7F7" />
                </asp:GridView></asp:Panel>
        </td>
      </tr>
      <tr>
        <td><p>News Heading</p></td>
      </tr>
      <tr>
        <td><p><asp:TextBox ID="TextBox5" runat="server" Width="420px"></asp:TextBox></p></td>
      </tr>
      <tr>
        <td><p>News Body</p></td>
      </tr>
      <tr>
        <td><p>
          <asp:TextBox ID="TextBox4" runat="server" Height="65px" TextMode="MultiLine" 
                Width="420px"></asp:TextBox>
        </p></td>
      </tr>
      <tr>
        <td><p>Date Updated</p></td>
      </tr>
      <tr>
        <td>
            <asp:Calendar ID="Calendar2" runat="server" Height="96px" 
                onselectionchanged="Calendar2_SelectionChanged"></asp:Calendar>
        </td>
      </tr>
      <tr>
        <td><p>Upload a pic 350X300</p></td>
      </tr>
      <tr>
        <td><p>
          <asp:FileUpload ID="FileUpload2" runat="server" />
        </p></td>
      </tr>
      <tr>
        <td>
        <div id="butEditEdit">
            <asp:ImageButton ID="ImageButton4" runat="server" 
                ImageUrl="~/Common/Images/delete.png" onclick="ImageButton4_Click"/></div>
            
            
          </td>
      </tr>
      <tr>
        <td >
            <p><asp:Label ID="Label3" runat="server"></asp:Label></p></td>
      </tr>
      <tr>
        <td>
        <div id="butSubEdit">
            <asp:ImageButton ID="ImageButton2" runat="server" 
                ImageUrl="~/Common/Images/edit.png" onclick="ImageButton2_Click" 
                Width="100px"/></div>

          </td>
      </tr>
    </table>
  </div>
  
  <div class="EditProj" id="EditProjId">
    <table width="449" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td><h2>Add news</h2></td>
      </tr>
      <tr>
        <td><p>News Heading
            </p></td>
      </tr>
      <tr>
        <td>
            <p><asp:TextBox ID="TextBox1" runat="server" Width="420px"></asp:TextBox></p>
          </td>
      </tr>
      <tr>
        <td><p>News Body</p></td>
      </tr>
      <tr>
        <td>
            <p><asp:TextBox ID="TextBox2" runat="server" Height="175px" TextMode="MultiLine" 
                Width="420px"></asp:TextBox></p>
          </td>
      </tr>
      <tr>
        <td><p>Date Updated</p></td>
      </tr>
      <tr>
        <td>
          <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </td>
      </tr>
      <tr>
        <td><p>Upload a pic 350X300</p></td>
      </tr>
      <tr>
        <td>
            <p><asp:FileUpload ID="FileUpload1" runat="server" /></p>
          </td>
      </tr>
      
      <tr>
        <td >
        <div id="butSub"> 
            <asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="~/Common/Images/submit.png" onclick="ImageButton1_Click"/>
            </div>
          </td>
      </tr>
      <tr>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td>
            <p><asp:Label ID="Label2" runat="server"></asp:Label></p>
          </td>
      </tr>
    </table>
  </div>

    
    
    
    </div>
</div>
    
    
</div>

    </form>
</body>
</html>
