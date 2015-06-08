using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AadharMedNet
{
    /// <summary>
    /// This form provides searching interface. You can search for doctors, donors etc. or you can specify a keyword and search
    /// </summary>
    /// <Remarks>
    /// Currently for the prototype files are used for storing information. In production database will be used
    /// </Remarks>
    /// 

    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void BtnSrch_Click(object sender, EventArgs e)
        {
            string[][] userDetails;
            PnlSrchFltr.Visible = false;
            PnlSrchRslts.Visible = true;

            AadharMedNetSearchBase searchBase = new AadharMedNetSearchBase();

            if (TxtBxKyWrd.Text != "")
            {
                searchBase.UserDetailPath = Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt");
                userDetails = searchBase.SearchByKeywords(TxtBxKyWrd.Text, Server.MapPath(@"App_Data\AadharMedNetMedServiceProvider.txt"));

                if (userDetails.GetLength(0) == 0)
                {
                    if (CmbBxFr.SelectedIndex == 1)
                    {
                        searchBase.UserDetailPath = Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt");
                        userDetails = searchBase.searchByCategory(1, searchBase.UserDetailPath);

                        LnkBtn.Text = userDetails[0][0];
                        Session["searchUser"] = LnkBtn.Text;
                    }
                    else if (CmbBxFr.SelectedIndex == 2)
                    {
                        searchBase.UserDetailPath = Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt");
                        userDetails = searchBase.searchByCategory(4, searchBase.UserDetailPath);

                        LnkBtn.Text = userDetails[0][0];
                        Session["searchUser"] = LnkBtn.Text;
                    }
                    else if (CmbBxFr.SelectedIndex == 3)
                    {
                        searchBase.UserDetailPath = Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt");
                        userDetails = searchBase.searchByCategory(3, searchBase.UserDetailPath);

                        LnkBtn.Text = userDetails[0][0];
                        Session["searchUser"] = LnkBtn.Text;
                    }
                    else if (CmbBxFr.SelectedIndex == 4)
                    {
                        searchBase.UserDetailPath = Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt");
                        userDetails = searchBase.searchByCategory(6, searchBase.UserDetailPath);

                        LnkBtn.Text = userDetails[0][0];
                        Session["searchUser"] = LnkBtn.Text;
                    }
                    else if (CmbBxFr.SelectedIndex == 5)
                    {
                        searchBase.UserDetailPath = Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt");
                        userDetails = searchBase.searchByCategory(5, searchBase.UserDetailPath);

                        LnkBtn.Text = userDetails[0][0];
                        Session["searchUser"] = LnkBtn.Text;
                    }
                }
                else
                {
                    LnkBtn.Text = userDetails[0][0];
                    Session["searchUser"] = LnkBtn.Text;
                }
            }
            else
            {
                if (CmbBxFr.SelectedIndex == 1)
                {
                    searchBase.UserDetailPath = Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt");
                    userDetails = searchBase.searchByCategory(1, searchBase.UserDetailPath);

                    LnkBtn.Text = userDetails[0][0];
                    Session["searchUser"] = LnkBtn.Text;
                }
                else if (CmbBxFr.SelectedIndex == 2)
                {

                    searchBase.UserDetailPath = Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt");
                    userDetails = searchBase.searchByCategory(4, searchBase.UserDetailPath);

                    LnkBtn.Text = userDetails[0][0];
                    Session["searchUser"] = LnkBtn.Text;
                }
                else if (CmbBxFr.SelectedIndex == 3)
                {
                    searchBase.UserDetailPath = Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt");
                    userDetails = searchBase.searchByCategory(3, searchBase.UserDetailPath);

                    LnkBtn.Text = userDetails[0][0];
                    Session["searchUser"] = LnkBtn.Text;
                }
                else if (CmbBxFr.SelectedIndex == 4)
                {
                    searchBase.UserDetailPath = Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt");
                    userDetails = searchBase.searchByCategory(6, searchBase.UserDetailPath);

                    LnkBtn.Text = userDetails[0][0];
                    Session["searchUser"] = LnkBtn.Text;
                }
                else if (CmbBxFr.SelectedIndex == 5)
                {
                    searchBase.UserDetailPath = Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt");
                    userDetails = searchBase.searchByCategory(5, searchBase.UserDetailPath);

                    LnkBtn.Text = userDetails[0][0];
                    Session["searchUser"] = LnkBtn.Text;
                }
            }

        }



        //searchBase.UserDetailPath = Server.MapPath(
        //string[][] userDetaials = 


        protected void LnkBtn_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.open('Viewer.aspx','_blank');</script>");
        }

    }
}