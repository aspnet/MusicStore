#pragma checksum "\Areas\Admin\Views\StoreManager\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77a7e15cd34442f3ce67f61e651ffa8a00578993"
namespace MusicStore.Areas.Admin.Views.StoreManager
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using System.Threading.Tasks;

    public class Details : Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicStore.Models.Album>
    {
        #line hidden
        public Details()
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
#line 3 "\Areas\Admin\Views\StoreManager\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden

            BeginContext(73, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Album</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(193, 47, false);
#line 14 "\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Artist.Name));

#line default
#line hidden
            EndContext();
            BeginContext(240, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(286, 43, false);
#line 18 "\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayFor(model => model.Artist.Name));

#line default
#line hidden
            EndContext();
            BeginContext(329, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(375, 46, false);
#line 22 "\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre.Name));

#line default
#line hidden
            EndContext();
            BeginContext(421, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(467, 42, false);
#line 26 "\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayFor(model => model.Genre.Name));

#line default
#line hidden
            EndContext();
            BeginContext(509, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(555, 41, false);
#line 30 "\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(596, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(642, 37, false);
#line 34 "\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(679, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(725, 41, false);
#line 38 "\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(766, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(812, 37, false);
#line 42 "\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(849, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(895, 47, false);
#line 46 "\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AlbumArtUrl));

#line default
#line hidden
            EndContext();
            BeginContext(942, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(988, 43, false);
#line 50 "\Areas\Admin\Views\StoreManager\Details.cshtml"
       Write(Html.DisplayFor(model => model.AlbumArtUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1031, 47, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(1079, 59, false);
#line 56 "\Areas\Admin\Views\StoreManager\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.AlbumId }));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1147, 40, false);
#line 57 "\Areas\Admin\Views\StoreManager\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 6, true);
            WriteLiteral("\r\n</p>");
            EndContext();
        }
        #pragma warning restore 1998
    }
}
