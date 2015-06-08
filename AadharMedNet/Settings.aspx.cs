using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AadharMedNet
{
    /// <summary>
    /// This form handles user profile settings
    /// </summary>
    /// <Remarks>
    /// Currently for the prototype files are used for storing information. In production database will be used
    /// </Remarks>
    /// 

    public partial class Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadBtnY_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBtnY.Checked == true)
            {
                RadBtnN.Checked = false;
            }
        }

        protected void RadBtnN_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBtnN.Checked == true)
            {
                RadBtnY.Checked = false;
            }
        }
      
    }
}