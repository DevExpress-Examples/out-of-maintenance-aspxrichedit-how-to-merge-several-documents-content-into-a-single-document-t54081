<!-- default file list -->
*Files to look at*:

* **[Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))**
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# ASPxRichEdit - How to merge several documents content into a single document
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t540811/)**
<!-- run online end -->


<p>In some scenarios, it's necessary to combine several documents content (for example, from documents stored in a database) into a single document and display the resulting content in ASPxRichEdit. <br>This example demonstrates how to merge several documents content by using the <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditRichEditDocumentServertopic">RichEditDocumentServer</a> component, our non-visual document processing engine. <br>To open the resulting stream containing the document's content in ASPxRichEdit, the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxRichEditASPxRichEdit_Opentopic%28_7re7g%29">ASPxRichEdit.Open(String,DocumentFormat,Func<Stream>)</a> method is used.</p>

<br/>


