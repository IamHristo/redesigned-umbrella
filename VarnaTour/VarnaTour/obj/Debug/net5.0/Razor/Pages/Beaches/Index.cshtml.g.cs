#pragma checksum "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2809865d27687952edc2d8acf3e57284593a69a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VarnaTour.Pages.Beaches.Pages_Beaches_Index), @"mvc.1.0.razor-page", @"/Pages/Beaches/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2809865d27687952edc2d8acf3e57284593a69a9", @"/Pages/Beaches/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dbb1556ab3c32c02090bda67cb2322ef42ced4c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Beaches_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2809865d27687952edc2d8acf3e57284593a69a94656", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Beach[0].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Beach[0].Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Beach[0].MiniContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Beach[0].Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Beach[0].HasRestourant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Beach[0].HasLifeguard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Beach[0].HasMedicalStaff));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Beach[0].IsSuitableForChildren));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Beach[0].HasDressingRoom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Beach[0].HasShower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Beach[0].HasParking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Beach[0].HasCarAccess));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Beach[0].HasUmbrellaAndSunbed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Beach[0].IsDisabilitiesFriendly));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Beach[0].BeachType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 65 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
 foreach (var item in Model.Beach) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 2167, "\"", 2184, 1);
#nullable restore
#line 71 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
WriteAttributeValue("", 2173, item.Image, 2173, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2185, "\"", 2191, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px;height:100px;\">\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MiniContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HasRestourant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HasLifeguard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HasMedicalStaff));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsSuitableForChildren));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 92 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HasDressingRoom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 95 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HasShower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 98 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HasParking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 101 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HasCarAccess));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 104 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HasUmbrellaAndSunbed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 107 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsDisabilitiesFriendly));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 110 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BeachType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2809865d27687952edc2d8acf3e57284593a69a915665", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
                                       WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2809865d27687952edc2d8acf3e57284593a69a917810", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
                                          WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2809865d27687952edc2d8acf3e57284593a69a919961", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
                                         WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 118 "D:\Hackathon\VarnaTour\VarnaTour\Pages\Beaches\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VarnaTour.Pages.Beaches.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VarnaTour.Pages.Beaches.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VarnaTour.Pages.Beaches.IndexModel>)PageContext?.ViewData;
        public VarnaTour.Pages.Beaches.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
