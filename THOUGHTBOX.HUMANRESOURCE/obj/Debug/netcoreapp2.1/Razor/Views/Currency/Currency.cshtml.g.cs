#pragma checksum "C:\Users\PC\Desktop\THOUGHTBOX.HUMANRESOURCE\THOUGHTBOX.HUMANRESOURCE\Views\Currency\Currency.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b70f18ab86c580138b3d3260f980d09785d4c4e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Currency_Currency), @"mvc.1.0.view", @"/Views/Currency/Currency.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Currency/Currency.cshtml", typeof(AspNetCore.Views_Currency_Currency))]
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
#line 1 "C:\Users\PC\Desktop\THOUGHTBOX.HUMANRESOURCE\THOUGHTBOX.HUMANRESOURCE\Views\_ViewImports.cshtml"
using THOUGHTBOX.HUMANRESOURCE;

#line default
#line hidden
#line 2 "C:\Users\PC\Desktop\THOUGHTBOX.HUMANRESOURCE\THOUGHTBOX.HUMANRESOURCE\Views\_ViewImports.cshtml"
using THOUGHTBOX.HUMANRESOURCE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b70f18ab86c580138b3d3260f980d09785d4c4e4", @"/Views/Currency/Currency.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f208f16e645bbd27f9a0e4ac7eaeff94e313263", @"/Views/_ViewImports.cshtml")]
    public class Views_Currency_Currency : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<THOUGHTBOX.DOMAIN.Domain.Currency>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/Currency.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Currency/Currency/?id={{x.id }}&methode=Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Currency/Currency/?id={{x.id }}&methode=Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'do you want to delete the selected entry?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\PC\Desktop\THOUGHTBOX.HUMANRESOURCE\THOUGHTBOX.HUMANRESOURCE\Views\Currency\Currency.cshtml"
  
    ViewData["Title"] = "Currency";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(143, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3518422a4d74c3ebd61c0594e46c2a1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(188, 1235, true);
            WriteLiteral(@"

<div id=""page-wrapper"">
    <div class=""row"">

        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <i class=""fa fa-lightbulb-o""></i>&nbsp;&nbsp;New Currency can create here.&nbsp;&nbsp;Press <i class=""fa fa-edit""></i> to Edit created Currency details. Press <i class=""fa fa-cut""></i> to Delete created Currency details. Clicking on Currency Name / Currency Code sort data on ascending/descending order. <span style=""color:rosybrown;font-weight: bold;font-size:large;"">*</span> are mandatory in this page. Please enter some information while pressing submit button for that fields. <span style=""color:rosybrown;font-weight: bold""> Active Status is to verify whether the Company is currently active or not. Company Code entering need to be unique. If the code is already existing in system will not accept the same.</span>&nbsp;&nbsp;<i clas");
            WriteLiteral("s=\"fa fa-lightbulb-o\"></i>\r\n                </div>\r\n\r\n                <div class=\"panel-body\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-lg-3\">\r\n                            ");
            EndContext();
            BeginContext(1423, 2656, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11b621a5e250439c8697342cad5342ee", async() => {
                BeginContext(1441, 922, true);
                WriteLiteral(@"


                                <div id=""alertWmsg"" style=""display:none"" class=""alert alert-danger alert-dismissable"">
                                    <a href=""#"" class=""close"" data-dismiss=""alert"" aria-label=""close"">×</a>
                                    <strong>Some Error Happend!</strong>
                                </div>
                                <div id=""alertSmsg"" style=""display:none"" class=""alert alert-success alert-dismissable"">
                                    <a href=""#"" class=""close"" data-dismiss=""alert"" aria-label=""close"">×</a>
                                    <strong>Successfully Inserted!</strong>
                                </div>

                                <div class=""form-group"">
                                    <label>Name&nbsp;<span style=""color:red;font-weight: bold;font-size:large;"">*</span></label>
                                    ");
                EndContext();
                BeginContext(2364, 187, false);
#line 43 "C:\Users\PC\Desktop\THOUGHTBOX.HUMANRESOURCE\THOUGHTBOX.HUMANRESOURCE\Views\Currency\Currency.cshtml"
                               Write(Html.TextBoxFor(Currency => Currency.Name, new { id = "frm-CurrencyName", placeholder = "Currency Name", TabIndex = "1", autocomplete = "off", MaxLength = "50", @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2551, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2590, 52, false);
#line 44 "C:\Users\PC\Desktop\THOUGHTBOX.HUMANRESOURCE\THOUGHTBOX.HUMANRESOURCE\Views\Currency\Currency.cshtml"
                               Write(Html.ValidationMessageFor(Currency => Currency.Name));

#line default
#line hidden
                EndContext();
                BeginContext(2642, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2681, 63, false);
#line 45 "C:\Users\PC\Desktop\THOUGHTBOX.HUMANRESOURCE\THOUGHTBOX.HUMANRESOURCE\Views\Currency\Currency.cshtml"
                               Write(Html.HiddenFor(Currency => Currency.Id, new { id = "hidenid" }));

#line default
#line hidden
                EndContext();
                BeginContext(2744, 272, true);
                WriteLiteral(@"

                                </div>


                                <div class=""form-group"">
                                    <label>Code&nbsp;<span style=""color:red;font-weight: bold;font-size:large;"">*</span></label>
                                    ");
                EndContext();
                BeginContext(3017, 187, false);
#line 52 "C:\Users\PC\Desktop\THOUGHTBOX.HUMANRESOURCE\THOUGHTBOX.HUMANRESOURCE\Views\Currency\Currency.cshtml"
                               Write(Html.TextBoxFor(Currency => Currency.Code, new { id = "frm-CurrencyCode", placeholder = "Currency Code", TabIndex = "2", autocomplete = "off", MaxLength = "10", @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(3204, 274, true);
                WriteLiteral(@"
                                </div>


                                <div class=""form-group"">
                                    <label>Decimals&nbsp;<span style=""color:red;font-weight: bold;font-size:large;"">*</span></label>
                                    ");
                EndContext();
                BeginContext(3479, 191, false);
#line 58 "C:\Users\PC\Desktop\THOUGHTBOX.HUMANRESOURCE\THOUGHTBOX.HUMANRESOURCE\Views\Currency\Currency.cshtml"
                               Write(Html.TextBoxFor(Currency => Currency.Decimals, new { id = "frm-Decimals", placeholder = "Decimals Accuracy", TabIndex = "2", autocomplete = "off", MaxLength = "10", @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(3670, 248, true);
                WriteLiteral("\r\n                                </div>\r\n\r\n\r\n                                <br />\r\n                                <br />\r\n\r\n                                <button type=\"button\" onclick=\"datainsert();\" id=\"btnsubupdate\" class=\"btn btn-success\">");
                EndContext();
                BeginContext(3919, 19, false);
#line 65 "C:\Users\PC\Desktop\THOUGHTBOX.HUMANRESOURCE\THOUGHTBOX.HUMANRESOURCE\Views\Currency\Currency.cshtml"
                                                                                                                   Write(ViewBag.SubmitValue);

#line default
#line hidden
                EndContext();
                BeginContext(3938, 134, true);
                WriteLiteral("</button>\r\n\r\n                                <button type=\"reset\" class=\"btn btn-default\">Reset</button>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4079, 4019, true);
            WriteLiteral(@"
                        </div>

                        <!-- /.col-lg-6 (nested) -->
                        <div class=""col-lg-9"" ng-app=""app"" ng-controller=""customersController"">

                            <div class=""col-lg-12"">
                                <div class=""panel panel-default"">

                                    <div class=""panel-heading"">
                                        New Currency Created  <label class=""control-label"" style=""width:80px;text-align:center;"">Search: </label><span style=""text-align:right""><input ng-model=""query"" type=""text"" placeholder=""Filter by"" class=""control-label"" autofocus style=""width:150px;""><i class=""fa fa-search""></i></span>
                                    </div>




                                    <!-- /.panel-heading -->
                                    <div class=""panel-body"">
                                        <div class=""table-responsive"">
                                            <table class=""table table-stri");
            WriteLiteral(@"ped table-bordered table-hover"" id=""myTable"">
                                                <thead>
                                                    <tr>
                                                        <th style=""width:50px;text-align:center;"">#</th>
                                                        <th style=""width:350px;"">
                                                            <a href=""#"" ng-click=""orderByField='name'; reverseSort = !reverseSort"">
                                                                Name <span ng-show=""orderByField == 'name'""><span ng-show=""!reverseSort""><i class=""glyphicon glyphicon-sort-by-alphabet""></i></span><span ng-show=""reverseSort""><i class=""glyphicon glyphicon-sort-by-alphabet-alt""></i></span></span>
                                                            </a>
                                                        </th>
                                                        <th style=""width:120px;"">
                                ");
            WriteLiteral(@"                            <a href=""#"" ng-click=""orderByField='code'; reverseSort = !reverseSort"">
                                                                Code <span ng-show=""orderByField == 'code'""><span ng-show=""!reverseSort""><i class=""glyphicon glyphicon-sort-by-alphabet""></i></span><span ng-show=""reverseSort""><i class=""glyphicon glyphicon-sort-by-alphabet-alt""></i></span></span>
                                                            </a>
                                                        </th>


                                                        <th style=""width:60px;text-align:center;"">Edit</th>
                                                        <th style=""width:60px;text-align:center;"">Delete</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr ng-repeat=""x in names | orderBy:orderByField");
            WriteLiteral(@":reverseSort | filter: query | offset: currentPage*itemsPerPage | limitTo: itemsPerPage"">
                                                        <td style=""width:50px;text-align:center;"">
                                                            {{ currentPage*itemsPerPage + $index + 1}}
                                                            <input type=""hidden"" name=""Categoryid"" id=""ID"" value=""{{x.id}} "" />
                                                        </td>
                                                        <td style=""width:350px;""><span data-tooltip class=""has-tip"" title=""{{ x.name }}"">{{ (x. name).substring(0,30) }}</span></td>
                                                        <td style=""width:120px;""><span data-tooltip class=""has-tip"" title=""{{ x.code }}"">{{ (x.code).substring(0,6) }}</span></td>
                                                        <td style=""width:60px;text-align:center;"">");
            EndContext();
            BeginContext(8098, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c56a9bb4dd304e1e876089460d0dfb44", async() => {
                BeginContext(8155, 26, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8185, 105, true);
            WriteLiteral("</td>\r\n                                                        <td style=\"width:60px;text-align:center;\">");
            EndContext();
            BeginContext(8290, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c055ca8d4d644f11b990016e10b14b8e", async() => {
                BeginContext(8419, 25, true);
                WriteLiteral("<i class=\"fa fa-cut\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8448, 2392, true);
            WriteLiteral(@"</td>
                                                    </tr>

                                                    <tr>

                                                        <td colspan=""5"" style=""width:640px;"">
                                                            <ul class=""pagination pull-right"" style=""height:5px;"">
                                                                <li ng-class=""prevPageDisabled()"">
                                                                    <a href=""#"" ng-click=""prevPage()"">« Prev</a>
                                                                </li>
                                                                <li ng-repeat=""n in range()""
                                                                    ng-class=""{active: n == currentPage}"" ng-click=""setPage(n)"">
                                                                    <a href=""#"">{{n+1}}</a>
                                                                </li>
            ");
            WriteLiteral(@"                                                    <li ng-class=""nextPageDisabled()"">
                                                                    <a href=""#"" ng-click=""nextPage()"">Next »</a>
                                                                </li>

                                                            </ul>


                                                        </td>

                                                    </tr>
                                                </tbody>

                                            </table>
                                        </div>
                                        <!-- /.table-responsive -->
                                    </div>
                                    <!-- /.panel-body -->

                                </div>
                                <!-- /.panel -->
                            </div>

                        </div>
                        <!-- /.col-lg-6 (nested) -->
    ");
            WriteLiteral(@"                </div>
                    <!-- /.row (nested) -->
                </div>
                <!-- /.panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
</div>
<!-- /#page-wrapper -->

<input type=""hidden"" name=""InterestID"" id=""IDmsg""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 10840, "\"", 10867, 1);
#line 167 "C:\Users\PC\Desktop\THOUGHTBOX.HUMANRESOURCE\THOUGHTBOX.HUMANRESOURCE\Views\Currency\Currency.cshtml"
WriteAttributeValue("", 10848, TempData["notice"], 10848, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10868, 13, true);
            WriteLiteral(" />\r\n\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<THOUGHTBOX.DOMAIN.Domain.Currency> Html { get; private set; }
    }
}
#pragma warning restore 1591
