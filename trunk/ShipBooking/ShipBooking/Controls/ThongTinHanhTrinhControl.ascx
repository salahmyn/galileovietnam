﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThongTinHanhTrinhControl.ascx.cs" Inherits="ShipBooking.Controls.ThongTinHanhTrinhControl" %>

<script type="text/javascript">
    function displayCalendar1()
    {
        var datePicker = document.getElementById('datePicker1');
        datePicker.style.display = 'block';
    }
    
    function displayCalendar2()
    {
        var datePicker = document.getElementById('datePicker2');
        datePicker.style.display = 'block';
    }
</script><style type="text/css">
    .step1_tblThongTinDatCho_Summary_Style
    {
        margin: auto;
        border: 1px solid #006699;
        width: 800px;
        height: auto;
    }
    .step1_table_header_style
    {
        color: #FFFFFF;
        font-weight: bold;
        font-family: Arial, Helvetica, sans-serif;
    }
    .step1_table_contain_style
    {
        border: 1px solid #006699;
    }
    .step1_tblThongTinDatCho_Detail_Style
    {
        margin: auto;
        border-style: none;
        width: 475px;
        height: auto;
    }
    .style2
    {
        width: 181px;
    }
    
    #datePicker1
    {
        display:none;
        position:absolute;
        border:solid 2px black;
        background-color:white;
    }
    #datePicker2
    {
        display:none;
        position:absolute;
        border:solid 2px black;
        background-color:white;
    }
    #imgCalendar2
    {
        height: 16px;
    }
             .style3
             {
                 text-align: right;
                 width: 51px;
             }
             .style4
             {
                 text-align: right;
                 width: 109px;
             }
    </style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="59px" 
        ImageUrl="~/Images/tim_kiem_hanh_trinh.png" Width="515px" />
</p>
<p style="text-align: center">
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    <br />
</p>
<table class="step1_tblThongTinDatCho_Summary_Style">
    <tr>
        <td bgcolor="#006699" class="step1_table_header_style">
            Thông tin tìm kiếm</td>
    </tr>
    <tr>
        <td class="step1_table_contain_style">
            <table class="step1_tblThongTinDatCho_Detail_Style">
                <tr>
                    <td class="style3">
                                                &nbsp;</td>
                    <td class="style2">
                        <asp:RadioButtonList ID="rblLoaiHanhTrinh" runat="server" Height="22px" 
                            Width="162px" AutoPostBack="true" 
                            onselectedindexchanged="rblLoaiHanhTrinh_SelectedIndexChanged">
                        </asp:RadioButtonList>
                        </td>
                    <td class="style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style3">
                                                Từ:</td>
                    <td class="style2">
                        <asp:DropDownList ID="ddlNoiDi" runat="server" Height="22px" Width="160px" 
                            AutoPostBack="true" onselectedindexchanged="ddlNoiDi_SelectedIndexChanged">
                        </asp:DropDownList>
                        </td>
                    <td class="style4">
                        Ngày khởi hành:</td>
                    <td>
                        <asp:TextBox ID="txtNgayDi" runat="server" Width="79px" 
                            style="text-align: right"></asp:TextBox>
                        <img id="imgCalendar1" src="~/Images/CalendarIcon.png" alt="" runat="server" 
                            onclick="displayCalendar1()" height="16" />
                        <div id="datePicker1">
                            <asp:Calendar id="calEventDate" 
                                OnSelectionChanged="calEventDate_SelectionChanged" Runat="server" 
                                BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" 
                                DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" 
                                ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px" >
                                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                <SelectorStyle BackColor="#FFCC66" />
                                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                                <OtherMonthDayStyle ForeColor="#CC9966" />
                                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                                    ForeColor="#FFFFCC" />
                            </asp:Calendar>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Đến:</td>
                    <td class="style2">
                        
                        <asp:DropDownList ID="ddlNoiDen" runat="server" Height="22px" Width="160px" >
                        </asp:DropDownList>
                    </td>
                    <td class="style4">
                        <asp:Label ID="lblNgayVe" runat="server" Visible="false" Text="Ngày về:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNgayVe" runat="server" Width="79px" Visible="False" 
                            style="text-align: right"></asp:TextBox>
                        <img id="imgCalendar2" src="~/Images/CalendarIcon.png" alt="" runat="server" 
                            onclick="displayCalendar2()" height="16" visible="False"/>
                        <div id="datePicker2">
                            <asp:Calendar id="Calendar1" Runat="server" BackColor="#FFFFCC" 
                                BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
                                Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" 
                                ShowGridLines="True" Width="220px" 
                                onselectionchanged="Calendar1_SelectionChanged" >
                                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                <SelectorStyle BackColor="#FFCC66" />
                                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                                <OtherMonthDayStyle ForeColor="#CC9966" />
                                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                                    ForeColor="#FFFFCC" />
                            </asp:Calendar>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td class="style2">
                        
                        &nbsp;</td>
                    <td class="style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                </table>
            </td>
    </tr>
</table>
<p style="text-align: center">
    <asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" Width="100px" 
        onclick="btnSearch_Click" style="height: 26px" />
</p>
<p style="text-align: center">
    &nbsp;</p>

