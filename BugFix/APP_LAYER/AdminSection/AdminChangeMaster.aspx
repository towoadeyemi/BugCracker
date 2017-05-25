<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminChangeMaster.aspx.cs" Inherits="BugFix.APP_LAYER.AdminSection.AdminChangeMaster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>

       
    <div style="width:100%; height:300px;">
        <table style="width:50%; height:90%; text-align:left;">
            <tr>
                <td style="width:30% ">
                    Post Title:<td style="width:70%; text-align:center; ">

                    <asp:TextBox ID="txt_PostTitle" runat="server" style="border-radius:4px;" Height="32px" Width="604px"></asp:TextBox>

                </td>
            </tr>

             <tr>
                <td >
                    Post Code:<td style="width:70%; text-align:center; ">

                     <asp:TextBox ID="TextBox2" runat="server" style="border-radius:4px;" Height="32px" Width="603px"></asp:TextBox>

                </td>
            </tr>

             <tr>
                <td style="width:70%; ">
                    Upload File<td style="width:70%; text-align:center;">

                     <asp:FileUpload ID="FileUpload_HTXT" runat="server" Height="31px" Width="356px" style="border-radius:4px; margin-left: 0px;" />

                </td>
            </tr>

             <tr>
                <td colspan="2" style=" text-align:center;">
                   

                     <asp:Button ID="Button1" runat="server" Text="Save" Width="142px" style="background-color:#6bc5d0;color:white;" Height="35px" OnClick="Button1_Click" />

                </td>
            </tr>
        </table>
    

    </div> 

        </center>
    </form>
  
</body>
</html>
