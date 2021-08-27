<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128545432/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T540811)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


