#pragma checksum "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Message\InBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "393ea8cc1242630f50cf0bfd8c8ee7e87a5f0ec3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_InBox), @"mvc.1.0.view", @"/Views/Message/InBox.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Message\InBox.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"393ea8cc1242630f50cf0bfd8c8ee7e87a5f0ec3", @"/Views/Message/InBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4b429c079bc72702172a168de5d0da3eaf50236", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_InBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Message\InBox.cshtml"
  
    ViewData["Title"] = "InBox";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Message\InBox.cshtml"
  
    string color = "";
    string statusColor = "";
    string checkStatus = "";
    string buttonStatusColor = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Gelen Kutusu</h1>\r\n<br />\r\n<table class=\"table table-hover\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Konu</th>\r\n        <th>Gönderen</th>\r\n        <th>Tarih</th>\r\n        <th>Mesaj Durumu</th>\r\n        <th>Mesajı Aç</th>\r\n    </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Message\InBox.cshtml"
     foreach (var item in Model)
    {
        //switch (item.BlogStatus)
        //{
        //    case true:
        //        statusColor = "badge rounded-pill bg-success";
        //        break;
        //    case false:
        //        statusColor = "badge rounded-pill bg-danger";
        //        break;
        //}

        //if (item.BlogStatus == true)
        //{
        //    durummm = "Şuan Aktif";
        //}
        //else
        //{
        //    durummm = " Şuan Pasif";
        //}

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 49 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Message\InBox.cshtml"
           Write(item.MessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 50 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Message\InBox.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Message\InBox.cshtml"
           Write(item.SenderUser.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 52 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Message\InBox.cshtml"
             Write(((DateTime)item.MessageDate).ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 54 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Message\InBox.cshtml"
                 if (item.MessageStatus)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-info\">Mesaj Okundu!</span>\r\n");
#nullable restore
#line 57 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Message\InBox.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-success\">Mesaj Okunmadı!</span>\r\n");
#nullable restore
#line 61 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Message\InBox.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1612, "\"", 1658, 2);
            WriteAttributeValue("", 1619, "/Message/MessageDetails/", 1619, 24, true);
#nullable restore
#line 63 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Message\InBox.cshtml"
WriteAttributeValue("", 1643, item.MessageID, 1643, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Mesajı Aç</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Melike Selimoğlu\Documents\GitHub\ASP.NET-CORE5_SocialDiscount\DotNetCoreCamp\Views\Message\InBox.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\n<a href=\"/Message/MessageAdd/\" class=\"btn btn-primary\">Yeni Mesaj Oluştur</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; }
    }
}
#pragma warning restore 1591
