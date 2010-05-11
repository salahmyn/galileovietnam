﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using ShipBooking.Controls;

namespace ShipBooking
{
    public partial class Admin_Functions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (LoginControl.bLogin == false)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                LinkButton lbtnThoat = (LinkButton)Master.FindControl("lbtnDangNhap");
                lbtnThoat.Text = "Thoát";
            }
        }

        protected void btnAdminBF_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_BookingFile.aspx");
        }

        protected void btnAdminSegment_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }
    }
}
