#pragma checksum "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78cfba92ad5bf22f90bfcf26706144ced0045e2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Student_Delete___Copy__2_), @"mvc.1.0.view", @"/Areas/Admin/Views/Student/Delete - Copy (2).cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Student/Delete - Copy (2).cshtml", typeof(AspNetCore.Areas_Admin_Views_Student_Delete___Copy__2_))]
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
#line 1 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#line 2 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentManagement.ViewModels;

#line default
#line hidden
#line 3 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using Modellayer.Models;

#line default
#line hidden
#line 5 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using Modellayer.Models.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78cfba92ad5bf22f90bfcf26706144ced0045e2d", @"/Areas/Admin/Views/Student/Delete - Copy (2).cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e14f4efd3e7e78ebc3de210c68c40dc2fe2035", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Student_Delete___Copy__2_ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-fill-lg bg-blue-dark btn-hover-yellow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml"
  
    ViewBag.Title = "Delete Student";

#line default
#line hidden
            BeginContext(74, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(119, 5387, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78cfba92ad5bf22f90bfcf26706144ced0045e2d7018", async() => {
                BeginContext(197, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(203, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "78cfba92ad5bf22f90bfcf26706144ced0045e2d7403", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 11 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(232, 1464, true);
                WriteLiteral(@"
    <div class=""card height-auto"">
        <div class=""card-body"">
            <div class=""heading-layout1"">
                <div class=""item-title"">
                    <h3>About Me</h3>
                </div>
                <div class=""dropdown"">
                    <a class=""dropdown-toggle"" href=""#"" role=""button""
                       data-toggle=""dropdown"" aria-expanded=""false"">...</a>

                    <div class=""dropdown-menu dropdown-menu-right"">
                        <a class=""dropdown-item"" href=""#"" data-ajax=""true""
                           data-ajax-method=""GET"" data-ajax-mode=""replace""
                           data-ajax-update=""#main-div"" ><i class=""fas fa-times text-orange-red""></i>Close</a>
                        <a class=""dropdown-item"" href=""#"" data-ajax=""true""
                           data-ajax-method=""GET"" data-ajax-mode=""replace""
                           data-ajax-update=""#main-div"" ><i class=""fas fa-cogs text-dark-pastel-green""></i>Edit</a>
             ");
                WriteLiteral(@"           <a class=""dropdown-item"" href=""#"" data-ajax=""true""
                           data-ajax-method=""GET"" data-ajax-mode=""replace""
                           data-ajax-update=""#main-div"" ><i class=""fas fa-redo-alt text-orange-peel""></i>Refresh</a>
                    </div>
                </div>
            </div>
            <div class=""single-info-details"">
                <div class=""item-img"">
                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1696, "\"", 1718, 1);
#line 37 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml"
WriteAttributeValue("", 1702, Model.PhotoPath, 1702, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1719, 236, true);
                WriteLiteral(" alt=\"student\" width=\"280\" height=\"330\">\r\n                </div>\r\n                <div class=\"item-content\">\r\n                    <div class=\"header-inline item-header\">\r\n                        <h3 class=\"text-dark-medium font-medium\">");
                EndContext();
                BeginContext(1956, 15, false);
#line 41 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml"
                                                            Write(Model.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1971, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1973, 16, false);
#line 41 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml"
                                                                             Write(Model.MiddleName);

#line default
#line hidden
                EndContext();
                BeginContext(1989, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1991, 14, false);
#line 41 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml"
                                                                                               Write(Model.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(2005, 1521, true);
                WriteLiteral(@"</h3>
                        <div class=""header-elements"">
                            <ul>
                                <li><a href=""#"" data-ajax=""true""
                           data-ajax-method=""GET"" data-ajax-mode=""replace""
                           data-ajax-update=""#main-div"" ><i class=""far fa-edit""></i></a></li>
                                <li><a href=""#"" data-ajax=""true""
                           data-ajax-method=""GET"" data-ajax-mode=""replace""
                           data-ajax-update=""#main-div"" ><i class=""fas fa-print""></i></a></li>
                                <li><a href=""#"" data-ajax=""true""
                           data-ajax-method=""GET"" data-ajax-mode=""replace""
                           data-ajax-update=""#main-div"" ><i class=""fas fa-download""></i></a></li>
                            </ul>
                        </div>
                    </div>
                    <p>
                        Aliquam erat volutpat. Curabiene natis massa sedde lacu stiquen soda");
                WriteLiteral(@"le
                        word moun taiery.Aliquam erat volutpaturabiene natis massa sedde  sodale
                        word moun taiery.
                    </p>
                    <div class=""info-table table-responsive"">
                        <table class=""table text-nowrap"">
                            <tbody>
                                <tr>
                                    <td>Name:</td>
                                    <td class=""font-medium text-dark-medium"">");
                EndContext();
                BeginContext(3527, 15, false);
#line 66 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml"
                                                                        Write(Model.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(3542, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(3544, 16, false);
#line 66 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml"
                                                                                         Write(Model.MiddleName);

#line default
#line hidden
                EndContext();
                BeginContext(3560, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(3562, 14, false);
#line 66 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml"
                                                                                                           Write(Model.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(3576, 215, true);
                WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Gender:</td>\r\n                                    <td class=\"font-medium text-dark-medium\">");
                EndContext();
                BeginContext(3792, 12, false);
#line 70 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml"
                                                                        Write(Model.Gender);

#line default
#line hidden
                EndContext();
                BeginContext(3804, 224, true);
                WriteLiteral("</td>\r\n                                </tr>\r\n\r\n                                <tr>\r\n                                    <td>Date Of Birth:</td>\r\n                                    <td class=\"font-medium text-dark-medium\">");
                EndContext();
                BeginContext(4029, 15, false);
#line 75 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml"
                                                                        Write(Model.BirthDate);

#line default
#line hidden
                EndContext();
                BeginContext(4044, 214, true);
                WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Class:</td>\r\n                                    <td class=\"font-medium text-dark-medium\">");
                EndContext();
                BeginContext(4259, 11, false);
#line 79 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml"
                                                                        Write(Model.Class);

#line default
#line hidden
                EndContext();
                BeginContext(4270, 215, true);
                WriteLiteral("</td>\r\n                                </tr>\r\n\r\n                                <tr>\r\n                                    <td>Roll:</td>\r\n                                    <td class=\"font-medium text-dark-medium\">");
                EndContext();
                BeginContext(4486, 12, false);
#line 84 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml"
                                                                        Write(Model.RollNo);

#line default
#line hidden
                EndContext();
                BeginContext(4498, 216, true);
                WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Address:</td>\r\n                                    <td class=\"font-medium text-dark-medium\">");
                EndContext();
                BeginContext(4715, 13, false);
#line 88 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml"
                                                                        Write(Model.Address);

#line default
#line hidden
                EndContext();
                BeginContext(4728, 214, true);
                WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Phone:</td>\r\n                                    <td class=\"font-medium text-dark-medium\">");
                EndContext();
                BeginContext(4943, 18, false);
#line 92 "E:\Personal\Ecourier-Management-System\StudentManagementSystem\Areas\Admin\Views\Student\Delete - Copy (2).cshtml"
                                                                        Write(Model.MobileNumber);

#line default
#line hidden
                EndContext();
                BeginContext(4961, 405, true);
                WriteLiteral(@"</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div>


        <div class=""col-12 form-group mg-t-8"">
            <button type=""submit"" class=""btn-fill-lg btn-gradient-yellow btn-hover-bluedark"">Delete</button>
            ");
                EndContext();
                BeginContext(5366, 115, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78cfba92ad5bf22f90bfcf26706144ced0045e2d20429", async() => {
                    BeginContext(5468, 4, true);
                    WriteLiteral("Back");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5481, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5506, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
