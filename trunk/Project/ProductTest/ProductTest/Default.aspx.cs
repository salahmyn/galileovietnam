﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ProductTest
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnaddnew_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UsingDataControls.aspx");
        }

        protected void lbncapnhatvitri_Click(object sender, EventArgs e)
        {

        }
    }
}