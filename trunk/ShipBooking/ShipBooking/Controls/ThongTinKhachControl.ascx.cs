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
using ShipBooking.Module;
using System.Collections.Generic;

namespace ShipBooking.Controls
{
    public partial class ThongTinKhachControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitControl();
                FillBookingData();
                SetVisibleHanhKhachDataControl();
            }
        }

        protected void FillBookingData()
        {
            lblLoaiHanhTrinh.Text = ThongTinHanhTrinhControl.bf.LoaiChuyen;
            lblNoiDi.Text = ThongTinHanhTrinhControl.bf.NoiDi;
            lblNoiDen.Text = ThongTinHanhTrinhControl.bf.NoiDen;
            lblNgayDi.Text = ThongTinHanhTrinhControl.bf.NgayDi.ToShortDateString();
            if (ThongTinHanhTrinhControl.bf.LoaiChuyen == "Khứ hồi")
            {
                lblNgayVeLabel.Visible = true;
                lblNgayVe.Visible = true;
                lblNgayVe.Text = ThongTinHanhTrinhControl.bf.NgayVe.ToShortDateString();
            }
            else
            {
                lblNgayVeLabel.Visible = false;
                lblNgayVe.Visible = false;
            }
            lblGioKhoiHanh.Text = ThongTinHanhTrinhControl.bf.GioKhoiHanh.ToShortTimeString();
            lblGioDen.Text = ThongTinHanhTrinhControl.bf.GioDen.ToShortTimeString();
            lblLoaiVe.Text = ThongTinHanhTrinhControl.bf.LoaiVe;
            lblSLVe.Text = ThongTinHanhTrinhControl.bf.SoVe;
            lblSoGhe.Text = ThongTinHanhTrinhControl.bf.SoGhe;
            
        }

        protected void GetHanhKhachData()
        {
            int slKhach = 0;
            string maHK = "";
            string strTextBoxID = "";
            string strDdlID = "";
            TextBox[] textBox = new TextBox[100];
            DropDownList[] ddl = new DropDownList[100];
            HanhKhach khach;
            
            slKhach = Convert.ToInt16(ThongTinHanhTrinhControl.bf.SoVe);
            ThongTinHanhTrinhControl.listKhach = new List<HanhKhach>();
            for (int i = 1; i <= slKhach; i++)
            {
                strTextBoxID = "txtHoTen" + i.ToString();
                strDdlID = "ddlDoTuoi" + i.ToString();
                textBox[i] = (TextBox)this.FindControl(strTextBoxID);
                ddl[i] = (DropDownList)this.FindControl(strDdlID);
                if (textBox[i] != null && ddl[i] != null)
                {
                    khach = new HanhKhach();
                    khach.MaHK = TaoMaHK(textBox[i].Text.Trim());
                    khach.Ten = textBox[i].Text.Trim();
                    khach.DiaChi = "";
                    khach.QuocTich = "";
                    khach.DoTuoi = ddl[i].SelectedItem.Text.Trim();
                    khach.DienThoai = "";
                    khach.Email = "";
                    khach.MaBF = "";
                    khach.GiaTien = TinhGiaVe(ddl[i].SelectedValue.Trim());
                    ThongTinHanhTrinhControl.listKhach.Add(khach);
                    khach = null;
                }
            }
        }

        protected void InitControl()
        {
            Panel [] panel = new Panel[15];
            string control = "";
            for (int i = 1; i <= 12; i++)
            {
                control = "Panel" + i.ToString();
                panel[i] = (Panel)this.FindControl(control);
                if (panel[i] != null)
                {
                    panel[i].Visible = false;
                }
            }
            lblMsg.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckValidData() == false)
            {
                return;
            }
            else
            {
                GetHanhKhachData();
                TinhTongTien();
                Response.Redirect("DatVe_Step2.aspx");
            }
        }

        protected bool CheckValidData()
        {
            bool isValid = false;
            int slKhach = Convert.ToInt16(ThongTinHanhTrinhControl.bf.SoVe);
            TextBox[] textBox = new TextBox[15];
            string control = "";
            for (int i = 1; i <= slKhach; i++)
            {
                control = "txtHoTen" + i.ToString();
                textBox[i] = (TextBox)this.FindControl(control);
                if (textBox[i] != null)
                {
                    if (textBox[i].Text.Trim() == "")
                    {
                        lblMsg.Text = "Bạn phải nhập họ tên";
                        textBox[i].Focus();
                        isValid = false;
                        return isValid;
                    }
                    else
                    {
                        isValid = true;
                    }
                }
            }   
            return isValid;
        }

        protected void SetVisibleHanhKhachDataControl()
        {
            int slKhach = Convert.ToInt16(ThongTinHanhTrinhControl.bf.SoVe);
            Panel[] panel = new Panel[100];
            string control = "";
            for (int i = 1; i <= slKhach; i++)
            {
                control = "Panel" + i.ToString();
                panel[i] = (Panel)this.FindControl(control);
                if (panel[i] != null)
                {
                    panel[i].Visible = true;
                }
            }
        }

        protected string TinhGiaVe(string dotuoikhach)
        {
            string strGiave = "";
            if (ThongTinHanhTrinhControl.bf.LoaiChuyen == "Khứ hồi")
            {
                long giamgia = 0;
                long giave = 0;
                if (ThongTinHanhTrinhControl.bf.LoaiVe == "Hạng thường")
                {
                    if (dotuoikhach == "TreSoSinh")
                    {
                        try
                        {
                            giave = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiaVeTreEm1.Trim());
                            giamgia = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiamGiaKhuHoi.Trim());
                        }
                        catch
                        {
                            giamgia = 0;
                        }
                        giave = 2 * giave - giamgia;
                        strGiave = giave.ToString();
                    }
                    else
                    {
                        try
                        {
                            giave = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiaVeNguoiLon1.Trim());
                            giamgia = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiamGiaKhuHoi.Trim());
                        }
                        catch
                        {
                            giamgia = 0;
                        }
                        giave = 2 * giave - giamgia;
                        strGiave = giave.ToString();
                    }
                }
                else if (ThongTinHanhTrinhControl.bf.LoaiVe == "Hạng doanh nhân")
                {
                    if (dotuoikhach == "TreSoSinh")
                    {
                        try
                        {
                            giave = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiaVeTreEm2.Trim());
                            giamgia = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiamGiaKhuHoi.Trim());
                        }
                        catch
                        {
                            giamgia = 0;
                        }
                        giave = 2 * giave - giamgia;
                        strGiave = giave.ToString();
                    }
                    else
                    {
                        try
                        {
                            giave = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiaVeNguoiLon2.Trim());
                            giamgia = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiamGiaKhuHoi.Trim());
                        }
                        catch
                        {
                            giamgia = 0;
                        }
                        giave = 2 * giave - giamgia;
                        strGiave = giave.ToString();
                    }
                }
                else
                {
                    if (dotuoikhach == "TreSoSinh")
                    {
                        try
                        {
                            giave = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiaVeTreEm3.Trim());
                            giamgia = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiamGiaKhuHoi.Trim());
                        }
                        catch
                        {
                            giamgia = 0;
                        }
                        giave = 2 * giave - giamgia;
                        strGiave = giave.ToString();
                    }
                    else
                    {
                        try
                        {
                            giave = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiaVeNguoiLon3.Trim());
                            giamgia = Convert.ToInt64(SearchHanhTrinhResultControl.hanhtrinh.GiamGiaKhuHoi.Trim());
                        }
                        catch
                        {
                            giamgia = 0;
                        }
                        giave = 2 * giave - giamgia;
                        strGiave = giave.ToString();
                    }
                }
            }
            else
            {
                if (ThongTinHanhTrinhControl.bf.LoaiVe == "Hạng thường")
                {
                    if (dotuoikhach == "TreSoSinh")
                    {
                        strGiave = SearchHanhTrinhResultControl.hanhtrinh.GiaVeTreEm1;
                    }
                    else
                    {
                        strGiave = SearchHanhTrinhResultControl.hanhtrinh.GiaVeNguoiLon1;
                    }
                }
                else if (ThongTinHanhTrinhControl.bf.LoaiVe == "Hạng doanh nhân")
                {
                    if (dotuoikhach == "TreSoSinh")
                    {
                        strGiave = SearchHanhTrinhResultControl.hanhtrinh.GiaVeTreEm2;
                    }
                    else
                    {
                        strGiave = SearchHanhTrinhResultControl.hanhtrinh.GiaVeNguoiLon2;
                    }
                }
                else
                {
                    if (dotuoikhach == "TreSoSinh")
                    {
                        strGiave = SearchHanhTrinhResultControl.hanhtrinh.GiaVeTreEm3;
                    }
                    else
                    {
                        strGiave = SearchHanhTrinhResultControl.hanhtrinh.GiaVeNguoiLon3;
                    }
                }
            }
            return strGiave.Trim();
        }

        protected void TinhTongTien()
        {
            long sum = 0;
            for (int i = 0; i < ThongTinHanhTrinhControl.listKhach.Count; i++)
            {
                sum += Convert.ToInt64(ThongTinHanhTrinhControl.listKhach[i].GiaTien);
            }
            ThongTinHanhTrinhControl.bf.GiaTien = sum.ToString();
        }

        protected string TaoMaHK(string ten)
        {
            string mahk = "";
            Random rdm = new Random();

            mahk = ten.Substring(0, 2) + ten.Length.ToString() + rdm.Next(100, 999).ToString().Trim();
            return mahk;
        }
    }
}