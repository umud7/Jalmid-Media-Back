#pragma checksum "C:\Users\umudq\source\repos\Jalmid Media\Jalmid Media\Views\Shared\Components\Footer\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "46cdc12a1c854126d39b87ae582c351a7d3324835ac5a37e422a7fe6559f1617"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\umudq\source\repos\Jalmid Media\Jalmid Media\Views\_ViewImports.cshtml"
using Jalmid_Media.ViewModels

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\umudq\source\repos\Jalmid Media\Jalmid Media\Views\_ViewImports.cshtml"
using Jalmid_Media.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"46cdc12a1c854126d39b87ae582c351a7d3324835ac5a37e422a7fe6559f1617", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"670eb3dcd7cf6b507836ffffbdc02fca3f132bfcb08e5135b81591bf0c02006b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<footer>
    <div class=""container"">
        <div class=""footer-content"">
            <div class=""footer-logo"">
                <h2>Jalmid<span>Media</span></h2>
                <p>Rəqəmsal inkişafda tərəfdaşınız</p>
            </div>
            <div class=""footer-links"">
                <h3>Sürətli bağlantılar</h3>
                <ul>
                    <li><a href=""index.html"">Ana</a></li>
                    <li><a href=""about.html"">Haqqımızda</a></li>
                    <li><a href=""services.html"">Xidmətlərimiz</a></li>
                    <li><a href=""contact.html"">Əlaqə</a></li>
                </ul>
            </div>
            <div class=""footer-services"">
                <h3>Xidmətlərimiz</h3>
                <ul>
                    <li><a href=""services.html#seo"">SEO</a></li>
                    <li><a href=""services.html#ppc"">PPC</a></li>
                    <li><a href=""services.html#social"">SMM</a></li>
                    <li><a href=""services.html#email"">E-poçt M");
            WriteLiteral("arketinqi</a></li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"footer-contact\">\r\n                <h3>Əlaqə</h3>\r\n                <p><i class=\"fas fa-map-marker-alt\"></i> ");
            Write(
#nullable restore
#line 30 "C:\Users\umudq\source\repos\Jalmid Media\Jalmid Media\Views\Shared\Components\Footer\Default.cshtml"
                                                          Model.Address

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                <p><i class=\"fas fa-phone\"></i>");
            Write(
#nullable restore
#line 31 "C:\Users\umudq\source\repos\Jalmid Media\Jalmid Media\Views\Shared\Components\Footer\Default.cshtml"
                                                Model.Telephone

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                <p><i class=\"fas fa-envelope\"></i>");
            Write(
#nullable restore
#line 32 "C:\Users\umudq\source\repos\Jalmid Media\Jalmid Media\Views\Shared\Components\Footer\Default.cshtml"
                                                   Model.Mail

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                <div class=\"social-icons\">\r\n                    <a href=\"#\"><i");
            BeginWriteAttribute("class", " class=\"", 1464, "\"", 1488, 2);
            WriteAttributeValue("", 1472, "fab", 1472, 3, true);
            WriteAttributeValue(" ", 1475, 
#nullable restore
#line 34 "C:\Users\umudq\source\repos\Jalmid Media\Jalmid Media\Views\Shared\Components\Footer\Default.cshtml"
                                               Model.IconF

#line default
#line hidden
#nullable disable
            , 1476, 12, false);
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                    <a href=\"#\"><i");
            BeginWriteAttribute("class", " class=\"", 1534, "\"", 1558, 2);
            WriteAttributeValue("", 1542, "fab", 1542, 3, true);
            WriteAttributeValue(" ", 1545, 
#nullable restore
#line 35 "C:\Users\umudq\source\repos\Jalmid Media\Jalmid Media\Views\Shared\Components\Footer\Default.cshtml"
                                               Model.IconT

#line default
#line hidden
#nullable disable
            , 1546, 12, false);
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                    <a href=\"#\"><i");
            BeginWriteAttribute("class", " class=\"", 1604, "\"", 1628, 2);
            WriteAttributeValue("", 1612, "fab", 1612, 3, true);
            WriteAttributeValue(" ", 1615, 
#nullable restore
#line 36 "C:\Users\umudq\source\repos\Jalmid Media\Jalmid Media\Views\Shared\Components\Footer\Default.cshtml"
                                               Model.IconL

#line default
#line hidden
#nullable disable
            , 1616, 12, false);
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                    <a href=\"#\"><i");
            BeginWriteAttribute("class", " class=\"", 1674, "\"", 1698, 2);
            WriteAttributeValue("", 1682, "fab", 1682, 3, true);
            WriteAttributeValue(" ", 1685, 
#nullable restore
#line 37 "C:\Users\umudq\source\repos\Jalmid Media\Jalmid Media\Views\Shared\Components\Footer\Default.cshtml"
                                               Model.IconI

#line default
#line hidden
#nullable disable
            , 1686, 12, false);
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"footer-bottom\">\r\n            <p>&copy; 2025 Jalmid Media. Bütün Hüquqlar Qorunur.</p>\r\n        </div>\r\n    </div>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
