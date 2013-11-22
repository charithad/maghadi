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
using System.Net;
using System.Text;
using MagadheeDEC.GuestHouseDec;
using MgadheeService.GuestHouseService;

public partial class AddClientTestimonial : System.Web.UI.Page
{
    DECVariables.ClsCust_Test DECClient = new DECVariables.ClsCust_Test();
    DECVariables.ClsAddGuestHouse DECGuest = new DECVariables.ClsAddGuestHouse();
    SERAddClientTestimonial SERClient = new SERAddClientTestimonial();
    SERAddGuestHouse SERGuest = new SERAddGuestHouse();
    SERAddAttractions SERAtt = new SERAddAttractions();

    string Cid;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Session["Inits"] = "AddClientTestimonial.aspx";


            string Numo = (string)(Session["usp"]);
            string pumo = (string)(Session["wasp"]);

            if (Numo == null && pumo == null)
            {
                Response.Redirect("login.aspx");
            }
            if (IsPostBack == false)
            {

                DataTable Dt_Ref_Client_Testimonials_SelectAll = SERClient.SERV_Ref_Client_Testimonials_SelectAll();
                GVClient.DataSource = Dt_Ref_Client_Testimonials_SelectAll;
                GVClient.DataBind();


                DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
                GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
                GVBangalow.DataBind();


                GVGuestAdd.DataSource = DT_Ref_Guest_SelectAll;
                GVGuestAdd.DataBind();


            }
        }
        catch
        {

        }
    }

    public void GVClient_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {

            int rowIndex = Convert.ToInt32(e.CommandArgument);
            DECClient.Client_Test_Id = GVClient.Rows[rowIndex].Cells[0].Text.ToString().Trim();
            Label1.Text = GVClient.Rows[rowIndex].Cells[0].Text.ToString().Trim();
            Calendar2.SelectedDate = Convert.ToDateTime(GVClient.Rows[rowIndex].Cells[2].Text.ToString().Trim());
            DataTable PL_Client_Testimonials_Selected = SERClient.SERV_Ref_Client_Testimonials_Selected(DECClient);
            if (PL_Client_Testimonials_Selected.Rows.Count != 0)
            {

                foreach (DataRow DR_Client_Testimonials_Selected in PL_Client_Testimonials_Selected.Rows)
                {
                    TextBox4.Text = DR_Client_Testimonials_Selected[2].ToString().Trim();
                    TextBox5.Text = DR_Client_Testimonials_Selected[1].ToString().Trim();
                }
            }

            DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
            GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
            GVBangalow.DataBind();



            DataTable PL_Ref_Client_Testimonials_Wise_Guest_Selected = SERClient.SERV_Ref_Client_Testimonials_Wise_Guest_Selected(DECClient);
            if (PL_Ref_Client_Testimonials_Wise_Guest_Selected.Rows.Count != 0)
            {

                foreach (DataRow DR_Ref_Client_Testimonials_Wise_Guest_Selected in PL_Ref_Client_Testimonials_Wise_Guest_Selected.Rows)
                {
                    int rowIndexCit = 0;
                    foreach (GridViewRow gr in GVBangalow.Rows)
                    {
                        CheckBox cbGen2 = (CheckBox)gr.Cells[2].FindControl("ChkBang");

                        if (GVBangalow.Rows[rowIndexCit].Cells[0].Text.ToString().Trim() == DR_Ref_Client_Testimonials_Wise_Guest_Selected[0].ToString().Trim())
                        {
                            if (cbGen2.Checked != true)
                            {
                                cbGen2.Checked = true;
                            }
                        }
                        rowIndexCit++;
                    }
                }
            }
        }

        catch
        {

        }

    }

    private void WriteToFile(string strPath, ref byte[] Buffer)
    {
        try
        {
            FileStream newFile = new FileStream(strPath, FileMode.Create);
            newFile.Write(Buffer, 0, Buffer.Length);
            newFile.Close();
        }
        catch
        {
            Label2.Text = "There Was An Error Saving The Image";

        }
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {

            int num;


            

            DataTable PL_Ref_Settings_SelectAll = SERAtt.SERV_Ref_Settings_SelectAll();
            if (PL_Ref_Settings_SelectAll.Rows.Count > 0)
            {
                foreach (DataRow Dr_Ref_Settings_SelectAll in PL_Ref_Settings_SelectAll.Rows)
                {
                    num = Convert.ToInt32(Dr_Ref_Settings_SelectAll[1]) + 1;

                    Cid = "CI" + num.ToString();
                }
            }
            DECClient.Client_Name = TextBox1.Text;
            DECClient.Client_Content = TextBox2.Text;
            DECClient.IsHighlighted = "Y";

            DateTime dts = Calendar1.SelectedDate;
            DECClient.Client_Date = dts;
           

            int rowIndex = 0;

            List<DECVariables.ClsCust_Test> List2 = new List<DECVariables.ClsCust_Test>();
            DECVariables.ClsCust_Test row1;
            foreach (GridViewRow gr in GVGuestAdd.Rows)
            {
                CheckBox cb = (CheckBox)gr.Cells[0].FindControl("ChkGuest");
                if (cb.Checked == true)
                {
                    row1 = new DECVariables.ClsCust_Test();

                    row1.Guest_Code = GVGuestAdd.Rows[rowIndex].Cells[0].Text.ToString();
                    row1.Client_Test_Id = Cid;
                    List2.Add(row1);
                }
                rowIndex++;
            }

            string res = "";
            res = SERClient.SERV_Ref_Client_Testimonials_Insert_Main(DECClient, List2);
            if (res.Trim() == "1")
            {
                try
                {

                    Response.Write("OK !");
                    DataTable Dt_Ref_Client_Testimonials_SelectAll = SERClient.SERV_Ref_Client_Testimonials_SelectAll();
                    GVClient.DataSource = Dt_Ref_Client_Testimonials_SelectAll;
                    GVClient.DataBind();


                    DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
                    GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
                    GVBangalow.DataBind();


                    GVGuestAdd.DataSource = DT_Ref_Guest_SelectAll;
                    GVGuestAdd.DataBind();
                }
                catch
                {
                    Label2.Text = "There Was an Error Insering The Record";
                    return;
                }

            }
            else
            {
                Response.Write(res);
            }
        }
        catch
        {
            Label2.Text = "There was an error";
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string CIDS;

            


            CIDS = Label1.Text.Trim();

            int rowIndCid = 0;

            List<DECVariables.ClsCust_Test> ListUp3 = new List<DECVariables.ClsCust_Test>();
            DECVariables.ClsCust_Test row1;
            foreach (GridViewRow gt in GVBangalow.Rows)
            {
                CheckBox cb = (CheckBox)gt.Cells[0].FindControl("ChkBang");
                if (cb.Checked == true)
                {
                    row1 = new DECVariables.ClsCust_Test();

                    row1.Guest_Code = GVBangalow.Rows[rowIndCid].Cells[0].Text.ToString();
                    row1.Client_Test_Id = CIDS;
                    ListUp3.Add(row1);
                }
                rowIndCid++;
            }
            DECClient.Client_Test_Id = Label1.Text;
            DECClient.Client_Name = TextBox5.Text.Trim();
            DECClient.Client_Content = TextBox4.Text.Trim();
            DECClient.IsHighlighted = "Y";
            DateTime dtup = Calendar2.SelectedDate;
            DECClient.Client_Date = dtup;
            string res = "";
            res = SERClient.SERV_Ref_Client_Testimonials_Update_Main(DECClient, ListUp3);
            if (res.Trim() == "1")
            {
                try
                {
                    DataTable Dt_Ref_Client_Testimonials_SelectAll = SERClient.SERV_Ref_Client_Testimonials_SelectAll();
                    GVClient.DataSource = Dt_Ref_Client_Testimonials_SelectAll;
                    GVClient.DataBind();


                    DataTable PL_Ref_Client_Testimonials_Wise_Guest_Selected = SERClient.SERV_Ref_Client_Testimonials_Wise_Guest_Selected(DECClient);
                    if (PL_Ref_Client_Testimonials_Wise_Guest_Selected.Rows.Count != 0)
                    {

                        foreach (DataRow DR_Ref_Client_Testimonials_Wise_Guest_Selected in PL_Ref_Client_Testimonials_Wise_Guest_Selected.Rows)
                        {
                            int rowIndexCit = 0;
                            foreach (GridViewRow gr in GVBangalow.Rows)
                            {
                                CheckBox cbGen2 = (CheckBox)gr.Cells[2].FindControl("ChkBang");

                                if (GVBangalow.Rows[rowIndexCit].Cells[0].Text.ToString().Trim() == DR_Ref_Client_Testimonials_Wise_Guest_Selected[0].ToString().Trim())
                                {
                                    if (cbGen2.Checked != true)
                                    {
                                        cbGen2.Checked = true;
                                    }
                                }
                                rowIndexCit++;
                            }
                        }
                    }

                }
                catch
                {
                    Label3.Text = "There was an error updating this record";
                    return;
                }
            }
            else
            {
                Response.Write(res);
            }
        }
        catch
        {
        }

    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            DECClient.Client_Test_Id = Label1.Text.Trim();

            string res = "";
            res = SERClient.SERV_Ref_Client_Testimonials_Delete(DECClient);
            if (res.Trim() == "1")
            {
                Response.Write("OK !");


                DataTable Dt_Ref_Client_Testimonials_SelectAll = SERClient.SERV_Ref_Client_Testimonials_SelectAll();
                GVClient.DataSource = Dt_Ref_Client_Testimonials_SelectAll;
                GVClient.DataBind();

                DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
                GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
                GVBangalow.DataBind();
            }
            else
            {
                Response.Write(res);
            }
        }
        catch
        {
            Label3.Text = "There was an Error Deleting this Image";
        }
    }
    protected void gvCityUp0_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}