#pragma checksum "\Views\Store\Browse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec9e9334c961bc565adf59e3ae8cd450d4be14f3"
namespace MusicStore.Views.Store
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

    public class Browse : Microsoft.AspNetCore.Mvc.Razor.RazorPage<Genre>
    {
        #line hidden
        #pragma warning disable 0414
        private string __tagHelperStringValueBuffer = null;
        #pragma warning restore 0414
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = null;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        public Browse()
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
        public Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Genre> Html { get; private set; }

        #line hidden

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            __tagHelperRunner = __tagHelperRunner ?? new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
            __tagHelperScopeManager = __tagHelperScopeManager ?? new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
#line 2 "\Views\Store\Browse.cshtml"
  
    ViewBag.Title = "Browse Albums";

#line default
#line hidden

            BeginContext(59, 43, true);
            WriteLiteral("<div class=\"genre\">\r\n    <h3>\r\n        <em>");
            EndContext();
            BeginContext(103, 10, false);
#line 7 "\Views\Store\Browse.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(113, 75, true);
            WriteLiteral("</em> Albums\r\n    </h3>\r\n\r\n    <ul id=\"album-list\" class=\"list-unstyled\">\r\n");
            EndContext();
#line 11 "\Views\Store\Browse.cshtml"
        

#line default
#line hidden

#line 11 "\Views\Store\Browse.cshtml"
         foreach (var album in Model.Albums)
        {

#line default
#line hidden

            BeginContext(245, 88, true);
            WriteLiteral("            <li class=\"col-lg-2 col-md-2 col-sm-2 col-xs-4 container\">\r\n                ");
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e7ee94de6634ecc8d330c96e306f9b4", async() => {
                BeginContext(410, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 15 "\Views\Store\Browse.cshtml"
                    

#line default
#line hidden

#line 15 "\Views\Store\Browse.cshtml"
                     if (!string.IsNullOrEmpty(album.AlbumArtUrl))
                    {

#line default
#line hidden

                BeginContext(503, 28, true);
                WriteLiteral("                        <img");
                EndContext();
                BeginWriteAttribute("alt", " alt=\"", 531, "\"", 549, 1);
#line 17 "\Views\Store\Browse.cshtml"
WriteAttributeValue("", 537, album.Title, 537, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("src", " src=\"", 550, "\"", 588, 1);
#line 17 "\Views\Store\Browse.cshtml"
WriteAttributeValue("", 556, Url.Content(@album.AlbumArtUrl), 556, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(589, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 18 "\Views\Store\Browse.cshtml"
                    }

#line default
#line hidden

                BeginContext(617, 46, true);
                WriteLiteral("                    <h5 class=\"control-label\">");
                EndContext();
                BeginContext(664, 11, false);
#line 19 "\Views\Store\Browse.cshtml"
                                         Write(album.Title);

#line default
#line hidden
                EndContext();
                BeginContext(675, 23, true);
                WriteLiteral("</h5>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#line 14 "\Views\Store\Browse.cshtml"
                                                                 WriteLiteral(album.AlbumId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            BeginContext(333, 369, false);
            Write(__tagHelperExecutionContext.Output);
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            BeginContext(702, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 22 "\Views\Store\Browse.cshtml"
        }

#line default
#line hidden

            BeginContext(734, 17, true);
            WriteLiteral("    </ul>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
    }
}
