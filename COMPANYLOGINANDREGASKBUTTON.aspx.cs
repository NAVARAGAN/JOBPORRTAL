﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JOBPORTALPROJECTDOWNLOADED
{
    public partial class COMPANYLOGINANDREGASKBUTTON : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("COMPANYLOGIN.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("COMPANY REGISTER.aspx");

        }
    }
}