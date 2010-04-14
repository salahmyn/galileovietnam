﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DatVe_Step2.ascx.cs" Inherits="ShipBooking.Controls.DatVe_Step2" %>

<style type="text/css">
    .tblThongTinDatCho_Summary_Style
    {
        margin: auto;
        border: 1px solid #006699;
        width: 800px;
        height: auto;
    }
    .tblThongTinDatCho_Detail_Style
    {
        margin: auto;
        border-style: none;
        width: 600px;
        height: auto;
    }
    .table_header_style
    {
        color: #FFFFFF;
        font-weight: bold;
        font-family: Arial, Helvetica, sans-serif;
    }
    .table_contain_style
    {
        border: 1px solid #006699;
    }
    .ThongTinDatCho_Title_1
    {
        width: 100px;
        text-align: left;
    }
    .ThongTinDatCho_Detail
    {
        width: 200px;
    }
    .ThongTinDatCho_Title_2
    {
        width: 170px;
        text-align: left;
    }
</style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="59px" 
        ImageUrl="~/Images/text_banvetau.png" Width="600px" />
    <br />
</p>
<table class="tblThongTinDatCho_Summary_Style">
    <tr>
        <td bgcolor="#006699" class="table_header_style">
            Thông tin đặt chỗ</td>
    </tr>
    <tr>
        <td class="table_contain_style">
            <table class="tblThongTinDatCho_Detail_Style">
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Từ:</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#0000CC" 
                            Text="TP Hồ Chí Minh"></asp:Label>
                    </td>
                    <td class="ThongTinDatCho_Title_2">
                        Đến:</td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="#0000CC" 
                            Text="TP Hồ Chí Minh"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Từ:</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#0000CC" 
                            Text="TP Hồ Chí Minh"></asp:Label>
                    </td>
                    <td class="ThongTinDatCho_Title_2">
                        Đến:</td>
                    <td>
                        <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#0000CC" 
                            Text="TP Hồ Chí Minh"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Ngày khởi hành:</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#0000CC" 
                            Text="TP Hồ Chí Minh"></asp:Label>
                    </td>
                    <td class="ThongTinDatCho_Title_2">
                        Ngày về:</td>
                    <td>
                        <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="#0000CC" 
                            Text="TP Hồ Chí Minh"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Loại vé:</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#0000CC" 
                            Text="TP Hồ Chí Minh"></asp:Label>
                    </td>
                    <td class="ThongTinDatCho_Title_2">
                        Giá cho người Việt Nam:</td>
                    <td>
                        <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="#0000CC" 
                            Text="TP Hồ Chí Minh"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        </td>
                    <td class="ThongTinDatCho_Detail">
                    </td>
                    <td class="ThongTinDatCho_Title_2">
                        Giá cho người nước ngoài:</td>
                    <td>
                        <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="#0000CC" 
                            Text="TP Hồ Chí Minh"></asp:Label>
                    </td>
                </tr>
            </table>
            </td>
    </tr>
</table>
<p style="text-align: center">
    <asp:Label ID="Label10" runat="server" 
        Text="Ghi chú: Giá trên chưa bao gồm phí cảng"></asp:Label>
</p>


<asp:GridView ID="GridView1" runat="server" Width="800px" 
    AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
    BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="71px">
    <FooterStyle BackColor="White" ForeColor="#000066" />
    <RowStyle ForeColor="#000066" />
    <Columns>
        <asp:BoundField DataField="stt" HeaderText="STT" />
        <asp:BoundField DataField="TenKhach" HeaderText="Tên khách" />
        <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ" />
        <asp:BoundField DataField="LoaiQuocTich" HeaderText="VN/Nước ngoài" />
        <asp:BoundField DataField="LoaiTuoi" HeaderText="Tuổi" />
        <asp:BoundField DataField="GiaVe" HeaderText="Giá vé" />
    </Columns>
    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
</asp:GridView>



<p style="text-align: center">
    <asp:LinkButton ID="LinkButton1" runat="server">Thêm hoặc sửa danh sách khách</asp:LinkButton>
</p>
<table class="tblThongTinDatCho_Summary_Style">
    <tr>
        <td bgcolor="#006699" class="table_header_style">
            Thông tin để giao vé</td>
    </tr>
    <tr>
        <td class="table_contain_style">
            <table class="tblThongTinDatCho_Detail_Style">
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Tên người nhận vé</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:TextBox ID="TextBox1" runat="server" Width="279px"></asp:TextBox>
                        &nbsp;<span class="warning_text">(*)</span></td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Địa chỉ</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:TextBox ID="TextBox2" runat="server" Width="279px" Height="100px" 
                            TextMode="MultiLine"></asp:TextBox>
                    &nbsp;<span class="warning_text">(*)</span></td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Tỉnh/Thành phố</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="166px">
                        </asp:DropDownList>
                    &nbsp;<span class="warning_text">(*)</span></td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Điện thoại</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:TextBox ID="TextBox3" runat="server" Width="163px"></asp:TextBox>
&nbsp;<span class="warning_text">(*)</span></td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Email</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:TextBox ID="TextBox5" runat="server" Width="279px"></asp:TextBox>
&nbsp;<span class="warning_text">(*)</span></td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Các yêu cầu khác (nếu có)</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:TextBox ID="TextBox6" runat="server" Width="279px" Height="100px" 
                            TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Thời gian giao vé</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:DropDownList ID="DropDownList2" runat="server" Width="162px">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
            </td>
    </tr>
</table>



<br />
<table class="tblThongTinDatCho_Summary_Style">
    <tr>
        <td bgcolor="#006699" class="table_header_style">
            Hình thức thanh toán</td>
    </tr>
    <tr>
        <td class="table_contain_style">
            <table class="tblThongTinDatCho_Detail_Style">
                <tr>
                    <td class="ThongTinDatCho_Detail">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem Value="VanPhongDaiLy">Tại văn phòng đại lý</asp:ListItem>
                            <asp:ListItem Value="KhiGiaoVe">Thanh toán khi giao ve</asp:ListItem>
                            <asp:ListItem Value="TheTinDung">Thanh toán bằng thẻ tín dụng</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                </table>
            </td>
    </tr>
</table>
<br />
<div style="text-align: center">
    <asp:Button ID="Button1" runat="server" Text="Tiếp tục" 
        onclick="Button1_Click" />
</div>
<p>
    &nbsp;</p>






