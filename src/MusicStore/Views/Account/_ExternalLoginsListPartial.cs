#pragma checksum "\Views\Account\_ExternalLoginsListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19fdab43ac3ced5c1d4a2dc7d334236af46def30"
namespace MusicStore.Views.Account
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

    public class _ExternalLoginsListPartial : Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExternalLoginListViewModel>
    {
        #line hidden
        #pragma warning disable 0414
        private string __tagHelperStringValueBuffer = null;
        #pragma warning restore 0414
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = null;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = null;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExternalLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        public _ExternalLoginsListPartial()
        {
        }
        #line hidden
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExternalLoginListViewModel> Html { get; private set; }

        #line hidden

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            __tagHelperRunner = __tagHelperRunner ?? new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
            __tagHelperScopeManager = __tagHelperScopeManager ?? new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
            BeginContext(89, 49, true);
            WriteLiteral("<h4>Use another service to log in.</h4>\r\n<hr />\r\n");
            EndContext();
#line 5 "\Views\Account\_ExternalLoginsListPartial.cshtml"
  
    var loginProviders = SignInManager.GetExternalAuthenticationSchemes();
    if (!loginProviders.Any())
    {

#line default
#line hidden

            BeginContext(257, 331, true);
            WriteLiteral(@"        <div>
            <p>
                There are no external authentication services configured. See <a href=""http://go.microsoft.com/fwlink/?LinkId=313242"">this article</a>
                for details on setting up this ASP.NET application to support logging in via external services.
            </p>
        </div>
");
            EndContext();
#line 15 "\Views\Account\_ExternalLoginsListPartial.cshtml"
    }
    else
    {

#line default
#line hidden

            BeginContext(612, 8, true);
            WriteLiteral("        ");
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f83fb4be7fe42b68df217bc5aec3bed", async() => {
                BeginContext(769, 63, true);
                WriteLiteral("\r\n            <div id=\"socialLoginList\">\r\n                <p>\r\n");
                EndContext();
#line 21 "\Views\Account\_ExternalLoginsListPartial.cshtml"
                    

#line default
#line hidden

#line 21 "\Views\Account\_ExternalLoginsListPartial.cshtml"
                     foreach (var p in loginProviders)
                    {

#line default
#line hidden

                BeginContext(911, 69, true);
                WriteLiteral("                        <button type=\"submit\" class=\"btn btn-default\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 980, "\"", 1008, 1);
#line 23 "\Views\Account\_ExternalLoginsListPartial.cshtml"
WriteAttributeValue("", 985, p.AuthenticationScheme, 985, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1009, 16, true);
                WriteLiteral(" name=\"provider\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1025, "\"", 1056, 1);
#line 23 "\Views\Account\_ExternalLoginsListPartial.cshtml"
WriteAttributeValue("", 1033, p.AuthenticationScheme, 1033, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1057, "\"", 1105, 6);
                WriteAttributeValue("", 1065, "Log", 1065, 3, true);
                WriteAttributeValue(" ", 1068, "in", 1069, 3, true);
                WriteAttributeValue(" ", 1071, "using", 1072, 6, true);
                WriteAttributeValue(" ", 1077, "your", 1078, 5, true);
#line 23 "\Views\Account\_ExternalLoginsListPartial.cshtml"
WriteAttributeValue(" ", 1082, p.DisplayName, 1083, 15, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1097, "account", 1098, 8, true);
                EndWriteAttribute();
                BeginContext(1106, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1108, 22, false);
#line 23 "\Views\Account\_ExternalLoginsListPartial.cshtml"
                                                                                                                                                                                               Write(p.AuthenticationScheme);

#line default
#line hidden
                EndContext();
                BeginContext(1130, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 24 "\Views\Account\_ExternalLoginsListPartial.cshtml"
                    }

#line default
#line hidden

                BeginContext(1164, 50, true);
                WriteLiteral("                </p>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnurl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#line 18 "\Views\Account\_ExternalLoginsListPartial.cshtml"
                                                                           WriteLiteral(ViewBag.ReturnUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnurl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnurl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnurl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            BeginContext(620, 601, false);
            Write(__tagHelperExecutionContext.Output);
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            BeginContext(1221, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "\Views\Account\_ExternalLoginsListPartial.cshtml"
    }

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
