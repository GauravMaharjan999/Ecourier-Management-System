#pragma checksum "E:\StudentManagement\StudentManagementSystem\Views\Shared\Components\MenuBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fdc8b2cda239242a05fb3093c1a1fb9c88e3ff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MenuBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MenuBar/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MenuBar/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MenuBar_Default))]
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
#line 1 "E:\StudentManagement\StudentManagementSystem\Views\_ViewImports.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#line 2 "E:\StudentManagement\StudentManagementSystem\Views\_ViewImports.cshtml"
using StudentManagement.ViewModels;

#line default
#line hidden
#line 3 "E:\StudentManagement\StudentManagementSystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "E:\StudentManagement\StudentManagementSystem\Views\_ViewImports.cshtml"
using Modellayer.Models;

#line default
#line hidden
#line 5 "E:\StudentManagement\StudentManagementSystem\Views\_ViewImports.cshtml"
using Modellayer.Models.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fdc8b2cda239242a05fb3093c1a1fb9c88e3ff8", @"/Views/Shared/Components/MenuBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc2948818aa28a2e240679ddf3e1cf6b324cf832", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MenuBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Class", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("GET"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#main-div"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Userrole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 502, true);
            WriteLiteral(@"<div class=""sidebar-main sidebar-menu-one sidebar-expand-md sidebar-color"">
    <div class=""mobile-sidebar-header d-md-none"">
        <div class=""header-logo"">
            <a href=""index.html""><img src=""img/logo1.png"" alt=""logo""></a>
        </div>
    </div>
    <div class=""sidebar-menu-content"" style="" position: fixed; overflow-x: auto; width:260px "">
        <ul class=""nav nav-sidebar-menu sidebar-toggle-view"">
            <li class=""nav-item sidebar-nav-item"">

                <input");
            EndContext();
            BeginContext(574, 319, true);
            WriteLiteral(@" type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Search for names.."" title=""Type in a name"" style=""padding: 12px 33px; border: none; position: fixed; z-index: 10; "">

            </li>
        </ul>

        <ul class=""nav nav-sidebar-menu sidebar-toggle-view"" id=""myUL"" style=""margin-top: 50px;"">

");
            EndContext();
            BeginContext(1119, 627, true);
            WriteLiteral(@"            <li class=""nav-item sidebar-nav-item"">
                <a href=""#"" class=""nav-link""> <i class=""flaticon-dashboard""></i><span>Dashboard</span></a>

                <ul class=""nav sub-group-menu"">
                    <li class=""nav-item "">
                        <a href=""/admin/student/index""
                           id=""#studentIndex""
                           data-ajax=""true""
                           data-ajax-method=""GET"" data-ajax-mode=""replace""
                           data-ajax-update=""#main-div""
                           class=""nav-link""><i class=""fas fa-angle-right""></i>Student</a>
");
            EndContext();
            BeginContext(1875, 94, true);
            WriteLiteral("                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
            EndContext();
            BeginContext(1969, 328, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fdc8b2cda239242a05fb3093c1a1fb9c88e3ff810255", async() => {
                BeginContext(2198, 95, true);
                WriteLiteral("\r\n                            <i class=\"fas fa-angle-right\"></i>Class\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2297, 96, true);
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
            EndContext();
            BeginContext(2393, 274, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fdc8b2cda239242a05fb3093c1a1fb9c88e3ff812647", async() => {
                BeginContext(2625, 38, true);
                WriteLiteral("<i class=\"fas fa-angle-right\"></i>User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2667, 29, true);
            WriteLiteral("\r\n                    </li>\r\n");
            EndContext();
            BeginContext(2926, 44, true);
            WriteLiteral("                </ul>\r\n            </li>\r\n\r\n");
            EndContext();
#line 60 "E:\StudentManagement\StudentManagementSystem\Views\Shared\Components\MenuBar\Default.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(3027, 314, true);
            WriteLiteral(@"                <li class=""nav-item sidebar-nav-item"">
                    <a href=""#"" class=""nav-link""><i class=""flaticon-technological""></i><span>Manage Users and Roles</span></a>
                    <ul class=""nav sub-group-menu"">

                        <li class=""nav-item"">
                            ");
            EndContext();
            BeginContext(3341, 347, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fdc8b2cda239242a05fb3093c1a1fb9c88e3ff815679", async() => {
                BeginContext(3581, 103, true);
                WriteLiteral("\r\n                                <i class=\"fas fa-angle-right\"></i>Index\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3688, 108, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
            EndContext();
            BeginContext(3796, 350, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fdc8b2cda239242a05fb3093c1a1fb9c88e3ff818093", async() => {
                BeginContext(4033, 109, true);
                WriteLiteral("\r\n                                <i class=\"fas fa-angle-right\"></i>Create User\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4146, 108, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
            EndContext();
            BeginContext(4254, 359, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fdc8b2cda239242a05fb3093c1a1fb9c88e3ff820517", async() => {
                BeginContext(4495, 114, true);
                WriteLiteral("\r\n                                <i class=\"fas fa-angle-right\"></i>Create User Role\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4613, 85, true);
            WriteLiteral("\r\n                        </li>\r\n\r\n                    </ul>\r\n                </li>\r\n");
            EndContext();
            BeginContext(4700, 210, true);
            WriteLiteral("                <!--<li class=\"nav-item sidebar-nav-item\">\r\n        <a href=\"#\" class=\"nav-link\"><i class=\"flaticon-technological\"></i><span>Manage Users</span></a>\r\n        <ul class=\"nav sub-group-menu\">-->\r\n");
            EndContext();
            BeginContext(5302, 45, true);
            WriteLiteral("                <!--</ul>\r\n        </li>-->\r\n");
            EndContext();
#line 110 "E:\StudentManagement\StudentManagementSystem\Views\Shared\Components\MenuBar\Default.cshtml"

            }

#line default
#line hidden
            BeginContext(5364, 736, true);
            WriteLiteral(@"
            <li class=""nav-item sidebar-nav-item"">
                <a href=""#"" class=""nav-link""><i class=""flaticon-classmates""></i><span>Students</span></a>
                <ul class=""nav sub-group-menu"">
                    <li class=""nav-item"">
                        <a href=""/admin/student/index"" data-ajax=""true""
                           data-ajax-method=""GET"" data-ajax-mode=""replace"" data-ajax-loading=""#loader""
                           data-ajax-update=""#main-div"" class=""nav-link"">
                            <i class=""fas fa-angle-right""></i>All
                            Students
                        </a>
                    </li>

                    <li class=""nav-item"">
                        ");
            EndContext();
            BeginContext(6100, 340, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fdc8b2cda239242a05fb3093c1a1fb9c88e3ff824422", async() => {
                BeginContext(6332, 104, true);
                WriteLiteral("\r\n                            <i class=\"fas fa-angle-right\"></i>Admission Form\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6440, 33, true);
            WriteLiteral("\r\n\r\n\r\n                    </li>\r\n");
            EndContext();
            BeginContext(6596, 397, true);
            WriteLiteral(@"
                </ul>
            </li>
            <li class=""nav-item sidebar-nav-item"">
                <a href=""#"" class=""nav-link"">
                    <i class=""flaticon-maths-class-materials-cross-of-a-pencil-and-a-ruler""></i><span>Class</span>
                </a>
                <ul class=""nav sub-group-menu"">
                    <li class=""nav-item"">
                        ");
            EndContext();
            BeginContext(6993, 334, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fdc8b2cda239242a05fb3093c1a1fb9c88e3ff827277", async() => {
                BeginContext(7222, 101, true);
                WriteLiteral("\r\n                            <i class=\"fas fa-angle-right\"></i>All Classes\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7327, 96, true);
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
            EndContext();
            BeginContext(7423, 366, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fdc8b2cda239242a05fb3093c1a1fb9c88e3ff829676", async() => {
                BeginContext(7653, 132, true);
                WriteLiteral("\r\n                            <i class=\"fas fa-angle-right\"></i>Add New\r\n                            Class\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7789, 6006, true);
            WriteLiteral(@"
                    </li>
                </ul>
            </li>

            <li class=""nav-item sidebar-nav-item"">
                <a href=""#"" class=""nav-link"">
                    <i class=""flaticon-multiple-users-silhouette""></i><span>Teachers</span>
                </a>
                <ul class=""nav sub-group-menu"">
                    <li class=""nav-item"">
                        <a href=""all-teacher.html"" class=""nav-link"">
                            <i class=""fas fa-angle-right""></i>All
                            Teachers
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""teacher-details.html"" class=""nav-link"">
                            <i class=""fas fa-angle-right""></i>Teacher Details
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""add-teacher.html"" class=""nav-link"">
                            <i class=""fas fa-an");
            WriteLiteral(@"gle-right""></i>Add
                            Teacher
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""teacher-payment.html"" class=""nav-link"">
                            <i class=""fas fa-angle-right""></i>Payment
                        </a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item sidebar-nav-item"">
                <a href=""#"" class=""nav-link""><i class=""flaticon-couple""></i><span>Parents</span></a>
                <ul class=""nav sub-group-menu"">
                    <li class=""nav-item"">
                        <a href=""all-parents.html"" class=""nav-link"">
                            <i class=""fas fa-angle-right""></i>All
                            Parents
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""parents-details.html"" class=""nav-link"">
                            <");
            WriteLiteral(@"i class=""fas fa-angle-right""></i>Parents Details
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""add-parents.html"" class=""nav-link"">
                            <i class=""fas fa-angle-right""></i>Add
                            Parent
                        </a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item sidebar-nav-item"">
                <a href=""#"" class=""nav-link""><i class=""flaticon-books""></i><span>Library</span></a>
                <ul class=""nav sub-group-menu"">
                    <li class=""nav-item"">
                        <a href=""all-book.html"" class=""nav-link"">
                            <i class=""fas fa-angle-right""></i>All
                            Book
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""add-book.html"" class=""nav-link"">
                      ");
            WriteLiteral(@"      <i class=""fas fa-angle-right""></i>Add New
                            Book
                        </a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item sidebar-nav-item"">
                <a href=""#"" class=""nav-link""><i class=""flaticon-technological""></i><span>Account</span></a>
                <ul class=""nav sub-group-menu"">
                    <li class=""nav-item"">
                        <a href=""all-fees.html"" class=""nav-link"">
                            <i class=""fas fa-angle-right""></i>All Fees
                            Collection
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""all-expense.html"" class=""nav-link"">
                            <i class=""fas fa-angle-right""></i>Expenses
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""add-expense.html"" class=""nav-link"">");
            WriteLiteral(@"
                            <i class=""fas fa-angle-right""></i>Add
                            Expenses
                        </a>
                    </li>
                </ul>
            </li>






            <li class=""nav-item sidebar-nav-item"">
                <a href=""#"" class=""nav-link""><i class=""flaticon-dashboard""></i><span>Routine</span></a>


            </li>

            <li class=""nav-item sidebar-nav-item"">
                <a href=""#"" class=""nav-link""><i class=""flaticon-dashboard""></i><span>Routine</span></a>


            </li>

            <li class=""nav-item sidebar-nav-item"">
                <a href=""#"" class=""nav-link""><i class=""flaticon-dashboard""></i><span>Routine</span></a>


            </li>

            <li class=""nav-item sidebar-nav-item"">
                <a href=""#"" class=""nav-link""><i class=""flaticon-dashboard""></i><span>Routine</span></a>


            </li>

            <li class=""nav-item sidebar-nav-item"">
                <a href=""#");
            WriteLiteral(@""" class=""nav-link""><i class=""flaticon-dashboard""></i><span>Routine</span></a>


            </li>

        </ul>
    </div>
</div>




<script>
    
    function myFunction() {
        
        var input, filter, ul, li, a, i, txtValue;

   

        input = document.getElementById(""myInput"");

        filter = input.value.toUpperCase();

        ul = document.getElementById(""myUL"");
        debugger;   
     
        li = ul.getElementsByClassName(""nav-item sidebar-nav-item"")
        for (i = 0; i < li.length; i++) {

            a = li[i].getElementsByTagName(""a"")[0];
            txtValue = a.textContent || a.innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                li[i].style.display = """";
            } else {
                li[i].style.display = ""none"";
            }
        }
    }
</script>


");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> signInManager { get; private set; }
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
