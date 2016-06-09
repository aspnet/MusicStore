#pragma checksum "\Areas\Admin\Views\StoreManager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ae2ef08e50c4a3e7e0151221fa732caa3932e97"
namespace MusicStore.Areas.Admin.Views.StoreManager
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using System.Threading.Tasks;

    public class Index : Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MusicStore.Models.Album>>
    {
        #line hidden
        public Index()
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
        public Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MusicStore.Models.Album>> Html { get; private set; }

        #line hidden

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 3 "\Areas\Admin\Views\StoreManager\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden

            BeginContext(84, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(114, 39, false);
#line 10 "\Areas\Admin\Views\StoreManager\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(153, 67, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(221, 46, false);
#line 15 "\Areas\Admin\Views\StoreManager\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre.Name));

#line default
#line hidden
            EndContext();
            BeginContext(267, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(311, 64, false);
#line 18 "\Areas\Admin\Views\StoreManager\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstOrDefault().Artist.Name));

#line default
#line hidden
            EndContext();
            BeginContext(375, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(419, 58, false);
#line 21 "\Areas\Admin\Views\StoreManager\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstOrDefault().Title));

#line default
#line hidden
            EndContext();
            BeginContext(477, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(521, 58, false);
#line 24 "\Areas\Admin\Views\StoreManager\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstOrDefault().Price));

#line default
#line hidden
            EndContext();
            BeginContext(579, 49, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 29 "\Areas\Admin\Views\StoreManager\Index.cshtml"
    

#line default
#line hidden

#line 29 "\Areas\Admin\Views\StoreManager\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden

            BeginContext(669, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(718, 45, false);
#line 33 "\Areas\Admin\Views\StoreManager\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genre.Name));

#line default
#line hidden
            EndContext();
            BeginContext(763, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 36 "\Areas\Admin\Views\StoreManager\Index.cshtml"
                

#line default
#line hidden

#line 36 "\Areas\Admin\Views\StoreManager\Index.cshtml"
                 if (item.Artist.Name.Length <= 25)
                {
                    

#line default
#line hidden

            BeginContext(895, 16, false);
#line 38 "\Areas\Admin\Views\StoreManager\Index.cshtml"
               Write(item.Artist.Name);

#line default
#line hidden
            EndContext();
#line 38 "\Areas\Admin\Views\StoreManager\Index.cshtml"
                                     
                }
                else
                {
                    

#line default
#line hidden

            BeginContext(994, 33, false);
#line 42 "\Areas\Admin\Views\StoreManager\Index.cshtml"
               Write(item.Artist.Name.Substring(0, 25));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 3, true);
            WriteLiteral("...");
            EndContext();
#line 42 "\Areas\Admin\Views\StoreManager\Index.cshtml"
                                                                      
                }

#line default
#line hidden

            BeginContext(1064, 37, true);
            WriteLiteral("            </td>\r\n            <td>\r\n");
            EndContext();
#line 46 "\Areas\Admin\Views\StoreManager\Index.cshtml"
                

#line default
#line hidden

#line 46 "\Areas\Admin\Views\StoreManager\Index.cshtml"
                 if (item.Title.Length <= 25)
                {
                    

#line default
#line hidden

            BeginContext(1188, 10, false);
#line 48 "\Areas\Admin\Views\StoreManager\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
#line 48 "\Areas\Admin\Views\StoreManager\Index.cshtml"
                               
                }
                else
                {
                    

#line default
#line hidden

            BeginContext(1281, 27, false);
#line 52 "\Areas\Admin\Views\StoreManager\Index.cshtml"
               Write(item.Title.Substring(0, 25));

#line default
#line hidden
            EndContext();
            BeginContext(1314, 3, true);
            WriteLiteral("...");
            EndContext();
#line 52 "\Areas\Admin\Views\StoreManager\Index.cshtml"
                                                                
                }

#line default
#line hidden

            BeginContext(1345, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1399, 40, false);
#line 56 "\Areas\Admin\Views\StoreManager\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1495, 58, false);
#line 59 "\Areas\Admin\Views\StoreManager\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.AlbumId }));

#line default
#line hidden
            EndContext();
            BeginContext(1553, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1574, 64, false);
#line 60 "\Areas\Admin\Views\StoreManager\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.AlbumId }));

#line default
#line hidden
            EndContext();
            BeginContext(1638, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1659, 67, false);
#line 61 "\Areas\Admin\Views\StoreManager\Index.cshtml"
           Write(Html.ActionLink("Delete", "RemoveAlbum", new { id = item.AlbumId }));

#line default
#line hidden
            EndContext();
            BeginContext(1726, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "\Areas\Admin\Views\StoreManager\Index.cshtml"
    }

#line default
#line hidden

            BeginContext(1769, 10, true);
            WriteLiteral("\r\n</table>");
            EndContext();
        }
        #pragma warning restore 1998
    }
}
