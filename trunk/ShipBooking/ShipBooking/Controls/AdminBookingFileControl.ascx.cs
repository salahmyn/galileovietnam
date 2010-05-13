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
using System.Web.UI.MobileControls;
using ShipBooking.Module;
using System.Collections.Generic;

namespace ShipBooking.Controls
{
    public partial class AdminBookingFileControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitControl();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string startdate = "";
            string enddate = "";
            startdate = txtNgay1.Text.Trim();
            enddate = txtNgay2.Text.Trim();

            if (rblTieuChiTimKiem.SelectedValue == "TenKhach")
            {
                if (CheckValidDate(startdate) == true && CheckValidDate(enddate) == true)
                {
                    DateTime dt = DateTime.Parse(enddate);
                    if (dt < DateTime.Parse(startdate))
                    {
                        lblMsg.Text = "Lỗi nhập liệu: Ngày kết thúc phải sau ngày bắt đầu";
                        return;
                    }
                    else
                    {
                        SearchBFByKhach(txtKeyword.Text.Trim(), startdate, enddate);
                    }
                }
                else if (CheckValidDate(startdate) == false && CheckValidDate(enddate) == true)
                {
                    txtNgay1.Text = "";
                    txtNgay1.Focus();
                }
                else if (CheckValidDate(startdate) == true && CheckValidDate(enddate) == false)
                {
                    txtNgay2.Text = "";
                    txtNgay2.Focus();
                }
                else
                {
                    txtNgay1.Text = "";
                    txtNgay1.Focus();
                }
            }
            else if (rblTieuChiTimKiem.SelectedValue == "MaBF")
            {
                SearchBFByID(txtKeyword.Text.Trim());
            }
            else
            {
                //Search by nguoi nhan ve
            }
        }

        protected void calEventDate_SelectionChanged(object sender, EventArgs e)
        {
            txtNgay1.Text = calStartDate.SelectedDate.ToString("d");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtNgay2.Text = calEndDate.SelectedDate.ToString("d");
        }

        protected void SearchBFByID(string keyword)
        {
            BookingFile bf = new BookingFile();
            bf = BookingFileDB.GetInfo(keyword);

            List<HanhKhach> khach = new List<HanhKhach>();
            khach = HanhKhachDB.GetListHanhKhachByBookingID(keyword);

            if (bf != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MaBF");
                dt.Columns.Add("Ten");
                dt.Columns.Add("LoaiChuyen");
                dt.Columns.Add("NoiDi");
                dt.Columns.Add("NoiDen");
                dt.Columns.Add("NgayDi");
                dt.Columns.Add("NgayVe");
                dt.Columns.Add("ThoiGian");
                dt.Columns.Add("LoaiVe");
                dt.Columns.Add("GiaTien");
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                ds.Tables[0].Rows.Add();
                ds.Tables[0].Rows[0].SetField("MaBF", bf.MaBF.Trim());
                ds.Tables[0].Rows[0].SetField("Ten", khach[0].Ten.Trim());
                ds.Tables[0].Rows[0].SetField("LoaiChuyen", bf.LoaiChuyen.Trim());
                ds.Tables[0].Rows[0].SetField("NoiDi", bf.NoiDi.Trim());
                ds.Tables[0].Rows[0].SetField("NoiDen", bf.NoiDen.Trim());
                ds.Tables[0].Rows[0].SetField("NgayDi", bf.NgayDi.ToShortDateString());
                ds.Tables[0].Rows[0].SetField("NgayVe", bf.NgayVe.ToShortDateString());
                ds.Tables[0].Rows[0].SetField("ThoiGian", bf.ThoiGian.Trim());
                ds.Tables[0].Rows[0].SetField("LoaiVe", bf.LoaiVe.Trim());
                ds.Tables[0].Rows[0].SetField("GiaTien", bf.GiaTien.Trim());

                grwResult.DataSource = ds.Tables[0];
                grwResult.DataBind();
            }
            else
            {
                grwResult.DataSource = null;
                grwResult.DataBind();
                lblResult.Text = "Rất tiếc! Không tìm thấy kết quả nào.";
            }
        }

        protected void SearchBFByKhach(string keyword, string stardate, string enddate)
        {
            DataSet ds = new DataSet();
            DateTime dt;
            ds = BookingFileDB.GetDataSetBookingFileByTenKhach(keyword, stardate, enddate);
            grwResult.DataSource = ds.Tables[0];
            grwResult.DataBind();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dt = DateTime.Parse(ds.Tables[0].Rows[i]["NgayDi"].ToString().Trim());
                grwResult.Rows[i].Cells[4].Text = dt.Month + "/" + dt.Day + "/" + dt.Year;

                dt = DateTime.Parse(ds.Tables[0].Rows[i]["NgayVe"].ToString().Trim());
                grwResult.Rows[i].Cells[5].Text = dt.Month + "/" + dt.Day + "/" + dt.Year;
            }
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblResult.Text = "Rất tiếc! Không tìm thấy kết quả nào.";
            }
            else
            {
                lblResult.Text = "Có " + ds.Tables[0].Rows.Count.ToString() + " kết quả tìm được:";
            }
        }

        protected void SearchBFByNguoiNhan(string keyword)
        {
 
        }

        protected bool CheckValidDate(string strDate)
        {
            bool isValid = false;
            try
            {
                DateTime dt = DateTime.Parse(strDate);
                isValid = true;
            }
            catch
            {
                lblMsg.Text = "Ngày không hợp lệ";
                isValid = false;
            }

            return isValid;
        }

        protected void InitControl()
        {
            lblResult.Text = "";
            lblMsg.Text = "";
            txtKeyword.Text = "";
            txtNgay1.Text = "";
            txtKeyword.Text = "";
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Functions.aspx");
        }
    }
}