﻿using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace ShipBooking
{
    public class HanhTrinh
    {
        string _MaHanhTrinh;
        public string MaHanhTrinh
        {
            get { return _MaHanhTrinh; }
            set { _MaHanhTrinh = value; }
        }

        string _MaChang;
        public string MaChang
        {
            get { return _MaChang; }
            set { _MaChang = value; }
        }

        string _SoHieuChuyenTau;
        public string SoHieuChuyenTau
        {
            get { return _SoHieuChuyenTau; }
            set { _SoHieuChuyenTau = value; }
        }

        DateTime _GioKhoiHanh;
        public DateTime GioKhoiHanh
        {
            get { return _GioKhoiHanh; }
            set { _GioKhoiHanh = value; }
        }

        DateTime _GioDen;
        public DateTime GioDen
        {
            get { return _GioDen; }
            set { _GioDen = value; }
        }

        string _NgayDen;
        public string NgayDen
        {
            get { return _NgayDen; }
            set { _NgayDen = value; }
        }

        string _NgayTrongTuan;
        public string NgayTrongTuan
        {
            get { return _NgayTrongTuan; }
            set { _NgayTrongTuan = value; }
        }

        int _SoGhe;
        public int SoGhe
        {
            get { return _SoGhe; }
            set { _SoGhe = value; }
        }

        int _GiaVeNguoiLon1;
        public int GiaVeNguoiLon1
        {
            get { return _GiaVeNguoiLon1; }
            set { _GiaVeNguoiLon1 = value; }
        }

        int _GiaVeNguoiLon2;
        public int GiaVeNguoiLon2
        {
            get { return _GiaVeNguoiLon2; }
            set { _GiaVeNguoiLon2 = value; }
        }

        int _GiaVeNguoiLon3;
        public int GiaVeNguoiLon3
        {
            get { return _GiaVeNguoiLon3; }
            set { _GiaVeNguoiLon3 = value; }
        }

        int _GiaVeTreEm1;
        public int GiaVeTreEm1
        {
            get { return _GiaVeTreEm1; }
            set { _GiaVeTreEm1 = value; }
        }

        int _GiaVeTreEm2;
        public int GiaVeTreEm2
        {
            get { return _GiaVeTreEm2; }
            set { _GiaVeTreEm2 = value; }
        }

        int _GiaVeTreEm3;
        public int GiaVeTreEm3
        {
            get { return _GiaVeTreEm3; }
            set { _GiaVeTreEm3 = value; }
        }

        int _SoLuongVe1;
        public int SoLuongVe1
        {
            get { return _SoLuongVe1; }
            set { _SoLuongVe1 = value; }
        }

        int _SoLuongVe2;
        public int SoLuongVe2
        {
            get { return _SoLuongVe2; }
            set { _SoLuongVe2 = value; }
        }

        int _SoLuongVe3;
        public int SoLuongVe3
        {
            get { return _SoLuongVe3; }
            set { _SoLuongVe3 = value; }
        }
        
    }
}
