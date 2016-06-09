#pragma checksum "\Views\Shared\StatusCodePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8be33fe3d174bca570021ba7fc23d8687db04dd1"
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

    public class StatusCodePage : Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        public StatusCodePage()
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
#line 1 "\Views\Shared\StatusCodePage.cshtml"
  
    ViewBag.Title = "Item not found";

#line default
#line hidden

            BeginContext(46, 141, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">Item not found.</h1>\r\n<h2 class=\"text-danger\">Unable to find the item you are searching for. Please try again.</h2>");
            EndContext();
        }
        #pragma warning restore 1998
    }
}
