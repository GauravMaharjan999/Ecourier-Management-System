#pragma checksum "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d45b12837818099f6cf16216c15a596dd8ae37da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index))]
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
#line 1 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#line 2 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentManagement.ViewModels;

#line default
#line hidden
#line 3 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using Modellayer.Models;

#line default
#line hidden
#line 5 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using Modellayer.Models.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d45b12837818099f6cf16216c15a596dd8ae37da", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e14f4efd3e7e78ebc3de210c68c40dc2fe2035", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "name", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
   var totalStudentCount = ViewBag.TotalStudentCount; 

#line default
#line hidden
            BeginContext(86, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
   Layout = ViewBag.Layout; 

#line default
#line hidden
            BeginContext(119, 1211, true);
            WriteLiteral(@"<div id=""wrapper"" class=""wrapper bg-ash"">



    <div class=""dashboard-content-one"">
        <!-- Breadcubs Area Start Here -->
        <div class=""breadcrumbs-area"">
            <h3>Admin Dashboard</h3>
            <ul>
                <li>
                    <a href=""index.html"">Home</a>
                </li>
                <li>Admin</li>
            </ul>
        </div>
        <!-- Breadcubs Area End Here -->
        <!-- Dashboard summery Start Here -->
        <div class=""row gutters-20"">
            <div class=""col-xl-3 col-sm-6 col-12"">
                <div class=""dashboard-summery-one mg-b-20"">
                    <div class=""row align-items-center"">
                        <div class=""col-6"">
                            <div class=""item-icon bg-light-green "">
                                <i class=""flaticon-classmates text-green""></i>
                            </div>
                        </div>
                        <div class=""col-6"">
                          ");
            WriteLiteral("  <div class=\"item-content\">\r\n                                <div>Students</div>\r\n                                <div><span style=\" font-size: 20px; font-weight: 500; color: #111111;\"> ");
            EndContext();
            BeginContext(1331, 23, false);
#line 35 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
                                                                                                   Write(Model.TotalStudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(1354, 7533, true);
            WriteLiteral(@"</span></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-sm-6 col-12"">
                <div class=""dashboard-summery-one mg-b-20"">
                    <div class=""row align-items-center"">
                        <div class=""col-6"">
                            <div class=""item-icon bg-light-blue"">
                                <i class=""flaticon-multiple-users-silhouette text-blue""></i>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""item-content"">
                                <div class=""item-title"">Teachers</div>
                                <div class=""item-number""><span class=""counter"" data-num=""2250"">2,250</span></div>
                            </div>
                        </div>
                    </div>
                </div>
            </di");
            WriteLiteral(@"v>
            <div class=""col-xl-3 col-sm-6 col-12"">
                <div class=""dashboard-summery-one mg-b-20"">
                    <div class=""row align-items-center"">
                        <div class=""col-6"">
                            <div class=""item-icon bg-light-yellow"">
                                <i class=""flaticon-couple text-orange""></i>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""item-content"">
                                <div class=""item-title"">Parents</div>
                                <div class=""item-number""><span class=""counter"" data-num=""5690"">5,690</span></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-sm-6 col-12"">
                <div class=""dashboard-summery-one mg-b-20"">
                    <div class=""row align-items-ce");
            WriteLiteral(@"nter"">
                        <div class=""col-6"">
                            <div class=""item-icon bg-light-red"">
                                <i class=""flaticon-money text-red""></i>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""item-content"">
                                <div class=""item-title"">Earnings</div>
                                <div class=""item-number""><span>$</span><span class=""counter"" data-num=""193000"">1,93,000</span></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Dashboard summery End Here -->
        <!-- Dashboard Content Start Here -->
        <div class=""row gutters-20"">
            <div class=""col-12 col-xl-8 col-6-xxxl"">
                <div class=""card dashboard-card-one pd-b-20"">
                    <div class=""card-body"">
         ");
            WriteLiteral(@"               <div class=""heading-layout1"">
                            <div class=""item-title"">
                                <h3>Earnings</h3>
                            </div>
                            <div class=""dropdown"">
                                <a class=""dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown""
                                   aria-expanded=""false"">...</a>

                                <div class=""dropdown-menu dropdown-menu-right"">
                                    <a class=""dropdown-item"" href=""#"">
                                        <i class=""fas fa-times text-orange-red""></i>Close
                                    </a>
                                    <a class=""dropdown-item"" href=""#"">
                                        <i class=""fas fa-cogs text-dark-pastel-green""></i>Edit
                                    </a>
                                    <a class=""dropdown-item"" href=""#"">
                                        <i ");
            WriteLiteral(@"class=""fas fa-redo-alt text-orange-peel""></i>Refresh
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class=""earning-report"">
                            <div class=""item-content"">
                                <div class=""single-item pseudo-bg-blue"">
                                    <h4>Total Collections</h4>
                                    <span>75,000</span>
                                </div>
                                <div class=""single-item pseudo-bg-red"">
                                    <h4>Fees Collection</h4>
                                    <span>15,000</span>
                                </div>
                            </div>
                            <div class=""dropdown"">
                                <a class=""date-dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown""
                                   aria-expa");
            WriteLiteral(@"nded=""false"">Jan 20, 2019</a>
                                <div class=""dropdown-menu dropdown-menu-right"">
                                    <a class=""dropdown-item"" href=""#"">Jan 20, 2019</a>
                                    <a class=""dropdown-item"" href=""#"">Jan 20, 2021</a>
                                    <a class=""dropdown-item"" href=""#"">Jan 20, 2020</a>
                                </div>
                            </div>
                        </div>
                        <div class=""earning-chart-wrap"">
                            <canvas id=""earning-line-chart"" width=""660"" height=""320""></canvas>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-xl-4 col-3-xxxl"">
                <div class=""card dashboard-card-two pd-b-20"">
                    <div class=""card-body"">
                        <div class=""heading-layout1"">
                            <div class=""item-title"">
           ");
            WriteLiteral(@"                     <h3>Student's Gender</h3>
                            </div>
                            <div class=""dropdown"">
                                <a class=""dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown""
                                   aria-expanded=""false"">...</a>

                                <div class=""dropdown-menu dropdown-menu-right"">
                                    <a class=""dropdown-item"" href=""#"">
                                        <i class=""fas fa-times text-orange-red""></i>Close
                                    </a>
                                    <a class=""dropdown-item"" href=""#"">
                                        <i class=""fas fa-cogs text-dark-pastel-green""></i>Edit
                                    </a>
                                    <a class=""dropdown-item"" href=""#"">
                                        <i class=""fas fa-redo-alt text-orange-peel""></i>Refresh
                                    </a>
       ");
            WriteLiteral(@"                         </div>
                            </div>
                        </div>
                        <div class=""expense-report"">
                            <div class=""monthly-expense pseudo-bg-Aquamarine"">
                                <div class=""expense-date"">Male</div>
                                <div class=""expense-amount"">");
            EndContext();
            BeginContext(8888, 22, false);
#line 174 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
                                                       Write(Model.MaleStudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(8910, 250, true);
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"monthly-expense pseudo-bg-blue\">\r\n                                <div class=\"expense-date\">Female</div>\r\n                                <div class=\"expense-amount\">");
            EndContext();
            BeginContext(9161, 24, false);
#line 178 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
                                                       Write(Model.FemaleStudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(9185, 252, true);
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"monthly-expense pseudo-bg-yellow\">\r\n                                <div class=\"expense-date\">Others</div>\r\n                                <div class=\"expense-amount\">");
            EndContext();
            BeginContext(9438, 23, false);
#line 182 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
                                                       Write(Model.OtherStudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(9461, 76, true);
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(9764, 1872, true);
            WriteLiteral(@"                        <div class=""expense-chart-wrap"">
                            <canvas id=""DasboardStudentGender-bar-chart"" width=""100"" height=""300""></canvas>
                        </div>

                    </div>
                </div>
            </div>
            <div class=""col-12 col-xl-6 col-3-xxxl"">
                <div class=""card dashboard-card-three pd-b-20"">
                    <div class=""card-body"">
                        <div class=""heading-layout1"">
                            <div class=""item-title"">
                                <h3>Students</h3>
                            </div>
                            <div class=""dropdown"">
                                <a class=""dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown""
                                   aria-expanded=""false"">...</a>

                                <div class=""dropdown-menu dropdown-menu-right"">
                                    <a class=""dropdown-item"" href=""#"">
            ");
            WriteLiteral(@"                            <i class=""fas fa-times text-orange-red""></i>Close
                                    </a>
                                    <a class=""dropdown-item"" href=""#"">
                                        <i class=""fas fa-cogs text-dark-pastel-green""></i>Edit
                                    </a>
                                    <a class=""dropdown-item"" href=""#"">
                                        <i class=""fas fa-redo-alt text-orange-peel""></i>Refresh
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class=""doughnut-chart-wrap"">
                            <canvas id=""DashboardStudent-doughnut-chart"" width=""100"" height=""300""></canvas>

                            ");
            EndContext();
            BeginContext(11636, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d45b12837818099f6cf16216c15a596dd8ae37da18850", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 225 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MaleStudentCount);

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
            BeginContext(11703, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(11733, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d45b12837818099f6cf16216c15a596dd8ae37da21172", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 226 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FemaleStudentCount);

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
            BeginContext(11802, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(11832, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d45b12837818099f6cf16216c15a596dd8ae37da23496", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 227 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OtherStudentCount);

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
            BeginContext(11900, 292, true);
            WriteLiteral(@"
                        </div>
                        <div class=""student-report"">
                            <div class=""student-count pseudo-bg-red"">
                                <h4 class=""item-title"">Other Students</h4>
                                <div class=""item-number"">");
            EndContext();
            BeginContext(12193, 23, false);
#line 232 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
                                                    Write(Model.OtherStudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(12216, 250, true);
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"student-count pseudo-bg-blue\">\r\n                                <h4 class=\"item-title\">Female Students</h4>\r\n                                <div class=\"item-number\">");
            EndContext();
            BeginContext(12467, 24, false);
#line 236 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
                                                    Write(Model.FemaleStudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(12491, 288, true);
            WriteLiteral(@"</div>
                            </div>
                            <div class=""student-count pseudo-bg-yellow"">
                                <h4 class=""item-title"">Male Students</h4>
                                <div class=""item-number"">
                                    ");
            EndContext();
            BeginContext(12780, 22, false);
#line 241 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
                               Write(Model.MaleStudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(12802, 5073, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-xl-6 col-4-xxxl"">
                <div class=""card dashboard-card-four pd-b-20"">
                    <div class=""card-body"">
                        <div class=""heading-layout1"">
                            <div class=""item-title"">
                                <h3>Event Calender</h3>
                            </div>
                            <div class=""dropdown"">
                                <a class=""dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown""
                                   aria-expanded=""false"">...</a>

                                <div class=""dropdown-menu dropdown-menu-right"">
                                    <a class=""dropdown-item"" href=""#"">
                                        <i class=""fas fa-times text-orange-red""></i>Close
       ");
            WriteLiteral(@"                             </a>
                                    <a class=""dropdown-item"" href=""#"">
                                        <i class=""fas fa-cogs text-dark-pastel-green""></i>Edit
                                    </a>
                                    <a class=""dropdown-item"" href=""#"">
                                        <i class=""fas fa-redo-alt text-orange-peel""></i>Refresh
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class=""calender-wrap"">
                            <div id=""fc-calender"" class=""fc-calender""></div>
                        </div>
                    </div>
                </div>
            </div>


        </div>
        <!-- Dashboard Content End Here -->
        <!-- Social Media Start Here -->
        <div class=""row gutters-20"">
            <div class=""col-lg-3 col-sm-6 col-12"">
                <div class=""");
            WriteLiteral(@"card dashboard-card-seven"">
                    <div class=""social-media bg-fb hover-fb"">
                        <div class=""media media-none--lg"">
                            <div class=""social-icon"">
                                <i class=""fab fa-facebook-f""></i>
                            </div>
                            <div class=""media-body space-sm"">
                                <h6 class=""item-title"">Like us on facebook</h6>
                            </div>
                        </div>
                        <div class=""social-like"">30,000</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-sm-6 col-12"">
                <div class=""card dashboard-card-seven"">
                    <div class=""social-media bg-twitter hover-twitter"">
                        <div class=""media media-none--lg"">
                            <div class=""social-icon"">
                                <i class=""fab fa-twitter""></i>
      ");
            WriteLiteral(@"                      </div>
                            <div class=""media-body space-sm"">
                                <h6 class=""item-title"">Follow us on twitter</h6>
                            </div>
                        </div>
                        <div class=""social-like"">1,11,000</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-sm-6 col-12"">
                <div class=""card dashboard-card-seven"">
                    <div class=""social-media bg-gplus hover-gplus"">
                        <div class=""media media-none--lg"">
                            <div class=""social-icon"">
                                <i class=""fab fa-google-plus-g""></i>
                            </div>
                            <div class=""media-body space-sm"">
                                <h6 class=""item-title"">Follow us on googleplus</h6>
                            </div>
                        </div>
                        <div ");
            WriteLiteral(@"class=""social-like"">19,000</div>
                    </div>
                </div>
            </div>

            <div class=""col-lg-3 col-sm-6 col-12"">
                <div class=""card dashboard-card-seven"">
                    <div class=""social-media bg-linkedin hover-linked"">
                        <div class=""media media-none--lg"">
                            <div class=""social-icon"">
                                <i class=""fab fa-linkedin-in""></i>
                            </div>
                            <div class=""media-body space-sm"">
                                <h6 class=""item-title"">Follow us on linked</h6>
                            </div>
                        </div>
                        <div class=""social-like"">45,000</div>
                    </div>
                </div>
            </div>


        </div>
        <!-- Social Media End Here -->

    </div>

    <!-- Page Area End Here -->
</div>


");
            EndContext();
#line 356 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
 if (ViewBag.LoginStatus == true)
{

#line default
#line hidden
            BeginContext(17913, 54, true);
            WriteLiteral("<script>\r\n\r\n\r\n    iziToast.success({\r\n        title: \'");
            EndContext();
            BeginContext(17968, 14, false);
#line 362 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
           Write(ViewBag.Status);

#line default
#line hidden
            EndContext();
            BeginContext(17982, 57, true);
            WriteLiteral("\',\r\n        message: \'Login Success\',\r\n    });\r\n</script>");
            EndContext();
#line 365 "F:\StudentManagement\EcommerceManagementSystem\StudentManagementSystem\Areas\Admin\Views\Dashboard\Index.cshtml"
         }

#line default
#line hidden
            BeginContext(18042, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
