#pragma checksum "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "534022aa53484a168983e5843b5725666501be5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBlog), @"mvc.1.0.view", @"/Views/Blog/EditBlog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"534022aa53484a168983e5843b5725666501be5f", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4b429c079bc72702172a168de5d0da3eaf50236", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Blog\EditBlog.cshtml"
  
    ViewData["Title"] = "EditBlog";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Blog Düzenleme Sayfası</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Blog\EditBlog.cshtml"
 using (Html.BeginForm("EditBlog", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Blog\EditBlog.cshtml"
Write(Html.HiddenFor(x => x.BlogID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Güncellemek İstediğiniz Başlığı Giriniz!"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 16 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Güncellemek İstediğiniz Thumbnail Url'yi Giriniz!"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Güncellemek İstediğiniz Görselin Linkini Giriniz!"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Güncellemek İstediğiniz Kategoriyi Seçiniz!"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Blog\EditBlog.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Güncellemek İstediğiniz İçeriği Giriniz!"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Blog\EditBlog.cshtml"
Write(Html.TextAreaFor(x => x.BlogContent, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 29 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Blog\EditBlog.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
