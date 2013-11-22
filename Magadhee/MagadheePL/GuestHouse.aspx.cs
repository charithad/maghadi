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


public partial class GuestHouse : System.Web.UI.Page
{
    DECVariables.ClsAddGuestHouse DecGuestVar = new DECVariables.ClsAddGuestHouse();
    DECVariables.ClsRequest DecReq = new DECVariables.ClsRequest();
    SERRequests SERRec = new SERRequests();
    SERAddAttractions SERAtt = new SERAddAttractions();

    SERAddGuestHouse SERGuest = new SERAddGuestHouse();

    SERAddNews NewsHome = new SERAddNews();

    protected void Page_Load(object sender, System.EventArgs e)
    {
        try
        {
            if (Request.QueryString["Obj"] == null)
            {
                Response.Redirect("Index.aspx");
            }
            var h1 = new HtmlGenericControl("h1");
            var p = new HtmlGenericControl("p");

            double counts = 0;
            double countsNews = 0;


            DataTable PL_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
            if (PL_Ref_Guest_SelectAll.Rows.Count > 0)
            {
                foreach (DataRow DR_Ref_Guest_SelectAll in PL_Ref_Guest_SelectAll.Rows)
                {

                    System.Web.UI.WebControls.Image I1 = new System.Web.UI.WebControls.Image();

                    System.Web.UI.WebControls.HyperLink Hype1 = new System.Web.UI.WebControls.HyperLink();
                    System.Web.UI.WebControls.HyperLink Hype2 = new System.Web.UI.WebControls.HyperLink();


                    HtmlGenericControl DivImg = new HtmlGenericControl("div");
                    HtmlGenericControl DivRow = new HtmlGenericControl("div");
                    HtmlGenericControl DivText = new HtmlGenericControl("div");
                    HtmlGenericControl DivInnerMain = new HtmlGenericControl("div");

                    I1.ImageUrl = "~/Images/Guest_Img/" + DR_Ref_Guest_SelectAll.ItemArray.GetValue(0).ToString().Trim() + "/1.JPG";
                    I1.CssClass = "col-lg-12 col-md-12 col-sm-12 img-responsive img-rounded img-polo";

                    DivRow.ID = "DivRow";
                    DivRow.Attributes["class"] = "row";

                    DivImg.ID = "DivImage";
                    DivImg.Attributes["class"] = "col-lg-5 col-md-5 col-sm-12";

                    DivText.ID = "DivTextId";
                    DivText.Attributes["class"] = "col-lg-6 col-md-6 col-sm-12";

                    DivInnerMain.ID = DR_Ref_Guest_SelectAll.ItemArray.GetValue(0).ToString();
                    DivInnerMain.Attributes["class"] = "col-lg-12 col-md-12 col-sm-12 row m10";

                    Hype1.CssClass = "text-info";
                    Hype1.Text = DR_Ref_Guest_SelectAll.ItemArray.GetValue(6).ToString();
                    Hype1.NavigateUrl = "GuestHouse.aspx?Obj=" + DivInnerMain.ID.ToString();
                    Hype2.NavigateUrl = "GuestHouse.aspx?Obj=" + DivInnerMain.ID.ToString();
                    Hype2.CssClass = "";



                    Hype2.Controls.Add(I1);

                    DivImg.Controls.Add(Hype2);
                    DivText.Controls.Add(Hype1);

                    DivRow.Controls.Add(DivImg);
                    DivRow.Controls.Add(DivText);


                    DivInnerMain.Controls.Add(DivRow);



                    Plc_Lodge.Controls.Add(DivInnerMain);



                }



            }



            if (Request.QueryString["Obj"] != null)
            {
                DecGuestVar.Guest_Code = Request.QueryString["Obj"];

                DataTable PL_Ref_Guest_Selected = SERGuest.SERV_Ref_Guest_Selected(DecGuestVar);

                if (PL_Ref_Guest_Selected.Rows.Count > 0)
                {
                    foreach (DataRow DR_Ref_Guest_Selected in PL_Ref_Guest_Selected.Rows)
                    {

                        lbl_head.Text = DR_Ref_Guest_Selected.ItemArray.GetValue(6).ToString();
                        lbl_desc.Text = DR_Ref_Guest_Selected.ItemArray.GetValue(1).ToString();
                        Label1.Text = DR_Ref_Guest_Selected.ItemArray.GetValue(2).ToString();
                        Label2.Text = DR_Ref_Guest_Selected.ItemArray.GetValue(10).ToString();
                        Label3.Text = DR_Ref_Guest_Selected.ItemArray.GetValue(4).ToString();
                        Label4.Text = DR_Ref_Guest_Selected.ItemArray.GetValue(14).ToString();
                        Label5.Text = DR_Ref_Guest_Selected.ItemArray.GetValue(11).ToString();
                    }
                }
                HtmlGenericControl DivItem1 = new HtmlGenericControl("div");
                HtmlGenericControl DivItem2 = new HtmlGenericControl("div");
                HtmlGenericControl DivItem3 = new HtmlGenericControl("div");

                DivItem1.Attributes["class"] = "item active";
                DivItem2.Attributes["class"] = "item";
                DivItem3.Attributes["class"] = "item";

                System.Web.UI.WebControls.Image I1 = new System.Web.UI.WebControls.Image();
                System.Web.UI.WebControls.Image I2 = new System.Web.UI.WebControls.Image();
                System.Web.UI.WebControls.Image I3 = new System.Web.UI.WebControls.Image();

                I1.ImageUrl = "~/Images/Guest_Img/" + DecGuestVar.Guest_Code + "/1.JPG";
                I2.ImageUrl = "~/Images/Guest_Img/" + DecGuestVar.Guest_Code + "/2.JPG";
                I3.ImageUrl = "~/Images/Guest_Img/" + DecGuestVar.Guest_Code + "/3.JPG";

                DivItem1.Controls.Add(I1);
                DivItem2.Controls.Add(I2);
                DivItem3.Controls.Add(I3);

                Plc_items.Controls.Add(DivItem1);
                Plc_items.Controls.Add(DivItem2);
                Plc_items.Controls.Add(DivItem3);

                DataTable PL_Joint_Ref_Guesthouse_Wise_Promotion_Select = SERGuest.SERV_Joint_Ref_Guesthouse_Wise_Promotion_Select(DecGuestVar);
                if (PL_Joint_Ref_Guesthouse_Wise_Promotion_Select.Rows.Count > 0)
                {
                    foreach (DataRow DR_Joint_Ref_Guesthouse_Wise_Promotion_Select in PL_Joint_Ref_Guesthouse_Wise_Promotion_Select.Rows)
                    {
                        System.Web.UI.WebControls.Image IPromo = new System.Web.UI.WebControls.Image();
                        IPromo.ImageUrl = "~/Images/Promo_Image/" + DR_Joint_Ref_Guesthouse_Wise_Promotion_Select.ItemArray.GetValue(0).ToString().Trim() + "/1.JPG";
                        IPromo.CssClass = "col-lg-12 col-md-12 col-sm-12 img-responsive img-rounded img-polo";

                        PlcPromo.Controls.Add(IPromo);
                    }
                }
                else
                {
                    promo.Visible = false;
                }


                DataTable PL_Joint_Ref_Guesthouse_Wise_Attraction_Select = SERGuest.SERV_Joint_Ref_Guesthouse_Wise_Attraction_Select(DecGuestVar);
                if (PL_Joint_Ref_Guesthouse_Wise_Attraction_Select.Rows.Count > 0)
                {
                    foreach (DataRow DR_Joint_Ref_Guesthouse_Wise_Attraction_Select in PL_Joint_Ref_Guesthouse_Wise_Attraction_Select.Rows)
                    {
                        HtmlGenericControl DivItems = new HtmlGenericControl("div");
                        System.Web.UI.WebControls.Image IAtract = new System.Web.UI.WebControls.Image();
                        var pattract = new HtmlGenericControl("p");
                        var h1at = new HtmlGenericControl("h1");

                        IAtract.ImageUrl = "~/Images/Attr_Img/" + DR_Joint_Ref_Guesthouse_Wise_Attraction_Select.ItemArray.GetValue(0).ToString().Trim() + "/1.JPG";
                        IAtract.CssClass = "col-lg-4 col-md-6 col-sm-12 img-polo img-responsive img-rounded m10";
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
                        INews.CssClass = "col-lg-4 col-md-6 col-sm-12 img-polo img-responsive img-rounded m10";
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
        }
        catch
        {
        }

    }
    protected void BtnReq_Click(object sender, System.EventArgs e)
    {
        try
        {
            string strFname;
            string strLname;
            string strPhoneNumber;
            string strArivalDate;
            string strLeaveDate;
            string strMobNumber;
            string strGuestHouse;

            if (Request.QueryString["Obj"] != null)
            {
                DecReq.Guest_Id = Request.QueryString["Obj"];


                DataTable PL_Joint_Ref_Guesthouse_Wise_Promotion_Select = SERGuest.SERV_Joint_Ref_Guesthouse_Wise_Promotion_Select(DecGuestVar);
                if (PL_Joint_Ref_Guesthouse_Wise_Promotion_Select.Rows.Count > 0)
                {
                    foreach (DataRow DR_Joint_Ref_Guesthouse_Wise_Promotion_Select in PL_Joint_Ref_Guesthouse_Wise_Promotion_Select.Rows)
                    {
                        DecReq.Promo_Id = DR_Joint_Ref_Guesthouse_Wise_Promotion_Select.ItemArray.GetValue(0).ToString().Trim();
                        if (DropDownList3.Text == "With Breakfast")
                        {
                            DecReq.Breakfast = "wb";
                            DecReq.Amount = Convert.ToInt32(Label2.Text);

                            DecReq.Promo_Amount = Convert.ToDouble(DR_Joint_Ref_Guesthouse_Wise_Promotion_Select.ItemArray.GetValue(5));
                            DecReq.Net_Amount = DecReq.Amount - DecReq.Promo_Amount;



                            DecReq.Vat = DecReq.Amount - (DecReq.Amount * 100 / 112);
                        }

                        if (DropDownList3.Text == "Without Breakfast")
                        {
                            DecReq.Breakfast = "nb";
                            DecReq.Amount = Convert.ToInt32(Label1.Text);


                            DecReq.Promo_Amount = Convert.ToDouble(DR_Joint_Ref_Guesthouse_Wise_Promotion_Select.ItemArray.GetValue(8));
                            DecReq.Net_Amount = DecReq.Amount - DecReq.Promo_Amount;




                            DecReq.Vat = DecReq.Amount - (DecReq.Amount * 100 / 112);
                        }

                    }
                }

                else
                {
                    if (DropDownList3.Text == "With Breakfast")
                    {
                        DecReq.Amount = Convert.ToInt32(Label2.Text);
                        DecReq.Promo_Amount = 0;
                        DecReq.Promo_Id = "N/A";
                        DecReq.Net_Amount = Convert.ToInt32(Label2.Text);
                        DecReq.Vat = DecReq.Amount - (DecReq.Amount * 100 / 112);
                        DecReq.Breakfast = "wb";
                    }

                    if (DropDownList3.Text == "Without Breakfast")
                    {
                        DecReq.Amount = Convert.ToInt32(Label1.Text);
                        DecReq.Promo_Id = "N/A";
                        DecReq.Promo_Amount = 0;
                        DecReq.Net_Amount = Convert.ToInt32(Label1.Text);
                        DecReq.Vat = DecReq.Amount - (DecReq.Amount * 100 / 112);
                        DecReq.Breakfast = "nb";
                    }
                }

                DecReq.Requester_First_Name = TextBox1.Text.ToString();
                DecReq.Requester_Last_Name = TextBox2.Text.ToString();
                DecReq.EMail = TextBox3.Text.ToString();
                DecReq.Contact01 = TextBox4.Text.ToString();
                DecReq.Contact02 = TextBox5.Text.ToString();
                DecReq.Fax = TextBox6.Text.ToString();
                DecReq.Guest_From = Convert.ToDateTime(dpf.Text);
                DecReq.Guest_To = Convert.ToDateTime(dpt.Text);
                DecReq.Adults = Convert.ToInt32(DropDownList1.Text);
                DecReq.Children = Convert.ToInt32(DropDownList2.Text);
                DecReq.IsConfirmed = "N";
                DecReq.IsCancelled = "N";
                DecReq.IsCompleated = "N";
                DecReq.Country = DropDownList4.Text.ToString();
                DecReq.Request_Date = System.DateTime.Now;
                DecReq.Progress_Status = "green";

                DataTable PL_Ref_Settings_SelectAll_comment = SERAtt.SERV_Ref_Settings_SelectAll();
                if (PL_Ref_Settings_SelectAll_comment.Rows.Count > 0)
                {
                    foreach (DataRow DR_Ref_Settings_SelectAll_comment in PL_Ref_Settings_SelectAll_comment.Rows)
                    {
                        double dr;
                        dr = Convert.ToDouble(DR_Ref_Settings_SelectAll_comment.ItemArray.GetValue(7));
                        double dr2 = dr + 1;
                        DecReq.Request_Id = "RI" + dr2.ToString().Trim();
                    }
                }

                DecReq.Comments = "Request Was Created";

                string res = "";
                res = SERRec.SERV_Ref_Attraction_Insert_Main(DecReq);
                if (res.Trim() == "1")
                {
                    try
                    {
                        DataTable PL_Ref_Settings_SelectAll = SERAtt.SERV_Ref_Settings_SelectAll();
                        if (PL_Ref_Settings_SelectAll.Rows.Count > 0)
                        {
                            foreach (DataRow DR_Ref_Settings_SelectAll in PL_Ref_Settings_SelectAll.Rows)
                            {
                                DecReq.Request_Id = "RI" + DR_Ref_Settings_SelectAll.ItemArray.GetValue(7).ToString().Trim();
                            }
                        }


                        DataTable PL_Trn_Request_Master_Select_All = SERRec.SERV_Trn_Request_Master_Selected(DecReq);
                        if (PL_Trn_Request_Master_Select_All.Rows.Count > 0)
                        {
                            foreach (DataRow DR_Trn_Request_Master_Select_All in PL_Trn_Request_Master_Select_All.Rows)
                            {
                                strGuestHouse = DR_Trn_Request_Master_Select_All.ItemArray.GetValue(24).ToString().Trim();
                                strFname = DR_Trn_Request_Master_Select_All.ItemArray.GetValue(1).ToString().Trim();
                                strLname = DR_Trn_Request_Master_Select_All.ItemArray.GetValue(2).ToString().Trim();
                                strPhoneNumber = DR_Trn_Request_Master_Select_All.ItemArray.GetValue(5).ToString().Trim();
                                strMobNumber = DR_Trn_Request_Master_Select_All.ItemArray.GetValue(5).ToString().Trim();
                                strArivalDate = DR_Trn_Request_Master_Select_All.ItemArray.GetValue(8).ToString().Trim();
                                strLeaveDate = DR_Trn_Request_Master_Select_All.ItemArray.GetValue(9).ToString().Trim();

                                MailMessage mailMessage = new MailMessage(new MailAddress("snsrequests@gmail.com")
                                               , new MailAddress("snsrequests@gmail.com"));
                                mailMessage.Subject = "Requset Has Been Sent For : " + strGuestHouse + " Request Id : " + DecReq.Request_Id;
                                mailMessage.IsBodyHtml = true;
                                mailMessage.Body = "Name :" + strFname + "<BR><BR> Last Name :" + strLname + "<BR><BR> Phone number" + strPhoneNumber + "<BR><BR> Mobile Number" + strMobNumber + "<BR><BR> Arival Date :" + strArivalDate + " Leaving Date :" + strLeaveDate;

                                System.Net.NetworkCredential networkCredentials = new
                                System.Net.NetworkCredential("snsrequests@gmail.com", "snshol123");

                                SmtpClient smtpClient = new SmtpClient();
                                smtpClient.EnableSsl = true;
                                smtpClient.UseDefaultCredentials = false;
                                smtpClient.Credentials = networkCredentials;
                                smtpClient.Host = "smtp.gmail.com";
                                smtpClient.Port = 587;
                                smtpClient.Send(mailMessage);

                                strGuestHouse = DR_Trn_Request_Master_Select_All.ItemArray.GetValue(24).ToString().Trim();
                                strFname = DR_Trn_Request_Master_Select_All.ItemArray.GetValue(1).ToString().Trim();
                                strLname = DR_Trn_Request_Master_Select_All.ItemArray.GetValue(2).ToString().Trim();
                                strPhoneNumber = DR_Trn_Request_Master_Select_All.ItemArray.GetValue(5).ToString().Trim();
                                strMobNumber = DR_Trn_Request_Master_Select_All.ItemArray.GetValue(5).ToString().Trim();
                                strArivalDate = DR_Trn_Request_Master_Select_All.ItemArray.GetValue(8).ToString().Trim();
                                strLeaveDate = DR_Trn_Request_Master_Select_All.ItemArray.GetValue(9).ToString().Trim();

                                MailMessage mailMessageclient = new MailMessage(new MailAddress(TextBox3.Text)
                                               , new MailAddress(TextBox3.Text));
                                mailMessageclient.Subject = "Requset Has Been Sent For : " + strGuestHouse + " Request Id : " + DecReq.Request_Id;
                                mailMessageclient.IsBodyHtml = true;
                                mailMessageclient.Body = "Name :" + strFname + "<BR><BR> Last Name :" + strLname + "<BR><BR> Phone number" + strPhoneNumber + "<BR><BR> Mobile Number" + strMobNumber + "<BR><BR> Arival Date :" + strArivalDate + " Leaving Date :" + strLeaveDate;

                                System.Net.NetworkCredential networkCredentialsClient = new
                                System.Net.NetworkCredential("snsrequests@gmail.com", "snshol123");

                                SmtpClient smtpClientClient = new SmtpClient();
                                smtpClient.EnableSsl = true;
                                smtpClient.UseDefaultCredentials = false;
                                smtpClient.Credentials = networkCredentialsClient;
                                smtpClient.Host = "smtp.gmail.com";
                                smtpClient.Port = 587;
                                smtpClient.Send(mailMessageclient);

                            }
                        }
                    }
                    catch
                    {

                    }


                }


            }
        }
        catch
        {

        }

    }

    void smtpClient_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
    {
        MailMessage mailMessage = default(MailMessage);
        mailMessage = (MailMessage)e.UserState;
        if ((e.Cancelled))
        {
            Label1.Text = "Sending of email message was cancelled. Address=" + mailMessage.To[0].Address;
        }
        if ((e.Error != null))
        {
            Label1.Text = "Error occured, info :" + e.Error.Message;
        }
        else
        {
            Label1.Text = "Mail sent successfully";
        }
    }
}