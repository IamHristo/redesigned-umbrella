#pragma checksum "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\BeachesDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c7692cddd8ee94516b5c49dc95a62e9c515a4bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VarnaTour.Pages.Beaches.Pages_Beaches_BeachesDetails), @"mvc.1.0.razor-page", @"/Pages/Beaches/BeachesDetails.cshtml")]
namespace VarnaTour.Pages.Beaches
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Hackathon\VarnaTour\VarnaTour\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Hackathon\VarnaTour\VarnaTour\Pages\_ViewImports.cshtml"
using VarnaTour;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Hackathon\VarnaTour\VarnaTour\Pages\_ViewImports.cshtml"
using VarnaTour.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c7692cddd8ee94516b5c49dc95a62e9c515a4bb", @"/Pages/Beaches/BeachesDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dbb1556ab3c32c02090bda67cb2322ef42ced4c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Beaches_BeachesDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\BeachesDetails.cshtml"
  
    ViewData["Title"] = "BeachesDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>Beaches Details</h1>\r\n\r\n");
#nullable restore
#line 12 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\BeachesDetails.cshtml"
 foreach (var item in Model.Beach)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"flip-card\">\r\n        <div class=\"flip-card-inner\">\r\n            <div class=\"flip-card-front\">\r\n                <h1>");
#nullable restore
#line 18 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\BeachesDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 387, "\"", 404, 1);
#nullable restore
#line 20 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\BeachesDetails.cshtml"
WriteAttributeValue("", 393, item.Image, 393, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 405, "\"", 411, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:300px;height:300px;\">\r\n            </div>\r\n            <div class=\"flip-card-back\">\r\n                <p>");
#nullable restore
#line 23 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\BeachesDetails.cshtml"
              Write(Html.DisplayFor(modelItem => item.MiniContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 24 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\BeachesDetails.cshtml"
              Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 28 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\BeachesDetails.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VarnaTour.Pages.Beaches.BeachesDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VarnaTour.Pages.Beaches.BeachesDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VarnaTour.Pages.Beaches.BeachesDetailsModel>)PageContext?.ViewData;
        public VarnaTour.Pages.Beaches.BeachesDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
