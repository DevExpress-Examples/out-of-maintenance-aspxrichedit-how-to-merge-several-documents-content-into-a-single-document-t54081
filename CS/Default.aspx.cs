using DevExpress.Web.Office;
using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ASPxRichEdit2.Open(System.Web.HttpContext.Current.Server.MapPath("Doc 1.docx"));
            ASPxRichEdit3.Open(System.Web.HttpContext.Current.Server.MapPath("Doc 2.docx"));
        }          
    }

    protected void ASPxRichEdit1_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
    {
        DocumentManager.CloseDocument("testID");
        MemoryStream stream = new MemoryStream();
        RichEditDocumentServer server = new RichEditDocumentServer();
        server.LoadDocument(System.Web.HttpContext.Current.Server.MapPath("Doc 1.docx"), DocumentFormat.OpenXml);
        server.Document.AppendDocumentContent(System.Web.HttpContext.Current.Server.MapPath("Doc 2.docx"), DocumentFormat.OpenXml);
        server.SaveDocument(stream, DocumentFormat.OpenXml);
        stream.Position = 0;
        ASPxRichEdit1.Open("testID", DevExpress.XtraRichEdit.DocumentFormat.OpenXml, () => { return stream; });
    }
}