Imports Microsoft.VisualBasic
Imports DevExpress.Web.Office
Imports DevExpress.XtraRichEdit
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ASPxRichEdit2.Open(System.Web.HttpContext.Current.Server.MapPath("Doc 1.docx"))
			ASPxRichEdit3.Open(System.Web.HttpContext.Current.Server.MapPath("Doc 2.docx"))
		End If
	End Sub

	Protected Sub ASPxRichEdit1_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
		DocumentManager.CloseDocument("testID")
		Dim stream As New MemoryStream()
		Dim server As New RichEditDocumentServer()
		server.LoadDocument(System.Web.HttpContext.Current.Server.MapPath("Doc 1.docx"), DocumentFormat.OpenXml)
		server.Document.AppendDocumentContent(System.Web.HttpContext.Current.Server.MapPath("Doc 2.docx"), DocumentFormat.OpenXml)
		server.SaveDocument(stream, DocumentFormat.OpenXml)
		stream.Position = 0
		ASPxRichEdit1.Open("testID", DevExpress.XtraRichEdit.DocumentFormat.OpenXml, Function() stream)
	End Sub
End Class