#pragma checksum "C:\Users\racir\source\repos\LaunchCode\csharpClass18Authentication\codingEventsWithAuthentication\CodingEvents\Views\Events\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6754664d78b793db1c5de2a1aa7af2d2c1a48f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Edit), @"mvc.1.0.view", @"/Views/Events/Edit.cshtml")]
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
#line 1 "C:\Users\racir\source\repos\LaunchCode\csharpClass18Authentication\codingEventsWithAuthentication\CodingEvents\Views\_ViewImports.cshtml"
using CodingEvents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\racir\source\repos\LaunchCode\csharpClass18Authentication\codingEventsWithAuthentication\CodingEvents\Views\_ViewImports.cshtml"
using CodingEvents.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6754664d78b793db1c5de2a1aa7af2d2c1a48f2", @"/Views/Events/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc2964dd59c32e4df324b99d9423fb70affcb2b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/events/edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \r\n<h1>Edit Event</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6754664d78b793db1c5de2a1aa7af2d2c1a48f24070", async() => {
                WriteLiteral("\r\n    <label>\r\n        Name of Event:\r\n        <input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 213, "\"", 244, 1);
#nullable restore
#line 10 "C:\Users\racir\source\repos\LaunchCode\csharpClass18Authentication\codingEventsWithAuthentication\CodingEvents\Views\Events\Edit.cshtml"
WriteAttributeValue("", 221, ViewBag.editEvent.Name, 221, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </label>\r\n    <br />\r\n\r\n    <label>\r\n        Event location:\r\n        <input type=\"text\" name=\"location\"");
                BeginWriteAttribute("value", " value=\"", 358, "\"", 393, 1);
#nullable restore
#line 16 "C:\Users\racir\source\repos\LaunchCode\csharpClass18Authentication\codingEventsWithAuthentication\CodingEvents\Views\Events\Edit.cshtml"
WriteAttributeValue("", 366, ViewBag.editEvent.Location, 366, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </label>\r\n    <br />\r\n\r\n    <label>\r\n        Description:\r\n        <input type=\"text\" name=\"description\"");
                BeginWriteAttribute("value", " value=\"", 507, "\"", 545, 1);
#nullable restore
#line 22 "C:\Users\racir\source\repos\LaunchCode\csharpClass18Authentication\codingEventsWithAuthentication\CodingEvents\Views\Events\Edit.cshtml"
WriteAttributeValue("", 515, ViewBag.editEvent.Description, 515, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </label>\r\n    <br />\r\n\r\n    <label>\r\n        No. of Attendees:\r\n        <input type=\"text\" name=\"noOfAttendees\"");
                BeginWriteAttribute("value", " value=\"", 666, "\"", 706, 1);
#nullable restore
#line 28 "C:\Users\racir\source\repos\LaunchCode\csharpClass18Authentication\codingEventsWithAuthentication\CodingEvents\Views\Events\Edit.cshtml"
WriteAttributeValue("", 674, ViewBag.editEvent.NoOfAttendees, 674, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </label>\r\n    <br />\r\n\r\n    <label>\r\n        Contact Email:\r\n        <input type=\"email\" name=\"contactEmail\"");
                BeginWriteAttribute("value", " value=\"", 824, "\"", 863, 1);
#nullable restore
#line 34 "C:\Users\racir\source\repos\LaunchCode\csharpClass18Authentication\codingEventsWithAuthentication\CodingEvents\Views\Events\Edit.cshtml"
WriteAttributeValue("", 832, ViewBag.editEvent.ContactEmail, 832, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </label>\r\n    <br />\r\n\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 921, "\"", 950, 1);
#nullable restore
#line 38 "C:\Users\racir\source\repos\LaunchCode\csharpClass18Authentication\codingEventsWithAuthentication\CodingEvents\Views\Events\Edit.cshtml"
WriteAttributeValue("", 929, ViewBag.editEvent.Id, 929, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"eventId\" />\r\n    <input type=\"submit\" value=\"Edit Event\" class=\"btn btn-secondary\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
