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

public partial class SignUp : System.Web.UI.Page
{
    DECVariables.ClsUse Du =new DECVariables.ClsUse();
    SERUsers Su = new SERUsers();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnSignUp_Click(object sender, EventArgs e)
    {
        
        try
        {
            Du.Password = TextBox2.Text;
            Du.UserName = TextBox1.Text;
            Label1.Text = "";
            DataTable PL_Ref_Users_Select_All = Su.SERV_Ref_Users_Select_All();
            if (PL_Ref_Users_Select_All.Rows.Count > 0)
            {
                foreach (DataRow DR_Ref_Users_Select_All in PL_Ref_Users_Select_All.Rows)
                {
                    string str=Cryptography.EncryptDecrypt.Decrypt(DR_Ref_Users_Select_All[1].ToString().Trim());
                    if (TextBox1.Text.ToString().Trim() == DR_Ref_Users_Select_All[0].ToString().Trim().ToString())
                    {
                        Label1.Text = Du.UserName + " Already Exists";
                        return;
                    }               

                }

                

            }

            Du.Password = Cryptography.EncryptDecrypt.Encrypt(TextBox2.Text.Trim());
            Du.UserName = TextBox1.Text.ToString();
            string res = "";
            res = Su.SERV_Ref_Users_Insert(Du);
            

        }
        catch
        {
            Label1.Text = "there was an error try again";
        }
    }
}