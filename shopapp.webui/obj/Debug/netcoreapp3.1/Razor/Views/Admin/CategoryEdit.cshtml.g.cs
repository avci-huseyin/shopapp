#pragma checksum "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a43134da3ffd420f50f5e9fbb8064edf1c91e433"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryEdit), @"mvc.1.0.view", @"/Views/Admin/CategoryEdit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "D:\01\web\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\01\web\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\01\web\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\01\web\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\01\web\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\01\web\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a43134da3ffd420f50f5e9fbb8064edf1c91e433", @"/Views/Admin/CategoryEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c753548c838aaf691366e5b3ead3e0dedbc013", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CategoryEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-2 col-form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CategoryEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deletefromcategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"h3\">Edit Category</h1>\r\n<hr>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43134da3ffd420f50f5e9fbb8064edf1c91e4337752", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43134da3ffd420f50f5e9fbb8064edf1c91e4338022", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 9 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            <input type=\"hidden\" name=\"CategoryId\"");
                BeginWriteAttribute("value", " value=\"", 319, "\"", 344, 1);
#nullable restore
#line 11 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 327, Model.CategoryId, 327, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <div id=\"products\">\r\n");
#nullable restore
#line 13 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                 for (int i = 0; i < Model.Products.Count; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 505, "\"", 534, 3);
                WriteAttributeValue("", 512, "Products[", 512, 9, true);
#nullable restore
#line 15 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 521, i, 521, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 523, "].productId", 523, 11, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 535, "\"", 572, 1);
#nullable restore
#line 15 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 543, Model.Products[@i].ProductId, 543, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 616, "\"", 644, 3);
                WriteAttributeValue("", 623, "Products[", 623, 9, true);
#nullable restore
#line 16 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 632, i, 632, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 634, "].ImageUrl", 634, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 645, "\"", 681, 1);
#nullable restore
#line 16 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 653, Model.Products[@i].ImageUrl, 653, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 725, "\"", 749, 3);
                WriteAttributeValue("", 732, "Products[", 732, 9, true);
#nullable restore
#line 17 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 741, i, 741, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 743, "].Name", 743, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 750, "\"", 782, 1);
#nullable restore
#line 17 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 758, Model.Products[@i].Name, 758, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 826, "\"", 851, 3);
                WriteAttributeValue("", 833, "Products[", 833, 9, true);
#nullable restore
#line 18 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 842, i, 842, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 844, "].Price", 844, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 852, "\"", 885, 1);
#nullable restore
#line 18 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 860, Model.Products[@i].Price, 860, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 929, "\"", 959, 3);
                WriteAttributeValue("", 936, "Products[", 936, 9, true);
#nullable restore
#line 19 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 945, i, 945, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 947, "].IsApproved", 947, 12, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 960, "\"", 1009, 1);
#nullable restore
#line 19 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 968, Model.Products[@i].IsApproved.ToString(), 968, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 20 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n\r\n            <div class=\"form-group row\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43134da3ffd420f50f5e9fbb8064edf1c91e43315076", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 24 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"col-sm-10\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a43134da3ffd420f50f5e9fbb8064edf1c91e43316702", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 26 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43134da3ffd420f50f5e9fbb8064edf1c91e43318278", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 27 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group row\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43134da3ffd420f50f5e9fbb8064edf1c91e43320019", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 31 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"col-sm-10\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a43134da3ffd420f50f5e9fbb8064edf1c91e43321644", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 33 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43134da3ffd420f50f5e9fbb8064edf1c91e43323219", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 34 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
            <div class=""form-group row"">
                <div class=""col-sm-10 offset-sm-2"">
                    <button type=""submit"" class=""btn btn-primary"">Edit Category</button>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col-md-8"">
        <div class=""row"">
            <div class=""col-md-12"">
                <table class=""table table-bordered table-sm"">
                    <thead>
                        <tr>
                            <td style=""width: 30px;"">Id</td>
                            <td style=""width: 100px;"">Image</td>
                            <td>Name</td>
                            <td style=""width: 20px;"">Price</td>
                            <td style=""width: 20px;"">Onayli</td>
                            <td style=""width: 150px;""></td>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 59 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                         if(Model.Products.Count > 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                             foreach (var item in Model.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 64 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                   Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a43134da3ffd420f50f5e9fbb8064edf1c91e43328305", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3012, "~/img/", 3012, 6, true);
#nullable restore
#line 65 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
AddHtmlAttributeValue("", 3018, item.ImageUrl, 3018, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 66 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 67 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n");
#nullable restore
#line 69 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                         if(item.IsApproved)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 72 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 76 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3778, "\"", 3816, 2);
            WriteAttributeValue("", 3785, "/admin/products/", 3785, 16, true);
#nullable restore
#line 79 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 3801, item.ProductId, 3801, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43134da3ffd420f50f5e9fbb8064edf1c91e43332095", async() => {
                WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 4069, "\"", 4092, 1);
#nullable restore
#line 82 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 4077, item.ProductId, 4077, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            <input type=\"hidden\" name=\"categoryId\"");
                BeginWriteAttribute("value", " value=\"", 4178, "\"", 4203, 1);
#nullable restore
#line 83 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 4186, Model.CategoryId, 4186, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 89 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-warning\">\r\n                                <h3>No Products</h3>\r\n                            </div>\r\n");
#nullable restore
#line 96 "D:\01\web\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n        \r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/modules/jquery-validation/dist/jquery.validate.min.js\"></script>\r\n    <script src=\"/modules/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js\"></script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
