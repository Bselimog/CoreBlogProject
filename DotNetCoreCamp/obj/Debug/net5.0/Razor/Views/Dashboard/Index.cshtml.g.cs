#pragma checksum "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d251e21fb1bcc37288d8f4751e011dbebb45d84a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\_ViewImports.cshtml"
using DotNetCoreCamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\_ViewImports.cshtml"
using DotNetCoreCamp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d251e21fb1bcc37288d8f4751e011dbebb45d84a", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06a52ab9f63d5c9aacfe452a58100eb701d9ad8", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/writer/assets/images/dashboard/circle.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-absolute"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("circle-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d251e21fb1bcc37288d8f4751e011dbebb45d84a4809", async() => {
                WriteLiteral(@"
    <div class=""page-header"">
        <h3 class=""page-title"">
            <span class=""page-title-icon bg-gradient-primary text-white mr-2"">
                <i class=""mdi mdi-home""></i>
            </span> Dashboard
        </h3>
    </div>
    <div class=""row"">
        <div class=""col-md-4 stretch-card grid-margin"">
            <div class=""card bg-gradient-danger card-img-holder text-white"">
                <div class=""card-body"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d251e21fb1bcc37288d8f4751e011dbebb45d84a5549", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <h4 class=\"font-weight-normal mb-3\">\r\n                        Toplam Blog Sayımız <i class=\"mdi mdi-chart-line mdi-24px float-right\"></i>\r\n                    </h4>\r\n                    <h2 class=\"mb-5\">");
#nullable restore
#line 25 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Dashboard\Index.cshtml"
                                Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                    <h6 class=""card-text"">Core 5.0 Proje Kampı</h6>
                </div>
            </div>
        </div>
        <div class=""col-md-4 stretch-card grid-margin"">
            <div class=""card bg-gradient-info card-img-holder text-white"">
                <div class=""card-body"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d251e21fb1bcc37288d8f4751e011dbebb45d84a7667", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <h4 class=\"font-weight-normal mb-3\">\r\n                        Sizin Blog Sayınız <i class=\"mdi mdi-bookmark-outline mdi-24px float-right\"></i>\r\n                    </h4>\r\n                    <h2 class=\"mb-5\">");
#nullable restore
#line 37 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Dashboard\Index.cshtml"
                                Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                    <h6 class=""card-text"">Core 5.0 Proje Kampı</h6>
                </div>
            </div>
        </div>
        <div class=""col-md-4 stretch-card grid-margin"">
            <div class=""card bg-gradient-success card-img-holder text-white"">
                <div class=""card-body"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d251e21fb1bcc37288d8f4751e011dbebb45d84a9793", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <h4 class=\"font-weight-normal mb-3\">\r\n                        Toplam Kategori Sayımız <i class=\"mdi mdi-diamond mdi-24px float-right\"></i>\r\n                    </h4>\r\n                    <h2 class=\"mb-5\">");
#nullable restore
#line 49 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Dashboard\Index.cshtml"
                                Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                    <h6 class=\"card-text\">Core 5.0 Proje Kampı</h6>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
#nullable restore
#line 55 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("BlogListDashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 57 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("WriterAboutOnDashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 59 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("CategoryListDashbord"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <!--<script src=""~/writer/assets/vendors/js/vendor.bundle.base.js""></script>-->
    <!-- endinject -->
    <!-- Plugin js for this page -->
    <!--<script src=""~/writer/assets/vendors/chart.js/Chart.min.js""></script>-->
    <!-- End plugin js for this page -->
    <!-- inject:js -->
    <!--<script src=""~/writer/assets/js/off-canvas.js""></script>
    <script src=""~/writer/assets/js/hoverable-collapse.js""></script>
    <script src=""~/writer/assets/js/misc.js""></script>-->
    <!-- endinject -->
    <!-- Custom js for this page -->
    <!--<script src=""~/writer/assets/js/dashboard.js""></script>
    <script src=""~/writer/assets/js/todolist.js""></script>-->
    <!-- End custom js for this page -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
