#pragma checksum "G:\CShape_Study\03-Tutorial\03-Tutorial.Web\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f61460f2621ea27edfb91d4e7acee82ff6db3dd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "G:\CShape_Study\03-Tutorial\03-Tutorial.Web\Views\_ViewImports.cshtml"
using _03_Tutorial.Web.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f61460f2621ea27edfb91d4e7acee82ff6db3dd0", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cfb76f6205ecb13b100f8104e94ed36b48b12b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_03_Tutorial.Web.model.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewModelTest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\CShape_Study\03-Tutorial\03-Tutorial.Web\Views\Home\Detail.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(67, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(96, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f61460f2621ea27edfb91d4e7acee82ff6db3dd03803", async() => {
                BeginContext(102, 88, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Detail</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(197, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(199, 506, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f61460f2621ea27edfb91d4e7acee82ff6db3dd05079", async() => {
                BeginContext(205, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(216, 15, false);
#line 14 "G:\CShape_Study\03-Tutorial\03-Tutorial.Web\Views\Home\Detail.cshtml"
   Write(Model.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(231, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(233, 14, false);
#line 14 "G:\CShape_Study\03-Tutorial\03-Tutorial.Web\Views\Home\Detail.cshtml"
                    Write(Model.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(247, 11, true);
                WriteLiteral("</h1>\r\n    ");
                EndContext();
                BeginContext(258, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f61460f2621ea27edfb91d4e7acee82ff6db3dd06158", async() => {
                    BeginContext(288, 33, true);
                    WriteLiteral("返回到HomeController的ViewModelTest方法");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(325, 71, true);
                WriteLiteral("\r\n    <hr />\r\n    \r\n    <div>\r\n        <h2>学生信息</h2>\r\n        <div>ID: ");
                EndContext();
                BeginContext(397, 8, false);
#line 20 "G:\CShape_Study\03-Tutorial\03-Tutorial.Web\Views\Home\Detail.cshtml"
            Write(Model.Id);

#line default
#line hidden
                EndContext();
                BeginContext(405, 31, true);
                WriteLiteral("</div><br />\r\n        <div>姓名: ");
                EndContext();
                BeginContext(437, 15, false);
#line 21 "G:\CShape_Study\03-Tutorial\03-Tutorial.Web\Views\Home\Detail.cshtml"
            Write(Model.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(452, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(454, 14, false);
#line 21 "G:\CShape_Study\03-Tutorial\03-Tutorial.Web\Views\Home\Detail.cshtml"
                             Write(Model.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(468, 31, true);
                WriteLiteral("</div><br />\r\n        <div>性别: ");
                EndContext();
                BeginContext(500, 12, false);
#line 22 "G:\CShape_Study\03-Tutorial\03-Tutorial.Web\Views\Home\Detail.cshtml"
            Write(Model.Gender);

#line default
#line hidden
                EndContext();
                BeginContext(512, 33, true);
                WriteLiteral("</div><br />\r\n        <div>出生日期: ");
                EndContext();
                BeginContext(546, 37, false);
#line 23 "G:\CShape_Study\03-Tutorial\03-Tutorial.Web\Views\Home\Detail.cshtml"
              Write(Model.BrithDate.ToString("yyy-MM-dd"));

#line default
#line hidden
                EndContext();
                BeginContext(583, 44, true);
                WriteLiteral("</div><br />\r\n    </div><br />\r\n\r\n          ");
                EndContext();
                BeginContext(627, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f61460f2621ea27edfb91d4e7acee82ff6db3dd09596", async() => {
                    BeginContext(657, 33, true);
                    WriteLiteral("返回到HomeController的ViewModelTest方法");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(694, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(705, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_03_Tutorial.Web.model.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591