#pragma checksum "\Areas\Admin\Views\StoreManager\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ffd74742711110c72962276f4d364485315c211"
namespace MusicStore.Areas.Admin.Views.StoreManager
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using System.Threading.Tasks;

    public class Create : Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicStore.Models.Album>
    {
        #line hidden
        public Create()
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
        public Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicStore.Models.Album> Html { get; private set; }

        #line hidden

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 3 "\Areas\Admin\Views\StoreManager\Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden

            BeginContext(72, 21, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n");
            EndContext();
#line 9 "\Areas\Admin\Views\StoreManager\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden

            BeginContext(128, 23, false);
#line 11 "\Areas\Admin\Views\StoreManager\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
#line 11 "\Areas\Admin\Views\StoreManager\Create.cshtml"
                            


#line default
#line hidden

            BeginContext(155, 83, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Album</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(239, 28, false);
#line 16 "\Areas\Admin\Views\StoreManager\Create.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(267, 50, true);
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(318, 91, false);
#line 19 "\Areas\Admin\Views\StoreManager\Create.cshtml"
       Write(Html.LabelFor(model => model.GenreId, "GenreId", new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(409, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(465, 42, false);
#line 21 "\Areas\Admin\Views\StoreManager\Create.cshtml"
           Write(Html.DropDownList("GenreId", String.Empty));

#line default
#line hidden
            EndContext();
            BeginContext(507, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(526, 49, false);
#line 22 "\Areas\Admin\Views\StoreManager\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.GenreId));

#line default
#line hidden
            EndContext();
            BeginContext(575, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(662, 93, false);
#line 27 "\Areas\Admin\Views\StoreManager\Create.cshtml"
       Write(Html.LabelFor(model => model.ArtistId, "ArtistId", new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(755, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(811, 43, false);
#line 29 "\Areas\Admin\Views\StoreManager\Create.cshtml"
           Write(Html.DropDownList("ArtistId", String.Empty));

#line default
#line hidden
            EndContext();
            BeginContext(854, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(873, 50, false);
#line 30 "\Areas\Admin\Views\StoreManager\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.ArtistId));

#line default
#line hidden
            EndContext();
            BeginContext(923, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1010, 78, false);
#line 35 "\Areas\Admin\Views\StoreManager\Create.cshtml"
       Write(Html.LabelFor(model => model.Title, new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1144, 36, false);
#line 37 "\Areas\Admin\Views\StoreManager\Create.cshtml"
           Write(Html.EditorFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1199, 47, false);
#line 38 "\Areas\Admin\Views\StoreManager\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1246, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1333, 78, false);
#line 43 "\Areas\Admin\Views\StoreManager\Create.cshtml"
       Write(Html.LabelFor(model => model.Price, new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1467, 36, false);
#line 45 "\Areas\Admin\Views\StoreManager\Create.cshtml"
           Write(Html.EditorFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1503, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1522, 47, false);
#line 46 "\Areas\Admin\Views\StoreManager\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1656, 84, false);
#line 51 "\Areas\Admin\Views\StoreManager\Create.cshtml"
       Write(Html.LabelFor(model => model.AlbumArtUrl, new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1796, 42, false);
#line 53 "\Areas\Admin\Views\StoreManager\Create.cshtml"
           Write(Html.EditorFor(model => model.AlbumArtUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1838, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1857, 53, false);
#line 54 "\Areas\Admin\Views\StoreManager\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.AlbumArtUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1910, 255, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 64 "\Areas\Admin\Views\StoreManager\Create.cshtml"
}

#line default
#line hidden

            BeginContext(2168, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2182, 40, false);
#line 67 "\Areas\Admin\Views\StoreManager\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(2222, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async(__razor_section_writer) => {
                BeginContext(2252, 13, true);
                WriteLiteralTo(__razor_section_writer, "\r\n    <script");
                EndContext();
                BeginWriteAttributeTo(__razor_section_writer, "src", " src=\"", 2399, "\"", 2449, 1);
#line 73 "\Areas\Admin\Views\StoreManager\Create.cshtml"
WriteAttributeValueTo(__razor_section_writer, "", 2405, Url.Content("~/Scripts/jquery.validate.js"), 2405, 44, false);

#line default
#line hidden
                EndWriteAttributeTo(__razor_section_writer);
                BeginContext(2450, 23, true);
                WriteLiteralTo(__razor_section_writer, "></script>\r\n    <script");
                EndContext();
                BeginWriteAttributeTo(__razor_section_writer, "src", " src=\"", 2473, "\"", 2535, 1);
#line 74 "\Areas\Admin\Views\StoreManager\Create.cshtml"
WriteAttributeValueTo(__razor_section_writer, "", 2479, Url.Content("~/Scripts/jquery.validate.unobtrusive.js"), 2479, 56, false);

#line default
#line hidden
                EndWriteAttributeTo(__razor_section_writer);
                BeginContext(2536, 12, true);
                WriteLiteralTo(__razor_section_writer, "></script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
    }
}
