#pragma checksum "\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3c8f669317ba21723b2f2b70eda7f65904e2a16"
namespace MusicStore.Views.ShoppingCart
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

    public class Index : Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicStore.ViewModels.ShoppingCartViewModel>
    {
#line 8 "\Views\ShoppingCart\Index.cshtml"

    public string GetAntiXsrfRequestToken()
    {
        return Xsrf.GetAndStoreTokens(Context).RequestToken;
    }

#line default
#line hidden
        #line hidden
        #pragma warning disable 0414
        private string __tagHelperStringValueBuffer = null;
        #pragma warning restore 0414
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = null;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddressAndPayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        public Index()
        {
        }
        #line hidden
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Antiforgery.IAntiforgery Xsrf { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicStore.ViewModels.ShoppingCartViewModel> Html { get; private set; }

        #line hidden

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            __tagHelperRunner = __tagHelperRunner ?? new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
            __tagHelperScopeManager = __tagHelperScopeManager ?? new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
#line 3 "\Views\ShoppingCart\Index.cshtml"
  
    ViewBag.Title = "Shopping Cart";

#line default
#line hidden

            BeginContext(157, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(298, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async(__razor_section_writer) => {
                BeginContext(318, 764, true);
                WriteLiteralTo(__razor_section_writer, @"
    <script type=""text/javascript"">
        $(function () {
            // Document.ready -> link up remove event handler
            $("".RemoveLink"").click(function () {
                // Get the id from the link
                var recordToDelete = $(this).attr(""data-id"");
                var PostToUrl = $(this).attr(""data-url"");
                if (recordToDelete != '') {

                    // Perform the ajax post
                    $.ajax(PostToUrl, {
                        type: ""post"",
                        data: {
                            ""id"": recordToDelete
                        },
                        dataType: ""json"",
                        headers: {
                            ""RequestVerificationToken"": '");
                EndContext();
                BeginContext(1083, 25, false);
#line 33 "\Views\ShoppingCart\Index.cshtml"
                          WriteTo(__razor_section_writer, GetAntiXsrfRequestToken());

#line default
#line hidden
                EndContext();
                BeginContext(1108, 746, true);
                WriteLiteralTo(__razor_section_writer, @"'
                        }
                    }).done(function (data) {
                        // Successful requests get here
                        // Update the page elements
                        if (data.ItemCount == 0) {
                            $('#row-' + data.DeleteId).fadeOut('slow');
                        } else {
                            $('#item-count-' + data.DeleteId).text(data.ItemCount);
                        }

                        $('#cart-total').text(data.CartTotal);
                        $('#update-message').text(data.Message);
                        $('#cart-status').text(data.CartCount);
                    });
                }
            });

        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(1857, 71, true);
            WriteLiteral("\r\n<h3>\r\n    <em>Review</em> your cart:\r\n</h3>\r\n<p class=\"button\">\r\n    ");
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc2b67cd978a4b46ad14fac3179cbc10", async() => {
                BeginContext(1988, 11, true);
                WriteLiteral("Checkout >>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            BeginContext(1928, 75, false);
            Write(__tagHelperExecutionContext.Output);
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            BeginContext(2003, 341, true);
            WriteLiteral(@"
</p>
<div id=""update-message"">
</div>
<table id=""cart-summary"" class=""table table-bordered table-responsive table-hover table-striped"">
    <tr>
        <th>
            Album Name
        </th>
        <th>
            Price (each)
        </th>
        <th>
            Quantity
        </th>
        <th></th>
    </tr>
");
            EndContext();
#line 76 "\Views\ShoppingCart\Index.cshtml"
    

#line default
#line hidden

#line 76 "\Views\ShoppingCart\Index.cshtml"
     foreach (var item in Model.CartItems)
    {

#line default
#line hidden

            BeginContext(2395, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2406, "\"", 2431, 2);
            WriteAttributeValue("", 2411, "row-", 2411, 4, true);
#line 78 "\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2415, item.CartItemId, 2415, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2432, 37, true);
            WriteLiteral(">\r\n            <td>\r\n                ");
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f82593fd1b884eecb8d95e2828e4a3ec", async() => {
                BeginContext(2546, 16, false);
#line 80 "\Views\ShoppingCart\Index.cshtml"
                                                                                       Write(item.Album.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
#line 80 "\Views\ShoppingCart\Index.cshtml"
                                                                 WriteLiteral(item.AlbumId);

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
            BeginContext(2469, 97, false);
            Write(__tagHelperExecutionContext.Output);
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            BeginContext(2566, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2622, 16, false);
#line 83 "\Views\ShoppingCart\Index.cshtml"
           Write(item.Album.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2638, 36, true);
            WriteLiteral("\r\n            </td>\r\n            <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2674, "\"", 2706, 2);
            WriteAttributeValue("", 2679, "item-count-", 2679, 11, true);
#line 85 "\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2690, item.CartItemId, 2690, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2707, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(2727, 10, false);
#line 86 "\Views\ShoppingCart\Index.cshtml"
           Write(item.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2737, 95, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a href=\"#\" class=\"RemoveLink\" data-id=\"");
            EndContext();
            BeginContext(2833, 15, false);
#line 89 "\Views\ShoppingCart\Index.cshtml"
                                                   Write(item.CartItemId);

#line default
#line hidden
            EndContext();
            BeginContext(2848, 32, true);
            WriteLiteral("\"\r\n                   data-url=\'");
            EndContext();
            BeginContext(2881, 44, false);
#line 90 "\Views\ShoppingCart\Index.cshtml"
                        Write(Url.Content("~/ShoppingCart/RemoveFromCart"));

#line default
#line hidden
            EndContext();
            BeginContext(2925, 98, true);
            WriteLiteral("\'>\r\n                    Remove from cart\r\n                </a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 95 "\Views\ShoppingCart\Index.cshtml"
    }

#line default
#line hidden

            BeginContext(3030, 138, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            Total\r\n        </td>\r\n        <td></td>\r\n        <td></td>\r\n        <td id=\"cart-total\">\r\n            ");
            EndContext();
            BeginContext(3169, 15, false);
#line 103 "\Views\ShoppingCart\Index.cshtml"
       Write(Model.CartTotal);

#line default
#line hidden
            EndContext();
            BeginContext(3184, 36, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>");
            EndContext();
        }
        #pragma warning restore 1998
    }
}
