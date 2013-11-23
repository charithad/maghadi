using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Configuration;
using System.Data;
using System.Xml.Linq;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Mail;

using System.Net;
using System.Text;
using MagadheeDEC.GuestHouseDec;
using MgadheeService.GuestHouseService;

public partial class Index : System.Web.UI.Page
{
    DECVariables.ClsAddGuestHouse DecGuestVar = new DECVariables.ClsAddGuestHouse();
    DECVariables.ClsRequest DecReq = new DECVariables.ClsRequest();
    DECVariables.ClsMail DecMailVar = new DECVariables.ClsMail();
    SERRequests SERRec = new SERRequests();
    SERAddAttractions SERAtt = new SERAddAttractions();

    SERAddGuestHouse SERGuest = new SERAddGuestHouse();

    SERAddNews NewsHome = new SERAddNews();

    string strname;
    string stremail;

    protected void Page_Load(object sender, System.EventArgs e)
    {
        var h1 = new HtmlGenericControl("h1");
        var p = new HtmlGenericControl("p");

        double counts = 0;
        double countsNews = 0;
        try
        {

            DataTable PL_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
            if (PL_Ref_Guest_SelectAll.Rows.Count > 0)
            {
                foreach (DataRow DR_Ref_Guest_SelectAll in PL_Ref_Guest_SelectAll.Rows)
                {

                    System.Web.UI.WebControls.Image I1 = new System.Web.UI.WebControls.Image();


                    System.Web.UI.WebControls.HyperLink Hype1 = new System.Web.UI.WebControls.HyperLink();
                    System.Web.UI.WebControls.HyperLink Hype2 = new System.Web.UI.WebControls.HyperLink();
                    System.Web.UI.WebControls.HyperLink Hype3 = new System.Web.UI.WebControls.HyperLink();


                    HtmlGenericControl DivImg = new HtmlGenericControl("div");
                    HtmlGenericControl DivRow = new HtmlGenericControl("div");
                    HtmlGenericControl DivSpace = new HtmlGenericControl("div");
                    HtmlGenericControl DivText = new HtmlGenericControl("div");
                    HtmlGenericControl Divbut = new HtmlGenericControl("div");
                    HtmlGenericControl DivInnerMain = new HtmlGenericControl("div");
                    HtmlGenericControl h1s = new HtmlGenericControl("h2");




                    I1.ImageUrl = "~/Images/Guest_Img/" + DR_Ref_Guest_SelectAll.ItemArray.GetValue(0).ToString().Trim() + "/1.JPG";
                    I1.CssClass = "col-lg-12 col-md-6 col-sm-6 img-responsive img-rounded img-polo";

                    DivRow.Attributes["class"] = "row";

                    DivImg.ID = "DivImage";
                    DivImg.Attributes["class"] = "col-lg-10 col-md-6 col-sm-12";

                    DivSpace.Attributes["class"] = "col-lg-12 col-md-6 col-sm-12 h20";

                    Divbut.Attributes["class"] = "col-lg-12 col-md-12 col-sm-12";

                    DivText.ID = "DivTextId";
                    DivText.Attributes["class"] = "col-lg-12 col-md-12 col-sm-12";

                    DivInnerMain.ID = DR_Ref_Guest_SelectAll.ItemArray.GetValue(0).ToString();
                    DivInnerMain.Attributes["class"] = "col-lg-12 col-md-12 col-sm-12 row";

                    Hype1.CssClass = "color-div-request ";
                    Hype1.Text = "<h3>" + DR_Ref_Guest_SelectAll.ItemArray.GetValue(6).ToString() + "</h3>";
                    Hype1.NavigateUrl = "GuestHouse.aspx?Obj=" + DivInnerMain.ID.ToString();
                    Hype2.NavigateUrl = "GuestHouse.aspx?Obj=" + DivInnerMain.ID.ToString();
                    Hype2.CssClass = "";

                    Hype3.NavigateUrl = "GuestHouse.aspx?Obj=" + DivInnerMain.ID.ToString();
                    Hype3.CssClass = "btn btn-danger btn-lg";
                    Hype3.Text = "Make a Request";

                    Hype2.Controls.Add(I1);

                    DivImg.Controls.Add(Hype2);
                    DivText.Controls.Add(Hype1);
                    Divbut.Controls.Add(Hype3);

                    DivRow.Controls.Add(DivText);
                    DivRow.Controls.Add(DivImg);
                    DivRow.Controls.Add(DivSpace);
                    DivRow.Controls.Add(Divbut);



                    DivInnerMain.Controls.Add(DivRow);



                    Plc_Lodge.Controls.Add(DivInnerMain);


                }



            }


            if (PL_Ref_Guest_SelectAll.Rows.Count > 0)
            {
                foreach (DataRow DR_Ref_Guest_SelectAll in PL_Ref_Guest_SelectAll.Rows)
                {

                    System.Web.UI.WebControls.Image Iguest = new System.Web.UI.WebControls.Image();
                    System.Web.UI.WebControls.HyperLink Hype1 = new System.Web.UI.WebControls.HyperLink();

                    HtmlGenericControl DivGuestRow = new HtmlGenericControl("div");
                    HtmlGenericControl DivGuest = new HtmlGenericControl("div");
                    HtmlGenericControl DivGuestImg = new HtmlGenericControl("div");
                    HtmlGenericControl DivGuestHead = new HtmlGenericControl("div");
                    HtmlGenericControl DivGuestWith = new HtmlGenericControl("div");
                    HtmlGenericControl DivGuestWithout = new HtmlGenericControl("div");
                    HtmlGenericControl DivGuestNoRooms = new HtmlGenericControl("div");
                    HtmlGenericControl DivGuestText = new HtmlGenericControl("div");
                    HtmlGenericControl DivGuestreq = new HtmlGenericControl("div");

                    HtmlGenericControl hguest = new HtmlGenericControl("h2");
                    HtmlGenericControl hgh3 = new HtmlGenericControl("h3");
                    HtmlGenericControl pguest = new HtmlGenericControl("p");

                    Label lblHead = new Label();
                    Label lblwith = new Label();
                    Label lblwithout = new Label();
                    Label lblrooms = new Label();



                    Iguest.ImageUrl = "~/Images/Guest_Img/" + DR_Ref_Guest_SelectAll.ItemArray.GetValue(0).ToString().Trim() + "/1.JPG";
                    Iguest.CssClass = "col-lg-12 col-md-4 col-sm-6 img-responsive img-polo-2";

                    lblHead.Text = "<br/>" + DR_Ref_Guest_SelectAll.ItemArray.GetValue(6).ToString();
                    hguest.Controls.Add(lblHead);

                    lblwith.Text = "<h3><b>Price With Breakfast</b> Rs." + DR_Ref_Guest_SelectAll.ItemArray.GetValue(10).ToString().Trim() + "/=</h3>";
                    lblwithout.Text = "<h3><b>Price Without Breakfast</b> Rs." + DR_Ref_Guest_SelectAll.ItemArray.GetValue(2).ToString().Trim() + "/=</h3>";
                    lblrooms.Text = "<h3><b>Rooms Available</b> " + DR_Ref_Guest_SelectAll.ItemArray.GetValue(4).ToString().Trim() + "</h3>";

                    Hype1.CssClass = "btn-danger btn-sm";
                    Hype1.NavigateUrl = "GuestHouse.aspx?Obj=" + DR_Ref_Guest_SelectAll.ItemArray.GetValue(0).ToString().Trim();
                    Hype1.Text = "Make Request";

                    DivGuest.Attributes["class"] = "item col-lg-12 col-md-12 col-sm-12 item";
                    DivGuestImg.Attributes["class"] = "item col-lg-12 col-md-12 col-sm-12";
                    DivGuestHead.Attributes["class"] = "item col-lg-12 col-md-12 col-sm-12";
                    DivGuestWith.Attributes["class"] = "item col-lg-12 col-md-12 col-sm-12";
                    DivGuestWithout.Attributes["class"] = "item col-lg-12 col-md-12 col-sm-12";
                    DivGuestNoRooms.Attributes["class"] = "item col-lg-12 col-md-12 col-sm-12";
                    DivGuestText.Attributes["class"] = "item col-lg-12 col-md-12 col-sm-12";
                    DivGuestreq.Attributes["class"] = "item col-lg-6 col-md-6 col-sm-12";
                    DivGuestRow.Attributes["class"] = "row";

                    DivGuestreq.Controls.Add(Hype1);
                    DivGuestHead.Controls.Add(hguest);
                    DivGuestImg.Controls.Add(Iguest);
                    DivGuestNoRooms.Controls.Add(lblrooms);
                    DivGuestWith.Controls.Add(lblwith);
                    DivGuestWithout.Controls.Add(lblwithout);


                    DivGuestRow.Controls.Add(DivGuestImg);
                    DivGuestRow.Controls.Add(DivGuestHead);
                    DivGuestRow.Controls.Add(DivGuestWith);
                    DivGuestRow.Controls.Add(DivGuestWithout);
                    DivGuestRow.Controls.Add(DivGuestNoRooms);
                    DivGuestRow.Controls.Add(DivGuestText);
                    DivGuestRow.Controls.Add(DivGuestreq);

                    DivGuest.Controls.Add(DivGuestRow);
                    Plc_Guest.Controls.Add(DivGuest);

                }


            }
            DecGuestVar.Guest_Code = Request.QueryString["Obj"];



            DataTable PL_Joint_Ref_Guesthouse_Wise_Attraction_Select = SERAtt.SERV_Ref_Attraction_SelectAll();
            if (PL_Joint_Ref_Guesthouse_Wise_Attraction_Select.Rows.Count > 0)
            {
                foreach (DataRow DR_Joint_Ref_Guesthouse_Wise_Attraction_Select in PL_Joint_Ref_Guesthouse_Wise_Attraction_Select.Rows)
                {
                    HtmlGenericControl DivItems = new HtmlGenericControl("div");
                    System.Web.UI.WebControls.Image IAtract = new System.Web.UI.WebControls.Image();
                    var pattract = new HtmlGenericControl("p");
                    var h1at = new HtmlGenericControl("h1");

                    IAtract.ImageUrl = "~/Images/Attr_Img/" + DR_Joint_Ref_Guesthouse_Wise_Attraction_Select.ItemArray.GetValue(0).ToString().Trim() + "/1.JPG";
                    IAtract.CssClass = "col-lg-4 col-md-6 col-sm-6 img-polo img-responsive img-rounded m10";
                    h1at.Attributes["class"] = "h2 text-left";
                    h1at.InnerHtml = DR_Joint_Ref_Guesthouse_Wise_Attraction_Select.ItemArray.GetValue(2).ToString();
                    pattract.InnerHtml = DR_Joint_Ref_Guesthouse_Wise_Attraction_Select.ItemArray.GetValue(3).ToString();

                    if (countsNews == 0)
                    {
                        DivItems.ID = "DivAttractionItem";
                        DivItems.Attributes["class"] = "col-lg-12 col-md-12 col-sm-12 item active";
                    }
                    else
                    {
                        DivItems.ID = "DivAttractionItem";
                        DivItems.Attributes["class"] = "col-lg-12 col-md-12 col-sm-12 item";
                    }

                    DivItems.Controls.Add(IAtract);
                    DivItems.Controls.Add(h1at);
                    DivItems.Controls.Add(pattract);

                    Plc_Attractions.Controls.Add(DivItems);

                    countsNews++;
                }
            }


            DataTable PL_Ref_News_SelectAll = NewsHome.SERV_Ref_News_SelectAll();
            if (PL_Ref_News_SelectAll.Rows.Count > 0)
            {
                foreach (DataRow DR_Ref_News_SelectAll in PL_Ref_News_SelectAll.Rows)
                {
                    HtmlGenericControl DivItemsNews = new HtmlGenericControl("div");
                    System.Web.UI.WebControls.Image INews = new System.Web.UI.WebControls.Image();
                    var pNews = new HtmlGenericControl("p");
                    var h1News = new HtmlGenericControl("h1");

                    INews.ImageUrl = "~/Images/News_Img/" + DR_Ref_News_SelectAll.ItemArray.GetValue(0).ToString().Trim() + "/1.JPG";
                    INews.CssClass = "col-lg-4 col-md-6 col-sm-6 img-polo img-responsive img-rounded m10";
                    h1News.Attributes["class"] = "h2 text-left";
                    h1News.InnerHtml = DR_Ref_News_SelectAll.ItemArray.GetValue(1).ToString();
                    pNews.InnerHtml = DR_Ref_News_SelectAll.ItemArray.GetValue(2).ToString();

                    if (counts == 0)
                    {
                        DivItemsNews.ID = "DivNewsItem";
                        DivItemsNews.Attributes["class"] = "col-lg-12 col-md-12 col-sm-12 item active";
                    }
                    else
                    {
                        DivItemsNews.ID = "DivNewsItem";
                        DivItemsNews.Attributes["class"] = "col-lg-12 col-md-12 col-sm-12 item";
                    }

                    DivItemsNews.Controls.Add(INews);
                    DivItemsNews.Controls.Add(h1News);
                    DivItemsNews.Controls.Add(pNews);

                    Plc_News.Controls.Add(DivItemsNews);

                    counts++;
                }
            }

        }
        catch
        {

        }


    }
    protected void BtnSub_Click(object sender, System.EventArgs e)
    {
        try
        {
            
            DecMailVar.toName = TextBox1.Text;
            DecMailVar.fromAddress = "snsholidayhomes@gmail.com";
            DecMailVar.fromName = "SNS Holiday Homes";
            
            DecMailVar.msgSubject = "Message from Mr." + strname.ToString();
            DecMailVar.msgBody = "Name :" + DecMailVar.toName + "<BR><BR> E-Mail :" + DecMailVar.fromAddress + "<BR><BR> " + TextBox13.Text.ToString();

            SERAtt.SendMailMessage(DecMailVar);

            /*MailMessage mailMessage = new MailMessage(new MailAddress("snsholidayhomes@gmail.com")
                                               , new MailAddress("snsholidayhomes@gmail.com"));
            mailMessage.Subject = "Message from Mr." + DecMailVar.toName.ToString();
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "Name :" + DecMailVar.toName + "<BR><BR> E-Mail :" + DecMailVar.fromAddress + "<BR><BR> " + TextBox13.Text.ToString();

            System.Net.NetworkCredential networkCredentials = new
            System.Net.NetworkCredential("snsholidayhomes@gmail.com", "snsreq123");

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = networkCredentials;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.Send(mailMessage);*/
            
        }
        catch
        {

        }

    }

}