#pragma checksum "\Areas\Admin\Views\StoreManager\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "834fb5ae2e1928f027ffafce641084ca6bd7a543"
namespace MusicStore.Areas.Admin.Views.StoreManager
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using System.Threading.Tasks;

    public class Edit : Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicStore.Models.Album>
    {
        #line hidden
        public Edit()
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
#line 3 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden

            BeginContext(70, 19, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n");
            EndContext();
#line 9 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden

            BeginContext(124, 23, false);
#line 11 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
#line 11 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
                            


#line default
#line hidden

            BeginContext(151, 83, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Album</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(235, 28, false);
#line 16 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(263, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(274, 38, false);
#line 17 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
   Write(Html.HiddenFor(model => model.AlbumId));

#line default
#line hidden
            EndContext();
            BeginContext(312, 50, true);
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(363, 91, false);
#line 20 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
       Write(Html.LabelFor(model => model.GenreId, "GenreId", new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(454, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(510, 42, false);
#line 22 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
           Write(Html.DropDownList("GenreId", String.Empty));

#line default
#line hidden
            EndContext();
            BeginContext(552, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(571, 49, false);
#line 23 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.GenreId));

#line default
#line hidden
            EndContext();
            BeginContext(620, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(707, 93, false);
#line 28 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
       Write(Html.LabelFor(model => model.ArtistId, "ArtistId", new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(800, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(856, 43, false);
#line 30 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
           Write(Html.DropDownList("ArtistId", String.Empty));

#line default
#line hidden
            EndContext();
            BeginContext(899, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(918, 50, false);
#line 31 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.ArtistId));

#line default
#line hidden
            EndContext();
            BeginContext(968, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1055, 78, false);
#line 36 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
       Write(Html.LabelFor(model => model.Title, new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1189, 36, false);
#line 38 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
           Write(Html.EditorFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1244, 47, false);
#line 39 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1291, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1378, 78, false);
#line 44 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
       Write(Html.LabelFor(model => model.Price, new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1512, 36, false);
#line 46 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
           Write(Html.EditorFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1548, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1567, 47, false);
#line 47 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1614, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1701, 84, false);
#line 52 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
       Write(Html.LabelFor(model => model.AlbumArtUrl, new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1785, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1841, 42, false);
#line 54 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
           Write(Html.EditorFor(model => model.AlbumArtUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1883, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1902, 53, false);
#line 55 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.AlbumArtUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1955, 253, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 65 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
}

#line default
#line hidden

            BeginContext(2211, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2225, 40, false);
#line 68 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(2265, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async(__razor_section_writer) => {
                BeginContext(2295, 13, true);
                WriteLiteralTo(__razor_section_writer, "\r\n    <script");
                EndContext();
                BeginWriteAttributeTo(__razor_section_writer, "src", " src=\"", 2442, "\"", 2492, 1);
#line 74 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
WriteAttributeValueTo(__razor_section_writer, "", 2448, Url.Content("~/Scripts/jquery.validate.js"), 2448, 44, false);

#line default
#line hidden
                EndWriteAttributeTo(__razor_section_writer);
                BeginContext(2493, 23, true);
                WriteLiteralTo(__razor_section_writer, "></script>\r\n    <script");
                EndContext();
                BeginWriteAttributeTo(__razor_section_writer, "src", " src=\"", 2516, "\"", 2578, 1);
#line 75 "\Areas\Admin\Views\StoreManager\Edit.cshtml"
WriteAttributeValueTo(__razor_section_writer, "", 2522, Url.Content("~/Scripts/jquery.validate.unobtrusive.js"), 2522, 56, false);

#line default
#line hidden
                EndWriteAttributeTo(__razor_section_writer);
                BeginContext(2579, 12, true);
                WriteLiteralTo(__razor_section_writer, "></script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
    }
}
