#pragma checksum "\Areas\Admin\Views\StoreManager\RemoveAlbum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46eb0921b7395059abb8d42ff381139f9b10d8ea"
namespace MusicStore.Areas.Admin.Views.StoreManager
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using System.Threading.Tasks;

    public class RemoveAlbum : Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicStore.Models.Album>
    {
        #line hidden
        public RemoveAlbum()
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
#line 3 "\Areas\Admin\Views\StoreManager\RemoveAlbum.cshtml"
  
    ViewBag.Title = "Delete";

#line default
#line hidden

            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "\Areas\Admin\Views\StoreManager\RemoveAlbum.cshtml"
 if (Model != null)
{

#line default
#line hidden

            BeginContext(98, 34, true);
            WriteLiteral("    <h2>Delete Confirmation</h2>\r\n");
            EndContext();
#line 10 "\Areas\Admin\Views\StoreManager\RemoveAlbum.cshtml"


#line default
#line hidden

            BeginContext(134, 83, true);
            WriteLiteral("    <p>\r\n        Are you sure you want to delete the album titled\r\n        <strong>");
            EndContext();
            BeginContext(218, 11, false);
#line 13 "\Areas\Admin\Views\StoreManager\RemoveAlbum.cshtml"
           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(229, 22, true);
            WriteLiteral("</strong>?\r\n    </p>\r\n");
            EndContext();
#line 15 "\Areas\Admin\Views\StoreManager\RemoveAlbum.cshtml"

    

#line default
#line hidden

#line 16 "\Areas\Admin\Views\StoreManager\RemoveAlbum.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden

            BeginContext(291, 104, true);
            WriteLiteral("        <p>\r\n            <input type=\"submit\" value=\"Delete\" />\r\n        </p>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(396, 40, false);
#line 22 "\Areas\Admin\Views\StoreManager\RemoveAlbum.cshtml"
       Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(436, 16, true);
            WriteLiteral("\r\n        </p>\r\n");
            EndContext();
#line 24 "\Areas\Admin\Views\StoreManager\RemoveAlbum.cshtml"
    }

#line default
#line hidden

#line 24 "\Areas\Admin\Views\StoreManager\RemoveAlbum.cshtml"
     
}
else
{
    

#line default
#line hidden

            BeginContext(476, 46, false);
#line 28 "\Areas\Admin\Views\StoreManager\RemoveAlbum.cshtml"
Write(Html.Label(null, "Unable to locate the album"));

#line default
#line hidden
            EndContext();
#line 28 "\Areas\Admin\Views\StoreManager\RemoveAlbum.cshtml"
                                                   
}

#line default
#line hidden

        }
        #pragma warning restore 1998
    }
}
