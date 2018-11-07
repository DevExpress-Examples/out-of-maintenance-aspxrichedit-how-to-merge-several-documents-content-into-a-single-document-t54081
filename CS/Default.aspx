<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.ASPxRichEdit.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRichEdit" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v16.1, Version=16.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <script>
  function OnClick(s, e) {
   re.PerformCallback();
  }
 </script>
</head>
<body>
    <form id="form1" runat="server">
     <table>
      <tr>
       <td>
        Document 1:
        <dx:ASPxRichEdit ID="ASPxRichEdit2" runat="server" Width="500" Height="350" ReadOnly="true" WorkDirectory="~\App_Data\WorkDirectory">
         <Settings>
          <Behavior CreateNew="Hidden" Save="Hidden" Open="Hidden" SaveAs="Hidden" />
         </Settings>
        </dx:ASPxRichEdit>
       </td>
       <td>
         Document 2:
        <dx:ASPxRichEdit ID="ASPxRichEdit3" runat="server" Width="500" Height="350" ReadOnly="true" WorkDirectory="~\App_Data\WorkDirectory">
         <Settings>
          <Behavior CreateNew="Hidden" Save="Hidden" Open="Hidden" SaveAs="Hidden" />
         </Settings>
        </dx:ASPxRichEdit>
       </td>
      </tr>
     </table>
     <br />
     <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Merge documents content" AutoPostBack="false">
      <ClientSideEvents Click="OnClick" />
     </dx:ASPxButton>
     <br />
     <br />
     <dx:ASPxRichEdit ID="ASPxRichEdit1" ClientInstanceName="re" runat="server" WorkDirectory="~\App_Data\WorkDirectory" OnCallback="ASPxRichEdit1_Callback">
      <Settings>
       <Behavior CreateNew="Hidden" Save="Hidden" Open="Hidden" SaveAs="Hidden" />
      </Settings>
     </dx:ASPxRichEdit>

    </form>
</body>
</html>
