#pragma checksum "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b400b04142c74e7a68a9cd7bb9edf1296ab3434d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VarnaTour.Pages.Beaches.Pages_Beaches_Delete), @"mvc.1.0.razor-page", @"/Pages/Beaches/Delete.cshtml")]
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
#line 1 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\_ViewImports.cshtml"
using VarnaTour;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\_ViewImports.cshtml"
using VarnaTour.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b400b04142c74e7a68a9cd7bb9edf1296ab3434d", @"/Pages/Beaches/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dbb1556ab3c32c02090bda67cb2322ef42ced4c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Beaches_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Beach</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Beach.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Beach.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Beach.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Beach.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Beach.MiniContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Beach.MiniContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Beach.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Beach.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Beach.HasRestourant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Beach.HasRestourant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Beach.HasLifeguard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Beach.HasLifeguard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Beach.HasMedicalStaff));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Beach.HasMedicalStaff));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Beach.IsSuitableForChildren));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Beach.IsSuitableForChildren));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Beach.HasDressingRoom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Beach.HasDressingRoom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Beach.HasShower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Beach.HasShower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Beach.HasParking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Beach.HasParking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Beach.HasCarAccess));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Beach.HasCarAccess));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Beach.HasUmbrellaAndSunbed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Beach.HasUmbrellaAndSunbed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 94 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Beach.IsDisabilitiesFriendly));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Beach.IsDisabilitiesFriendly));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 100 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Beach.BeachType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 103 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Beach.BeachType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b400b04142c74e7a68a9cd7bb9edf1296ab3434d16014", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b400b04142c74e7a68a9cd7bb9edf1296ab3434d16281", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 108 "E:\Hackathon Smart Solutions for Varna 2021\redesigned-umbrella\VarnaTour\VarnaTour\Pages\Beaches\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Beach.ID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b400b04142c74e7a68a9cd7bb9edf1296ab3434d18107", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VarnaTour.Pages.Beaches.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VarnaTour.Pages.Beaches.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VarnaTour.Pages.Beaches.DeleteModel>)PageContext?.ViewData;
        public VarnaTour.Pages.Beaches.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
