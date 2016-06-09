#pragma checksum "\Views\Manage\ManageLogins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aa4cd55cab3e2560894cbc0c8324e5ff5562dbb"
namespace MusicStore.Views.Manage
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

    public class ManageLogins : Microsoft.AspNetCore.Mvc.Razor.RazorPage<ManageLoginsViewModel>
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
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Manage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = null;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LinkLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        public ManageLogins()
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
        public Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ManageLoginsViewModel> Html { get; private set; }

        #line hidden

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            __tagHelperRunner = __tagHelperRunner ?? new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
            __tagHelperScopeManager = __tagHelperScopeManager ?? new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
#line 2 "\Views\Manage\ManageLogins.cshtml"
  
    ViewBag.Title = "Manage your external logins";

#line default
#line hidden

            BeginContext(89, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(96, 13, false);
#line 6 "\Views\Manage\ManageLogins.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(109, 34, true);
            WriteLiteral(".</h2>\r\n\r\n<p class=\"text-success\">");
            EndContext();
            BeginContext(144, 21, false);
#line 8 "\Views\Manage\ManageLogins.cshtml"
                   Write(ViewBag.StatusMessage);

#line default
#line hidden
            EndContext();
            BeginContext(165, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 9 "\Views\Manage\ManageLogins.cshtml"
 if (Model.CurrentLogins.Count > 0)
{

#line default
#line hidden

            BeginContext(211, 76, true);
            WriteLiteral("    <h4>Registered Logins</h4>\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
            EndContext();
#line 14 "\Views\Manage\ManageLogins.cshtml"
            

#line default
#line hidden

#line 14 "\Views\Manage\ManageLogins.cshtml"
             foreach (var account in Model.CurrentLogins)
            {

#line default
#line hidden

            BeginContext(361, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(408, 21, false);
#line 17 "\Views\Manage\ManageLogins.cshtml"
                   Write(account.LoginProvider);

#line default
#line hidden
            EndContext();
            BeginContext(429, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 19 "\Views\Manage\ManageLogins.cshtml"
                        

#line default
#line hidden

#line 19 "\Views\Manage\ManageLogins.cshtml"
                         if (ViewBag.ShowRemoveButton)
                        {

#line default
#line hidden

            BeginContext(545, 28, true);
            WriteLiteral("                            ");
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97597eca57124fa8ad75feda81681407", async() => {
                BeginContext(678, 77, true);
                WriteLiteral("\r\n                                <div>\r\n                                    ");
                EndContext();
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd1d9de3c6644e42b803228bb279a87d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 23 "\Views\Manage\ManageLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => account.LoginProvider);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                BeginContext(755, 56, false);
                Write(__tagHelperExecutionContext.Output);
                EndContext();
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                BeginContext(811, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ebfab6173fa44e6e8ce128e3464c81e8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 24 "\Views\Manage\ManageLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => account.ProviderKey);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                BeginContext(849, 54, false);
                Write(__tagHelperExecutionContext.Output);
                EndContext();
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                BeginContext(903, 97, true);
                WriteLiteral("\r\n                                    <input type=\"submit\" class=\"btn btn-default\" value=\"Remove\"");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 1000, "\"", 1066, 7);
                WriteAttributeValue("", 1008, "Remove", 1008, 6, true);
                WriteAttributeValue(" ", 1014, "this", 1015, 5, true);
#line 25 "\Views\Manage\ManageLogins.cshtml"
WriteAttributeValue(" ", 1019, account.LoginProvider, 1020, 23, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1042, "login", 1043, 6, true);
                WriteAttributeValue(" ", 1048, "from", 1049, 5, true);
                WriteAttributeValue(" ", 1053, "your", 1054, 5, true);
                WriteAttributeValue(" ", 1058, "account", 1059, 8, true);
                EndWriteAttribute();
                BeginContext(1067, 73, true);
                WriteLiteral(" />\r\n                                </div>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            BeginContext(573, 574, false);
            Write(__tagHelperExecutionContext.Output);
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            BeginContext(1147, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "\Views\Manage\ManageLogins.cshtml"
                        }
                        else
                        {

#line default
#line hidden

            BeginContext(1233, 37, true);
            WriteLiteral("                             &nbsp;\r\n");
            EndContext();
#line 32 "\Views\Manage\ManageLogins.cshtml"
                        }

#line default
#line hidden

            BeginContext(1299, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 35 "\Views\Manage\ManageLogins.cshtml"
            }

#line default
#line hidden

            BeginContext(1364, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 38 "\Views\Manage\ManageLogins.cshtml"
}

#line default
#line hidden

#line 39 "\Views\Manage\ManageLogins.cshtml"
 if (Model.OtherLogins.Any())
{

#line default
#line hidden

            BeginContext(1433, 61, true);
            WriteLiteral("    <h4>Add another service to log in.</h4>\r\n    <hr />\r\n    ");
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a0d85f4fb134b529123f7cebca67f1b", async() => {
                BeginContext(1597, 55, true);
                WriteLiteral("\r\n        <div id=\"socialLoginList\">\r\n            <p>\r\n");
                EndContext();
#line 46 "\Views\Manage\ManageLogins.cshtml"
                

#line default
#line hidden

#line 46 "\Views\Manage\ManageLogins.cshtml"
                 foreach (var p in Model.OtherLogins)
                {

#line default
#line hidden

                BeginContext(1726, 65, true);
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-default\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1791, "\"", 1819, 1);
#line 48 "\Views\Manage\ManageLogins.cshtml"
WriteAttributeValue("", 1796, p.AuthenticationScheme, 1796, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1820, 16, true);
                WriteLiteral(" name=\"provider\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1836, "\"", 1867, 1);
#line 48 "\Views\Manage\ManageLogins.cshtml"
WriteAttributeValue("", 1844, p.AuthenticationScheme, 1844, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1868, "\"", 1916, 6);
                WriteAttributeValue("", 1876, "Log", 1876, 3, true);
                WriteAttributeValue(" ", 1879, "in", 1880, 3, true);
                WriteAttributeValue(" ", 1882, "using", 1883, 6, true);
                WriteAttributeValue(" ", 1888, "your", 1889, 5, true);
#line 48 "\Views\Manage\ManageLogins.cshtml"
WriteAttributeValue(" ", 1893, p.DisplayName, 1894, 15, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1908, "account", 1909, 8, true);
                EndWriteAttribute();
                BeginContext(1917, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1919, 22, false);
#line 48 "\Views\Manage\ManageLogins.cshtml"
                                                                                                                                                                                           Write(p.AuthenticationScheme);

#line default
#line hidden
                EndContext();
                BeginContext(1941, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 49 "\Views\Manage\ManageLogins.cshtml"
                }

#line default
#line hidden

                BeginContext(1971, 38, true);
                WriteLiteral("            </p>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            BeginContext(1494, 522, false);
            Write(__tagHelperExecutionContext.Output);
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            BeginContext(2016, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 53 "\Views\Manage\ManageLogins.cshtml"
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
