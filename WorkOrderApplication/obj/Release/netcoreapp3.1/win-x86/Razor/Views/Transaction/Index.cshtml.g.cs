#pragma checksum "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\Transaction\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aa30637f45698b5ee7df0ab9fc6b92ee5f70775"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_Index), @"mvc.1.0.view", @"/Views/Transaction/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transaction/Index.cshtml", typeof(AspNetCore.Views_Transaction_Index))]
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
#line 1 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\_ViewImports.cshtml"
using WorkOrderApplication;

#line default
#line hidden
#line 2 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\_ViewImports.cshtml"
using WorkOrderApplication.Models;

#line default
#line hidden
#line 3 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aa30637f45698b5ee7df0ab9fc6b92ee5f70775", @"/Views/Transaction/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13efe7e9ea089ce44c248558b165d23b7f0e3b4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WorkOrderCore.Model.JobcardTransactionsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-viewType", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\Transaction\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(113, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(142, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6aa30637f45698b5ee7df0ab9fc6b92ee5f707754731", async() => {
                BeginContext(189, 18, true);
                WriteLiteral("Create Transaction");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(211, 623, true);
            WriteLiteral(@"

</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Job Name
            </th>
            <th>
                Transaction Start Date
            </th>
            <th>
                Transaction End Date
            </th>
            <th>
                Transaction Status
            </th>
            <th>
                Transaction Close At
            </th>
            <th>
                Assigned Employee
            </th>
            <th>
                Priority
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 41 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\Transaction\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(883, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(944, 12, false);
#line 45 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\Transaction\Index.cshtml"
               Write(item.JobName);

#line default
#line hidden
            EndContext();
            BeginContext(956, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1024, 65, false);
#line 48 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\Transaction\Index.cshtml"
               Write(item.JobCardsTransactionsStartDate.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1089, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1157, 63, false);
#line 51 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\Transaction\Index.cshtml"
               Write(item.JobCardsTransactionsEndDate.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1220, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1288, 61, false);
#line 54 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\Transaction\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.JobCardsTransactionsStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 57 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\Transaction\Index.cshtml"
                     if (item.JobCardsTransactionsClosedAt != null)
                    {
                        

#line default
#line hidden
            BeginContext(1513, 70, false);
#line 59 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\Transaction\Index.cshtml"
                   Write(item.JobCardsTransactionsClosedAt.Value.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
#line 59 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\Transaction\Index.cshtml"
                                                                                               
                    }

#line default
#line hidden
            BeginContext(1608, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1674, 51, false);
#line 63 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\Transaction\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EmployeeFullName));

#line default
#line hidden
            EndContext();
            BeginContext(1725, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1793, 51, false);
#line 66 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\Transaction\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PrioritySequence));

#line default
#line hidden
            EndContext();
            BeginContext(1844, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1911, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6aa30637f45698b5ee7df0ab9fc6b92ee5f7077510834", async() => {
                BeginContext(2008, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\Transaction\Index.cshtml"
                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-viewType", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["viewType"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2016, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2185, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 74 "C:\Users\dell\Documents\WorkOrder2.2\WorkOrderApplication\Views\Transaction\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2238, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WorkOrderCore.Model.JobcardTransactionsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
