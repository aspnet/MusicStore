#pragma checksum "\Views\Shared\DemoLinkDisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1d66cb0a417026ce906dc0ef005993313c263bc"
namespace MusicStore.Views.Shared
{
#line 1 "/Views/_ViewImports.cshtml"
using MusicStore

#line default
#line hidden
    ;
#line 2 "/Views/_ViewImports.cshtml"
using MusicStore.Models

#line default
#line hidden
    ;
#line 3 "/Views/_ViewImports.cshtml"
using Microsoft.Extensions.Options

#line default
#line hidden
    ;
#line 4 "/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#line default
#line hidden
    ;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using System.Threading.Tasks;

    public class DemoLinkDisplay : Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        public DemoLinkDisplay()
        {
        }
        #line hidden
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }

        #line hidden

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 1 "\Views\Shared\DemoLinkDisplay.cshtml"
  
    ViewBag.Title = "Demo link display page - Not for production use";

#line default
#line hidden

            BeginContext(79, 34, true);
            WriteLiteral("\r\n<hgroup class=\"title\">\r\n    <h1>");
            EndContext();
            BeginContext(114, 13, false);
#line 6 "\Views\Shared\DemoLinkDisplay.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(127, 105, true);
            WriteLiteral(".</h1>\r\n</hgroup>\r\n<div>\r\n    <p>\r\n        Demo link display page - Not for production use.\r\n    </p>\r\n\r\n");
            EndContext();
#line 13 "\Views\Shared\DemoLinkDisplay.cshtml"
    

#line default
#line hidden

#line 13 "\Views\Shared\DemoLinkDisplay.cshtml"
     if (ViewBag.Link != null)
    {

#line default
#line hidden

            BeginContext(271, 110, true);
            WriteLiteral("        <p class=\"text-danger\">\r\n            For DEMO only: You can click this link to confirm the email: [[<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 381, "\"", 401, 1);
#line 16 "\Views\Shared\DemoLinkDisplay.cshtml"
WriteAttributeValue("", 388, ViewBag.Link, 388, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(402, 149, true);
            WriteLiteral(">link</a>]]\r\n            <br />\r\n            Please change this code to register an email service in IdentityConfig to send an email.\r\n        </p>\r\n");
            EndContext();
#line 20 "\Views\Shared\DemoLinkDisplay.cshtml"
    }

#line default
#line hidden

            BeginContext(558, 6, true);
            WriteLiteral("</div>");
            EndContext();
        }
        #pragma warning restore 1998
    }
}
