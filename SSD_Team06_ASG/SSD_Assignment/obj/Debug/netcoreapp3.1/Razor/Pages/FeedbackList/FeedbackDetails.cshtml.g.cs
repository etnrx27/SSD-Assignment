#pragma checksum "E:\Np_Year_2.1\SSD Prac\SSD_Team06_ASG_Submission\SSD_Assignment\Pages\FeedbackList\FeedbackDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c9d78ff775a8577228c390f3907266e88358ae9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SSD_Assignment.Pages.FeedbackList.Pages_FeedbackList_FeedbackDetails), @"mvc.1.0.razor-page", @"/Pages/FeedbackList/FeedbackDetails.cshtml")]
namespace SSD_Assignment.Pages.FeedbackList
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
#line 1 "E:\Np_Year_2.1\SSD Prac\SSD_Team06_ASG_Submission\SSD_Assignment\Pages\_ViewImports.cshtml"
using SSD_Assignment;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9d78ff775a8577228c390f3907266e88358ae9", @"/Pages/FeedbackList/FeedbackDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3872845f068c377210764579bc63f3e798b3ab41", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FeedbackList_FeedbackDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./FeedbackDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Feedback", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "E:\Np_Year_2.1\SSD Prac\SSD_Team06_ASG_Submission\SSD_Assignment\Pages\FeedbackList\FeedbackDetails.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Feedback Details</h1>\r\n");
#nullable restore
#line 7 "E:\Np_Year_2.1\SSD Prac\SSD_Team06_ASG_Submission\SSD_Assignment\Pages\FeedbackList\FeedbackDetails.cshtml"
 for (var item = 0; item < Model.FeedbackList.Count; item++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-sm-8\">\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 13 "E:\Np_Year_2.1\SSD Prac\SSD_Team06_ASG_Submission\SSD_Assignment\Pages\FeedbackList\FeedbackDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.FeedbackList[item].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 16 "E:\Np_Year_2.1\SSD Prac\SSD_Team06_ASG_Submission\SSD_Assignment\Pages\FeedbackList\FeedbackDetails.cshtml"
               Write(Html.DisplayFor(model => model.FeedbackList[item].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 19 "E:\Np_Year_2.1\SSD Prac\SSD_Team06_ASG_Submission\SSD_Assignment\Pages\FeedbackList\FeedbackDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.FeedbackList[item].Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 22 "E:\Np_Year_2.1\SSD Prac\SSD_Team06_ASG_Submission\SSD_Assignment\Pages\FeedbackList\FeedbackDetails.cshtml"
               Write(Html.DisplayFor(model => model.FeedbackList[item].Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 25 "E:\Np_Year_2.1\SSD Prac\SSD_Team06_ASG_Submission\SSD_Assignment\Pages\FeedbackList\FeedbackDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.FeedbackList[item].Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 28 "E:\Np_Year_2.1\SSD Prac\SSD_Team06_ASG_Submission\SSD_Assignment\Pages\FeedbackList\FeedbackDetails.cshtml"
               Write(Html.DisplayFor(model => model.FeedbackList[item].Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 31 "E:\Np_Year_2.1\SSD Prac\SSD_Team06_ASG_Submission\SSD_Assignment\Pages\FeedbackList\FeedbackDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.FeedbackList[item].Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 34 "E:\Np_Year_2.1\SSD Prac\SSD_Team06_ASG_Submission\SSD_Assignment\Pages\FeedbackList\FeedbackDetails.cshtml"
               Write(Html.DisplayFor(model => model.FeedbackList[item].Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dd>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c9d78ff775a8577228c390f3907266e88358ae97476", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "E:\Np_Year_2.1\SSD Prac\SSD_Team06_ASG_Submission\SSD_Assignment\Pages\FeedbackList\FeedbackDetails.cshtml"
                                                     WriteLiteral(Model.FeedbackList[item].ID);

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
            WriteLiteral(" \r\n                </dd>\r\n\r\n            </dl>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 43 "E:\Np_Year_2.1\SSD Prac\SSD_Team06_ASG_Submission\SSD_Assignment\Pages\FeedbackList\FeedbackDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c9d78ff775a8577228c390f3907266e88358ae99958", async() => {
                WriteLiteral("Back to Form");
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
            WriteLiteral("\r\n<style>\r\n    dl {\r\n        border-bottom: 7px solid cyan;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesBook.Pages.FeedbackList.FeedbackDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesBook.Pages.FeedbackList.FeedbackDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesBook.Pages.FeedbackList.FeedbackDetailsModel>)PageContext?.ViewData;
        public RazorPagesBook.Pages.FeedbackList.FeedbackDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591