#pragma checksum "C:\Users\Admin\source\repos\FPTJobMatch\FPTJobMatch\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "68fd6540e0f15115e658fed2229035c42a2298a895fde238d2ec92057b940dcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\FPTJobMatch\FPTJobMatch\Views\_ViewImports.cshtml"
using FPTJobMatch

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Admin\source\repos\FPTJobMatch\FPTJobMatch\Views\_ViewImports.cshtml"
using FPTJobMatch.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"68fd6540e0f15115e658fed2229035c42a2298a895fde238d2ec92057b940dcb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d3f248527de663faa7f9493efd2b6fc9aa77fa59ae2ec015b241df19860c89ab", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\Admin\source\repos\FPTJobMatch\FPTJobMatch\Views\Home\Index.cshtml"
       FPTJobMatch.ViewModels.HomeIndexViewModel

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\FPTJobMatch\FPTJobMatch\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"<style>
    .image-container {
        width: 100%;
        height: auto;
        padding-bottom: 30px;
    }

    .image-container img {
        width: 100%;
        height: auto;
        display: block;
        margin: 0 auto;
    }

</style>


<h3>Where Careers Begin and Dreams Take Flight</h3>

<div style=""display: flex; justify-content: center;"" class=""mb-3"">
    <div class=""col-md-6"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68fd6540e0f15115e658fed2229035c42a2298a895fde238d2ec92057b940dcb4872", async() => {
                WriteLiteral(@"
            <div class=""input-group"">
                <input type=""text"" class=""form-control"" name=""searchString"" placeholder=""Search for job title..."">
                <div style=""padding-left: 3px"" class=""input-group-append"">
                    <button class=""btn btn-outline-primary"" type=""submit"">Search</button>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 38 "C:\Users\Admin\source\repos\FPTJobMatch\FPTJobMatch\Views\Home\Index.cshtml"
     foreach (var item in Model.JobListingsWithUserEmail)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"col-md-3\">\r\n            <div class=\"card mb-3\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
            Write(
#nullable restore
#line 43 "C:\Users\Admin\source\repos\FPTJobMatch\FPTJobMatch\Views\Home\Index.cshtml"
                                            Html.DisplayFor(modelItem => item.Item1.Title)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\" style=\"overflow: hidden;text-overflow: ellipsis;white-space: nowrap;\">");
            Write(
#nullable restore
#line 44 "C:\Users\Admin\source\repos\FPTJobMatch\FPTJobMatch\Views\Home\Index.cshtml"
                                                                                                                Html.DisplayFor(modelItem => item.Item1.Description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">Company: ");
            Write(
#nullable restore
#line 45 "C:\Users\Admin\source\repos\FPTJobMatch\FPTJobMatch\Views\Home\Index.cshtml"
                                                   Html.DisplayFor(modelItem => item.Item1.CompanyName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">Position: ");
            Write(
#nullable restore
#line 46 "C:\Users\Admin\source\repos\FPTJobMatch\FPTJobMatch\Views\Home\Index.cshtml"
                                                    Html.DisplayFor(modelItem => item.Item1.Position)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">Salary: ");
            Write(
#nullable restore
#line 47 "C:\Users\Admin\source\repos\FPTJobMatch\FPTJobMatch\Views\Home\Index.cshtml"
                                                  Html.DisplayFor(modelItem => item.Item1.Salary)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                    <div class=\"text-center\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1817, "\"", 1889, 1);
            WriteAttributeValue("", 1824, 
#nullable restore
#line 49 "C:\Users\Admin\source\repos\FPTJobMatch\FPTJobMatch\Views\Home\Index.cshtml"
                                  Url.Action("Details", "JobListings", new { id = item.Item1.Id })

#line default
#line hidden
#nullable disable
            , 1824, 65, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary mx-auto btn-sm\">Details</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 54 "C:\Users\Admin\source\repos\FPTJobMatch\FPTJobMatch\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FPTJobMatch.ViewModels.HomeIndexViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591