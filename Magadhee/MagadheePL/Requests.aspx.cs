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

public partial class Requests : System.Web.UI.Page
{
    SERRequests SSR = new SERRequests();
    DECVariables.ClsRequest DVC =new DECVariables.ClsRequest();

    SERAddAttractions SERAtt = new SERAddAttractions();

    SERAddGuestHouse SERGuest = new SERAddGuestHouse();

    protected void Page_Load(object sender, System.EventArgs e)
    {
        Session["Inits"] = "Requests.aspx";

        string Numo = (string)(Session["usp"]);
        string pumo = (string)(Session["wasp"]);

        if (Numo == null && pumo == null)
        {
            Response.Redirect("login.aspx");
        }

        if (IsPostBack != true)
        {
            try
            {
                DataTable DT_Trn_Request_Master_Select_All = SSR.SERV_Trn_Request_Master_Select_All();
                GVReqNew.DataSource = DT_Trn_Request_Master_Select_All;
                GVReqNew.DataBind();
                GVReqNew.CssClass = "table table-bordered table-condensed";

                DataTable DT_Trn_Request_Master_Select_All_Confirmed = SSR.SERV_Trn_Request_Master_Select_All_Confirmed();
                GVReqCon.DataSource = DT_Trn_Request_Master_Select_All_Confirmed;
                GVReqCon.DataBind();
                GVReqCon.CssClass = "table table-bordered table-condensed";

                DropDownList1.Enabled = false;
                DropDownList3.Enabled = false;
            }
            catch
            {

            }
        }
    }
    protected void gvCityUp_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void gvCityUp0_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {

    }

    public void GVReqNew_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int rowIndex = Convert.ToInt32(e.CommandArgument);
        DVC.Request_Id = GVReqNew.Rows[rowIndex].Cells[0].Text.ToString().Trim();
        Label1.Text = GVReqNew.Rows[rowIndex].Cells[0].Text.ToString().Trim();

        DataTable PL_Trn_Request_Master_Selected = SSR.SERV_Trn_Request_Master_Selected(DVC);

        foreach (DataRow DR_Trn_Request_Master_Selected in PL_Trn_Request_Master_Selected.Rows)
        {
            if (DR_Trn_Request_Master_Selected.ItemArray.GetValue(18).ToString().Trim() == "wb")
            {
                DropDownList3.Text = "With Breakfast";
            }

            if (DR_Trn_Request_Master_Selected.ItemArray.GetValue(18).ToString().Trim() == "nb")
            {
                DropDownList3.Text = "Without Breakfast";
            }

            Label1.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(24).ToString().Trim();
            Label2.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(0).ToString().Trim();
            TextBox1.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(1).ToString().Trim();
            TextBox2.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(2).ToString().Trim();
            TextBox3.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(3).ToString().Trim();
            TextBox4.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(4).ToString().Trim();
            TextBox5.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(5).ToString().Trim();
            TextBox6.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(6).ToString().Trim();
            TextBox7.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(7).ToString().Trim();
            TextBox8.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(8).ToString().Trim();
            TextBox9.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(9).ToString().Trim();
            TextBox10.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(10).ToString().Trim();
            TextBox11.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(11).ToString().Trim();
            TextBox48.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(2).ToString().Trim();
            TextBox49.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(3).ToString().Trim();
            Label3.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(12).ToString().Trim();
            Label5.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(17).ToString().Trim();
        }

        DataTable PL_Trn_Request_Wise_Comments_Select_Request_wise = SSR.SERV_Trn_Request_Wise_Comments_Select_Request_wise(DVC);

