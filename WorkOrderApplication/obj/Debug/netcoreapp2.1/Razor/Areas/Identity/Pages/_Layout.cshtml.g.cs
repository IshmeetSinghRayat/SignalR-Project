#pragma checksum "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Areas\Identity\Pages\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9de91c63c4889e2dc7477bd47b75792770ad9930"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WorkOrderApplication.Areas.Identity.Pages.Areas_Identity_Pages__Layout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Pages/_Layout.cshtml", typeof(WorkOrderApplication.Areas.Identity.Pages.Areas_Identity_Pages__Layout))]
namespace WorkOrderApplication.Areas.Identity.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Areas\Identity\Pages\_ViewImports.cshtml"
using WorkOrderApplication.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Areas\Identity\Pages\_ViewImports.cshtml"
using WorkOrderApplication.Areas.Identity.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de91c63c4889e2dc7477bd47b75792770ad9930", @"/Areas/Identity/Pages/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cc7714c32406b550d1d78df0d986edd81846f5f", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Areas\Identity\Pages\_Layout.cshtml"
  
    Layout = "/Views/Shared/_RegistrationLayout.cshtml";

#line default
#line hidden
            BeginContext(65, 80, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-xs-12 col-md-12 offset-md-3\">\r\n        ");
            EndContext();
            BeginContext(145, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0347cf4e69c445fa7632a832f64940f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(189, 800, true);
            WriteLiteral(@"

    </div>
</div>
<hr />
<div class=""row"">
    <div class=""col-md-3"">

    </div>
    <div class=""col-xs-12 col-md-6 offset-md-3"">
        <div class=""card login-logout-tab"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs card-header-tabs"">
                    <li class=""nav-item"">

                        <a class=""nav-link"" href=""/Identity/Account/Login"">Log In</a>
                    </li>
                    <li class=""nav-item"">

                        <a class=""nav-link"" href=""/Identity/Account/Register"">Sign Up </a>
                    </li>
                </ul>
            </div>
            <div class=""card-content"">

                <div class=""row"">
                    <div class=""col-md-12 "">
                        ");
            EndContext();
            BeginContext(990, 12, false);
#line 34 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Areas\Identity\Pages\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(1002, 112, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1131, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1140, 41, false);
#line 44 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Areas\Identity\Pages\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(1181, 357, true);
                WriteLiteral(@"
    <script>

        $(function () {

            var current = location.pathname;
            $('.nav-tabs li a').each(function () {
                var $this = $(this);
                if (current.indexOf($this.attr('href')) !== -1) {
                    $this.addClass('active');
                }
            })
        })
    </script>
");
                EndContext();
            }
            );
            BeginContext(1539, 4, true);
            WriteLiteral("    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
