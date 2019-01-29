<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
           <table width="90%">
               <tr>
                   <td>
                       <asp:Label ID="lblNumber" runat="server" Text="Enter Number:"></asp:Label> &nbsp;
                   </td>
                   <td>
                       <asp:TextBox ID="txtNumberForEven" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="rfvtxtNumber" runat="server" ForeColor="Red" ControlToValidate="txtNumberForEven"
                            ValidationGroup="EvenNo"
                            ErrorMessage="Please enter a number"></asp:RequiredFieldValidator>
                   </td>
                   <td>
                      <asp:Button ID="btnGetAllEvenNo" runat="server" ValidationGroup="EvenNo" 
                           Text="Get Even Numbers" onclick="btnGetAllEvenNo_Click" />
                   </td>
               </tr>
               <tr>
                   <td>
                   </td>
                   <td colspan="2">
                       <%--<asp:Label ID="lblEvenNumbers" runat="server" Text=""></asp:Label> &nbsp;--%>
                       <asp:TextBox ID="txtEvenNumbers" Height="100px" Width="100%" ReadOnly="true" TextMode="MultiLine" runat="server"></asp:TextBox>
                   </td>
               </tr>
           <tr><td colspan="3">&nbsp;</td></tr>
               <tr><td colspan="3">&nbsp;</td></tr>
               <tr><td colspan="3">&nbsp;</td></tr>
               <tr>
                   <td>
                       <asp:Label ID="lblEnterNoFor7" runat="server" Text="Enter Number:"></asp:Label> &nbsp;
                   </td>
                   <td>
                       <asp:TextBox ID="txtNumberFor7Div" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="rfvtxtNumberFor7Div" runat="server" ForeColor="Red"
                            ControlToValidate="txtNumberFor7Div"  ValidationGroup="DivbySevenNo"
                            ErrorMessage="Please enter a number"></asp:RequiredFieldValidator>
                   </td>
                   <td>
                        <asp:Button ID="btnGetAllNoDivby7" runat="server" ValidationGroup="DivbySevenNo" 
                           Text="Get Numbers divisible by 7" onclick="btnGetAllNoDivby7_Click" />
                   </td>
               </tr>
               <tr>
                   <td>
                      
                   </td>
                   <td colspan="2">
                       <%--<asp:Label ID="lblNoDivBy7" runat="server" Text=""></asp:Label> &nbsp;--%>
                       <asp:TextBox ID="txtNoDivBy7" Height="100px" Width="100%" ReadOnly="true" TextMode="MultiLine" runat="server"></asp:TextBox>
                   </td>
               </tr>
           </table>
    </div>
        
    </form>
</body>
</html>