        foreach (DataRow DR_Trn_Request_Wise_Comments_Select_Request_wise in PL_Trn_Request_Wise_Comments_Select_Request_wise.Rows)
        {
            TableRow tRow = new TableRow();
            

            TableCell tCellDate = new TableCell();
            TableCell tCellComment = new TableCell();
            tCellDate.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(1).ToString().Trim();
            tCellComment.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(2).ToString().Trim();
            tRow.Cells.Add(tCellDate);
            tRow.Cells.Add(tCellComment);
            Table1.Rows.Add(tRow);
        }
        
    }


    public void GVReqCon_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int rowIndex = Convert.ToInt32(e.CommandArgument);
        DVC.Request_Id = GVReqCon.Rows[rowIndex].Cells[0].Text.ToString().Trim();
        Label10.Text = GVReqCon.Rows[rowIndex].Cells[0].Text.ToString().Trim();

        DataTable PL_Trn_Request_Master_Selected = SSR.SERV_Trn_Request_Master_Selected(DVC);

        foreach (DataRow DR_Trn_Request_Master_Selected in PL_Trn_Request_Master_Selected.Rows)
        {
            if (DR_Trn_Request_Master_Selected.ItemArray.GetValue(18).ToString().Trim() == "wb")
            {
                DropDownList1.Text = "With Breakfast";
            }

            if (DR_Trn_Request_Master_Selected.ItemArray.GetValue(18).ToString().Trim() == "nb")
            {
                DropDownList1.Text = "Without Breakfast";
            }
            Label10.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(24).ToString().Trim();
            Label11.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(0).ToString().Trim();
            TextBox14.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(1).ToString().Trim();
            TextBox15.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(2).ToString().Trim();
            TextBox16.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(3).ToString().Trim();


            TextBox43.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(2).ToString().Trim();
            TextBox44.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(3).ToString().Trim();

            TextBox17.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(4).ToString().Trim();
            TextBox18.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(5).ToString().Trim();
            TextBox29.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(6).ToString().Trim();
            TextBox19.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(7).ToString().Trim();
            TextBox30.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(8).ToString().Trim();
            TextBox31.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(9).ToString().Trim();
            TextBox20.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(10).ToString().Trim();
            TextBox21.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(11).ToString().Trim();
            Label22.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(12).ToString().Trim();
            Label6.Text = DR_Trn_Request_Master_Selected.ItemArray.GetValue(17).ToString().Trim();
        }

        DataTable PL_Trn_Request_Wise_Comments_Select_Request_wise = SSR.SERV_Trn_Request_Wise_Comments_Select_Request_wise(DVC);

        foreach (DataRow DR_Trn_Request_Wise_Comments_Select_Request_wise in PL_Trn_Request_Wise_Comments_Select_Request_wise.Rows)
        {
            TableRow tRow = new TableRow();


            TableCell tCellDate = new TableCell();
            TableCell tCellComment = new TableCell();
            tCellDate.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(1).ToString().Trim();
            tCellComment.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(2).ToString().Trim();
            tRow.Cells.Add(tCellDate);
            tRow.Cells.Add(tCellComment);
            Table2.Rows.Add(tRow);
        }

    }


    protected void Button5_Click(object sender, EventArgs e)
    {
        string strFname;
        string strLname;
        string stremail;
        string strGuestHouse;
        string strReq;

        DVC.Request_Id = Label2.Text.ToString().Trim();
        DVC.IsConfirmed = "Y";
        DVC.Comments = "Request Was Confirmed";

        string res = "";
        res = SSR.SERV_Trn_Request_Master_Confirmed_Update(DVC);
        if (res.Trim() == "1")
        {
            try
            {
                DataTable PL_Trn_Request_Wise_Comments_Select_Request_wise = SSR.SERV_Trn_Request_Wise_Comments_Select_Request_wise(DVC);

                foreach (DataRow DR_Trn_Request_Wise_Comments_Select_Request_wise in PL_Trn_Request_Wise_Comments_Select_Request_wise.Rows)
                {
                    TableRow tRow = new TableRow();


                    TableCell tCellDate = new TableCell();
                    TableCell tCellComment = new TableCell();
                    tCellDate.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(1).ToString().Trim();
                    tCellComment.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(2).ToString().Trim();
                    tRow.Cells.Add(tCellDate);
                    tRow.Cells.Add(tCellComment);
                    Table1.Rows.Add(tRow);
                }

                DVC.Request_Id = Label2.Text;
              

                DataTable PL_Trn_Request_Master_Selected = SSR.SERV_Trn_Request_Master_Selected(DVC);
                if (PL_Trn_Request_Master_Selected.Rows.Count > 0)
                {
                    foreach (DataRow DR_Trn_Request_Master_Selected in PL_Trn_Request_Master_Selected.Rows)
                    {
                        strGuestHouse = DR_Trn_Request_Master_Selected.ItemArray.GetValue(24).ToString().Trim();
                        strReq = DVC.Request_Id;
                        strFname = DR_Trn_Request_Master_Selected.ItemArray.GetValue(1).ToString().Trim();
                        strLname = DR_Trn_Request_Master_Selected.ItemArray.GetValue(2).ToString().Trim();
                        stremail = DR_Trn_Request_Master_Selected.ItemArray.GetValue(3).ToString().Trim();

                        MailMessage mailMessage = new MailMessage(new MailAddress(stremail)
                                       , new MailAddress(stremail));
                        mailMessage.Subject ="Mr."+strFname+ " "+strLname+" "+ "Your Request has been confirmed";
                        mailMessage.IsBodyHtml = true;
                        mailMessage.Body = "Dear Mr." + strLname + "<BR><BR> Your Request has been confirmed. Your Request Id is:" + strReq + "<BR> Please contact us for any inquiries<BR><BR> Thank You <BR><BR> SNS Holiday Homes";

                        System.Net.NetworkCredential networkCredentials = new
                        System.Net.NetworkCredential("snsholidayhomes@gmail.com", "snsreq123");

                        SmtpClient smtpClient = new SmtpClient();
                        smtpClient.EnableSsl = true;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = networkCredentials;
                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.Send(mailMessage);
                    }
                }

                DataTable DT_Trn_Request_Master_Select_All = SSR.SERV_Trn_Request_Master_Select_All();
                GVReqNew.DataSource = DT_Trn_Request_Master_Select_All;
                GVReqNew.DataBind();

                DataTable DT_Trn_Request_Master_Select_All_Confirmed = SSR.SERV_Trn_Request_Master_Select_All_Confirmed();
                GVReqCon.DataSource = DT_Trn_Request_Master_Select_All_Confirmed;
                GVReqCon.DataBind();
                GVReqCon.CssClass = "table table-bordered table-condensed";
            }
            catch
            {

            }


        }

    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        string strFname;
        string strLname;
        string stremail;
        string strGuestHouse;
        string strReq;

        DVC.Request_Id = Label2.Text.ToString().Trim();
        DVC.IsCancelled = "Y";
        DVC.Comments = "Request Was Cancelled";
        string res = "";
        res = SSR.SERV_Trn_Request_Master_Cancel_Update(DVC);
        if (res.Trim() == "1")
        {
            try
            {

                DataTable PL_Trn_Request_Wise_Comments_Select_Request_wise = SSR.SERV_Trn_Request_Wise_Comments_Select_Request_wise(DVC);

                foreach (DataRow DR_Trn_Request_Wise_Comments_Select_Request_wise in PL_Trn_Request_Wise_Comments_Select_Request_wise.Rows)
                {
                    TableRow tRow = new TableRow();


                    TableCell tCellDate = new TableCell();
                    TableCell tCellComment = new TableCell();
                    tCellDate.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(1).ToString().Trim();
                    tCellComment.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(2).ToString().Trim();
                    tRow.Cells.Add(tCellDate);
                    tRow.Cells.Add(tCellComment);
                    Table1.Rows.Add(tRow);
                }

                DVC.Request_Id = Label2.Text;


                DataTable PL_Trn_Request_Master_Selected = SSR.SERV_Trn_Request_Master_Selected(DVC);
                if (PL_Trn_Request_Master_Selected.Rows.Count > 0)
                {
                    foreach (DataRow DR_Trn_Request_Master_Selected in PL_Trn_Request_Master_Selected.Rows)
                    {
                        strGuestHouse = DR_Trn_Request_Master_Selected.ItemArray.GetValue(24).ToString().Trim();
                        strReq = DVC.Request_Id;
                        strFname = DR_Trn_Request_Master_Selected.ItemArray.GetValue(1).ToString().Trim();
                        strLname = DR_Trn_Request_Master_Selected.ItemArray.GetValue(2).ToString().Trim();
                        stremail = DR_Trn_Request_Master_Selected.ItemArray.GetValue(3).ToString().Trim();

                        MailMessage mailMessage = new MailMessage(new MailAddress(stremail)
                                       , new MailAddress(stremail));
                        mailMessage.Subject = "Mr." + strFname + " " + strLname + " " + "Your Request has been Cancelled";
                        mailMessage.IsBodyHtml = true;
                        mailMessage.Body = "Dear Mr." + strLname + "<BR><BR> Your Request has been Cancelled. Your Request Id is:" + strReq + "<BR> Please contact us for any inquiries<BR><BR> Thank You <BR><BR> SNS Holiday Homes";

                        System.Net.NetworkCredential networkCredentials = new
                        System.Net.NetworkCredential("snsholidayhomes@gmail.com", "snsreq123");

                        SmtpClient smtpClient = new SmtpClient();
                        smtpClient.EnableSsl = true;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = networkCredentials;
                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.Send(mailMessage);
                    }
                }

                DataTable DT_Trn_Request_Master_Select_All = SSR.SERV_Trn_Request_Master_Select_All();
                GVReqNew.DataSource = DT_Trn_Request_Master_Select_All;
                GVReqNew.DataBind();
            }
            catch
            {

            }


        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            DVC.Request_Id = Label2.Text.ToString().Trim();
            DVC.IsCancelled = "Y";
            DVC.Comments = TextBox13.Text.ToString();

            string res = "";
            res = SSR.SERV_Trn_Request_Wise_Comments_Insert_Main(DVC);
            if (res.Trim() == "1")
            {
                DataTable PL_Trn_Request_Wise_Comments_Select_Request_wise = SSR.SERV_Trn_Request_Wise_Comments_Select_Request_wise(DVC);

                foreach (DataRow DR_Trn_Request_Wise_Comments_Select_Request_wise in PL_Trn_Request_Wise_Comments_Select_Request_wise.Rows)
                {
                    TableRow tRow = new TableRow();


                    TableCell tCellDate = new TableCell();
                    TableCell tCellComment = new TableCell();
                    tCellDate.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(1).ToString().Trim();
                    tCellComment.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(2).ToString().Trim();
                    tRow.Cells.Add(tCellDate);
                    tRow.Cells.Add(tCellComment);
                    Table2.Rows.Add(tRow);
                }

            }
        }
        catch
        {

        }
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        string strFname;
        string strLname;
        string stremail;
        string strGuestHouse;
        string strReq;

        DVC.Request_Id = Label11.Text.ToString().Trim();
        DVC.IsCancelled = "Y";
        DVC.Comments = "Request Was Cancelled";
        string res = "";
        res = SSR.SERV_Trn_Request_Master_Cancel_Update(DVC);
        if (res.Trim() == "1")
        {
            try
            {

                DataTable PL_Trn_Request_Wise_Comments_Select_Request_wise = SSR.SERV_Trn_Request_Wise_Comments_Select_Request_wise(DVC);

                foreach (DataRow DR_Trn_Request_Wise_Comments_Select_Request_wise in PL_Trn_Request_Wise_Comments_Select_Request_wise.Rows)
                {
                    TableRow tRow = new TableRow();


                    TableCell tCellDate = new TableCell();
                    TableCell tCellComment = new TableCell();
                    tCellDate.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(1).ToString().Trim();
                    tCellComment.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(2).ToString().Trim();
                    tRow.Cells.Add(tCellDate);
                    tRow.Cells.Add(tCellComment);
                    Table2.Rows.Add(tRow);
                }

                DVC.Request_Id = Label2.Text;


                DataTable PL_Trn_Request_Master_Selected = SSR.SERV_Trn_Request_Master_Selected(DVC);
                if (PL_Trn_Request_Master_Selected.Rows.Count > 0)
                {
                    foreach (DataRow DR_Trn_Request_Master_Selected in PL_Trn_Request_Master_Selected.Rows)
                    {
                        strGuestHouse = DR_Trn_Request_Master_Selected.ItemArray.GetValue(24).ToString().Trim();
                        strReq = DVC.Request_Id;
                        strFname = DR_Trn_Request_Master_Selected.ItemArray.GetValue(1).ToString().Trim();
                        strLname = DR_Trn_Request_Master_Selected.ItemArray.GetValue(2).ToString().Trim();
                        stremail = DR_Trn_Request_Master_Selected.ItemArray.GetValue(3).ToString().Trim();

                        MailMessage mailMessage = new MailMessage(new MailAddress(stremail)
                                       , new MailAddress(stremail));
                        mailMessage.Subject = "Mr." + strFname + " " + strLname + " " + "Your Request has been Cancelled";
                        mailMessage.IsBodyHtml = true;
                        mailMessage.Body = "Dear Mr." + strLname + "<BR><BR> Your Request has been Cancelled. Your Request Id is:" + strReq + "<BR> Please contact us for any inquiries <BR><BR> Thank You <BR><BR> SNS Holiday Homes";

                        System.Net.NetworkCredential networkCredentials = new
                        System.Net.NetworkCredential("snsholidayhomes@gmail.com", "snsreq123");

                        SmtpClient smtpClient = new SmtpClient();
                        smtpClient.EnableSsl = true;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = networkCredentials;
                        smtpClient.Host = "smtp.gmail.com";
                        smtpClient.Port = 587;
                        smtpClient.Send(mailMessage);
                    }
                }

                DataTable DT_Trn_Request_Master_Select_All_Confirmed = SSR.SERV_Trn_Request_Master_Select_All_Confirmed();
                GVReqCon.DataSource = DT_Trn_Request_Master_Select_All_Confirmed;
                GVReqCon.DataBind();
            }
            catch
            {

            }


        }
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        try
        {
            DVC.Request_Id = Label11.Text.ToString().Trim();
            DVC.Comments = TextBox28.Text.ToString();

            string res = "";
            res = SSR.SERV_Trn_Request_Wise_Comments_Insert_Main(DVC);
            if (res.Trim() == "1")
            {
                

                DataTable PL_Trn_Request_Wise_Comments_Select_Request_wise = SSR.SERV_Trn_Request_Wise_Comments_Select_Request_wise(DVC);

                foreach (DataRow DR_Trn_Request_Wise_Comments_Select_Request_wise in PL_Trn_Request_Wise_Comments_Select_Request_wise.Rows)
                {
                    TableRow tRow = new TableRow();


                    TableCell tCellDate = new TableCell();
                    TableCell tCellComment = new TableCell();
                    tCellDate.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(1).ToString().Trim();
                    tCellComment.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(2).ToString().Trim();
                    tRow.Cells.Add(tCellDate);
                    tRow.Cells.Add(tCellComment);
                    Table2.Rows.Add(tRow);
                }

            }
        }
        catch
        {

        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
            DVC.Request_Id = Label2.Text;
            
            if (DropDownList3.Text == "With Breakfast")
            {
                DVC.Breakfast = "wb";       
            }

            if (DropDownList3.Text == "Without Breakfast")
            {
                DVC.Breakfast = "nb";          
            }

            DVC.Requester_First_Name = TextBox1.Text.ToString();
            DVC.Requester_Last_Name = TextBox2.Text.ToString();
            DVC.EMail = TextBox3.Text.ToString();
            DVC.Contact01 = TextBox4.Text.ToString();
            DVC.Contact02 = TextBox5.Text.ToString();
            DVC.Fax = TextBox6.Text.ToString();
            DVC.Guest_From = Convert.ToDateTime(TextBox8.Text);
            DVC.Guest_To = Convert.ToDateTime(TextBox9.Text);
            DVC.Adults = Convert.ToInt32(TextBox10.Text);
            DVC.Children = Convert.ToInt32(TextBox11.Text);
            DVC.Country = TextBox7.Text;
            

            
            
            DVC.Comments = "Request Was Updated";
            
            string res = "";
            res = SSR.SERV_Trn_Request_Master_Update(DVC);
            if (res.Trim() == "1")
            {
                DataTable PL_Trn_Request_Wise_Comments_Select_Request_wise = SSR.SERV_Trn_Request_Wise_Comments_Select_Request_wise(DVC);

                foreach (DataRow DR_Trn_Request_Wise_Comments_Select_Request_wise in PL_Trn_Request_Wise_Comments_Select_Request_wise.Rows)
                {
                    TableRow tRow = new TableRow();


                    TableCell tCellDate = new TableCell();
                    TableCell tCellComment = new TableCell();
                    tCellDate.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(1).ToString().Trim();
                    tCellComment.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(2).ToString().Trim();
                    tRow.Cells.Add(tCellDate);
                    tRow.Cells.Add(tCellComment);
                    Table1.Rows.Add(tRow);
                }

                DataTable DT_Trn_Request_Master_Select_All = SSR.SERV_Trn_Request_Master_Select_All();
                GVReqNew.DataSource = DT_Trn_Request_Master_Select_All;
                GVReqNew.DataBind();
                GVReqNew.CssClass = "table table-bordered table-condensed";

                

            }
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        DVC.Request_Id = Label11.Text;

        if (DropDownList1.Text == "With Breakfast")
        {
            DVC.Breakfast = "wb";
        }

        if (DropDownList1.Text == "Without Breakfast")
        {
            DVC.Breakfast = "nb";
        }

        DVC.Requester_First_Name = TextBox14.Text.ToString();
        DVC.Requester_Last_Name = TextBox15.Text.ToString();
        DVC.EMail = TextBox16.Text.ToString();
        DVC.Contact01 = TextBox17.Text.ToString();
        DVC.Contact02 = TextBox18.Text.ToString();
        DVC.Fax = TextBox29.Text.ToString();
        DVC.Guest_From = Convert.ToDateTime(TextBox30.Text);
        DVC.Guest_To = Convert.ToDateTime(TextBox31.Text);
        DVC.Adults = Convert.ToInt32(TextBox20.Text);
        DVC.Children = Convert.ToInt32(TextBox21.Text);
        DVC.Country = TextBox19.Text;




        DVC.Comments = "Request Was Updated";

        string res = "";
        res = SSR.SERV_Trn_Request_Master_Update(DVC);
        if (res.Trim() == "1")
        {
            DataTable PL_Trn_Request_Wise_Comments_Select_Request_wise = SSR.SERV_Trn_Request_Wise_Comments_Select_Request_wise(DVC);

            foreach (DataRow DR_Trn_Request_Wise_Comments_Select_Request_wise in PL_Trn_Request_Wise_Comments_Select_Request_wise.Rows)
            {
                TableRow tRow = new TableRow();


                TableCell tCellDate = new TableCell();
                TableCell tCellComment = new TableCell();
                tCellDate.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(1).ToString().Trim();
                tCellComment.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(2).ToString().Trim();
                tRow.Cells.Add(tCellDate);
                tRow.Cells.Add(tCellComment);
                Table2.Rows.Add(tRow);
            }

            

            DataTable DT_Trn_Request_Master_Select_All_Confirmed = SSR.SERV_Trn_Request_Master_Select_All_Confirmed();
            GVReqCon.DataSource = DT_Trn_Request_Master_Select_All_Confirmed;
            GVReqCon.DataBind();
            GVReqCon.CssClass = "table table-bordered table-condensed";

        }

    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        DVC.Request_Id = Label11.Text;
        DataTable PL_Trn_Request_Master_Selected = SSR.SERV_Trn_Request_Master_Selected(DVC);
        if (PL_Trn_Request_Master_Selected.Rows.Count > 0)
        {
            foreach (DataRow DR_Trn_Request_Master_Selected in PL_Trn_Request_Master_Selected.Rows)
            {
                DVC.Requester_First_Name = DR_Trn_Request_Master_Selected.ItemArray.GetValue(1).ToString().Trim();
                DVC.Requester_Last_Name = DR_Trn_Request_Master_Selected.ItemArray.GetValue(2).ToString().Trim();
                DVC.EMail = DR_Trn_Request_Master_Selected.ItemArray.GetValue(3).ToString().Trim();
                DVC.Contact01 = DR_Trn_Request_Master_Selected.ItemArray.GetValue(4).ToString().Trim();
                DVC.Contact02 = DR_Trn_Request_Master_Selected.ItemArray.GetValue(5).ToString().Trim();
                DVC.Fax = DR_Trn_Request_Master_Selected.ItemArray.GetValue(6).ToString().Trim();
                DVC.Country = DR_Trn_Request_Master_Selected.ItemArray.GetValue(7).ToString().Trim();
                DVC.Guest_From =Convert.ToDateTime(DR_Trn_Request_Master_Selected.ItemArray.GetValue(8));
                DVC.Guest_To= Convert.ToDateTime(DR_Trn_Request_Master_Selected.ItemArray.GetValue(9));
                DVC.Adults = Convert.ToInt32(DR_Trn_Request_Master_Selected.ItemArray.GetValue(10));
                DVC.Children = Convert.ToInt32(DR_Trn_Request_Master_Selected.ItemArray.GetValue(11));
                DVC.Request_Date = Convert.ToDateTime(DR_Trn_Request_Master_Selected.ItemArray.GetValue(12));
                DVC.Amount = Convert.ToDouble(DR_Trn_Request_Master_Selected.ItemArray.GetValue(17));
                DVC.Breakfast = DR_Trn_Request_Master_Selected.ItemArray.GetValue(18).ToString().Trim();
                DVC.Promo_Id=DR_Trn_Request_Master_Selected.ItemArray.GetValue(19).ToString().Trim();
                DVC.Promo_Amount = Convert.ToDouble(DR_Trn_Request_Master_Selected.ItemArray.GetValue(20));
                DVC.Vat = Convert.ToDouble(DR_Trn_Request_Master_Selected.ItemArray.GetValue(21));
                DVC.Net_Amount = Convert.ToDouble(DR_Trn_Request_Master_Selected.ItemArray.GetValue(22));
                DVC.Guest_Id = DR_Trn_Request_Master_Selected.ItemArray.GetValue(23).ToString().Trim();
                DVC.Confirmed_Date =Convert.ToDateTime(DR_Trn_Request_Master_Selected.ItemArray.GetValue(26));

                DVC.Comments = "Request Was Updated";

                string res = "";
                res = SSR.SERV_Trn_Request_Compleated_Insert_Main(DVC);
                if (res.Trim() == "1")
                {
                    DataTable PL_Trn_Request_Wise_Comments_Select_Request_wise = SSR.SERV_Trn_Request_Wise_Comments_Select_Request_wise(DVC);

                    foreach (DataRow DR_Trn_Request_Wise_Comments_Select_Request_wise in PL_Trn_Request_Wise_Comments_Select_Request_wise.Rows)
                    {
                        TableRow tRow = new TableRow();


                        TableCell tCellDate = new TableCell();
                        TableCell tCellComment = new TableCell();
                        tCellDate.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(1).ToString().Trim();
                        tCellComment.Text = DR_Trn_Request_Wise_Comments_Select_Request_wise.ItemArray.GetValue(2).ToString().Trim();
                        tRow.Cells.Add(tCellDate);
                        tRow.Cells.Add(tCellComment);
                        Table2.Rows.Add(tRow);
                    }

                    DataTable DT_Trn_Request_Master_Select_All_Confirmed = SSR.SERV_Trn_Request_Master_Select_All_Confirmed();
                    GVReqCon.DataSource = DT_Trn_Request_Master_Select_All_Confirmed;
                    GVReqCon.DataBind();
                }

            }
        }
    }

    protected void Button13_Click1(object sender, EventArgs e)
    {
        try
        {

            MailMessage mailMessage = new MailMessage(new MailAddress(TextBox49.Text)
                           , new MailAddress(TextBox49.Text.Trim()));
            mailMessage.Subject = "Mr." + TextBox48.Text;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "Dear Mr." + TextBox48.Text + "<BR><BR>" + TextBox50.Text + "<BR><BR> Thank You <BR><BR> SNS Holiday Homes";

            System.Net.NetworkCredential networkCredentials = new
            System.Net.NetworkCredential("snsholidayhomes@gmail.com", "snsreq123");

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = networkCredentials;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.Send(mailMessage);
        }
        catch
        {
            Labe18.Text = "There was an Error sending this mail";
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button25_Click(object sender, EventArgs e)
    {
        try
        {

            MailMessage mailMessage = new MailMessage(new MailAddress(TextBox49.Text)
                           , new MailAddress(TextBox49.Text.Trim()));
            mailMessage.Subject = "Mr." + TextBox48.Text;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "Dear Mr." + TextBox48.Text + "<BR><BR>" + TextBox50.Text + "<BR><BR> Thank You <BR><BR> SNS Holiday Homes";

            System.Net.NetworkCredential networkCredentials = new
            System.Net.NetworkCredential("snsholidayhomes@gmail.com", "snsreq123");

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = networkCredentials;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.Send(mailMessage);
        }
        catch
        {
            Labe17.Text = "There was an Error sending this mail";
        }
    
    }
}