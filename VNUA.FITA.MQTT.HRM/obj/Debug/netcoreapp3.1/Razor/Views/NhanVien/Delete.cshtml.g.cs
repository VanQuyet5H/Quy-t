#pragma checksum "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b62f0ff3c42b655f7458daee2201ba458eab67c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_Delete), @"mvc.1.0.view", @"/Views/NhanVien/Delete.cshtml")]
namespace AspNetCore
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
#line 1 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\_ViewImports.cshtml"
using VNUA.FITA.MQTT.HRM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\_ViewImports.cshtml"
using VNUA.FITA.MQTT.HRM.Data.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b62f0ff3c42b655f7458daee2201ba458eab67c", @"/Views/NhanVien/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7673812a3da907be0d7ddfa10a2fdab1682e1c87", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VNUA.FITA.MQTT.HRM.Data.Model.NhanVien>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>NhanVien</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaNhanVien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaNhanVien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HoTen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NgaySinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 60 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ChucVu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 63 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ChucVu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 66 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Anh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 69 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Anh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 72 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SoCCCD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 75 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SoCCCD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 78 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TrinhDo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 81 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TrinhDo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 84 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BoPhans));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 87 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BoPhans.IdBoPhan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b62f0ff3c42b655f7458daee2201ba458eab67c13310", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b62f0ff3c42b655f7458daee2201ba458eab67c13577", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 92 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdNhanVien);

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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b62f0ff3c42b655f7458daee2201ba458eab67c15400", async() => {
                    WriteLiteral("Quay l???i danh s??ch nh??n vi??n");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 98 "E:\ThucTap\3\VNUA_FITA_HRM\VNUA_FITA_HRM\VNUA.FITA.MQTT.HRM\VNUA.FITA.MQTT.HRM\Views\NhanVien\Delete.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VNUA.FITA.MQTT.HRM.Data.Model.NhanVien> Html { get; private set; }
    }
}
#pragma warning restore 1591
