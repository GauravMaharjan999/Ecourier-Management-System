#pragma checksum "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy (2).cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b637ee2bb761e3d71375bff32f5ce074b078a59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Student_Index___Copy__2_), @"mvc.1.0.view", @"/Areas/Admin/Views/Student/Index - Copy (2).cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Student/Index - Copy (2).cshtml", typeof(AspNetCore.Areas_Admin_Views_Student_Index___Copy__2_))]
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
#line 1 "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#line 2 "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentManagement.ViewModels;

#line default
#line hidden
#line 3 "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using Modellayer.Models;

#line default
#line hidden
#line 5 "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\_ViewImports.cshtml"
using Modellayer.Models.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b637ee2bb761e3d71375bff32f5ce074b078a59", @"/Areas/Admin/Views/Student/Index - Copy (2).cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e14f4efd3e7e78ebc3de210c68c40dc2fe2035", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Student_Index___Copy__2_ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("GET"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#main-div"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy (2).cshtml"
   ViewBag.Title = "Student List";
    var photoPath = "";
    int sn = 0; 

#line default
#line hidden
            BeginContext(115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(180, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy (2).cshtml"
   Layout = ViewBag.Layout; 

#line default
#line hidden
            BeginContext(213, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(279, 95, true);
            WriteLiteral("\r\n\r\n<div class=\"breadcrumbs-area\">\r\n    <h3>Students</h3>\r\n    <ul>\r\n        <li>\r\n            ");
            EndContext();
            BeginContext(374, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b637ee2bb761e3d71375bff32f5ce074b078a597734", async() => {
                BeginContext(552, 4, true);
                WriteLiteral("Home");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(560, 29, true);
            WriteLiteral("\r\n        </li>\r\n        <li>");
            EndContext();
            BeginContext(590, 13, false);
#line 20 "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy (2).cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(603, 260, true);
            WriteLiteral(@"</li>
    </ul>
</div>

<!-- Breadcubs Area End Here -->
<!-- Student Table Area Start Here -->
<div class=""card height-auto"">
    <div class=""card-body"">
        <div class=""heading-layout1"">
            <div class=""item-title"">
                <h3>");
            EndContext();
            BeginContext(864, 13, false);
#line 30 "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy (2).cshtml"
               Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(877, 64, true);
            WriteLiteral("</h3>\r\n            </div>\r\n\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(941, 220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b637ee2bb761e3d71375bff32f5ce074b078a5910896", async() => {
                BeginContext(1151, 6, true);
                WriteLiteral("Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1161, 316, true);
            WriteLiteral(@"
            </div>
           
        </div>

        <div id=""grid_array"" style=""margin:auto;""></div>
    </div>


</div>



<!--izitoast Css-->
<!--<link href=""~/css/iziToast.css"" rel=""stylesheet"" />

<script src=""~/js/iziToast.js""></script>
<script src=""~/js/iziToast.min.js""></script>-->


");
            EndContext();
#line 55 "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy (2).cshtml"
 if (ViewBag.Status != null)
{

#line default
#line hidden
            BeginContext(1510, 54, true);
            WriteLiteral("<script>\r\n\r\n\r\n    iziToast.success({\r\n        title: \'");
            EndContext();
            BeginContext(1565, 14, false);
#line 61 "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy (2).cshtml"
           Write(ViewBag.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1579, 64, true);
            WriteLiteral("\',\r\n        message: \'Successfully Deleted\',\r\n    });\r\n</script>");
            EndContext();
#line 64 "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy (2).cshtml"
         }

#line default
#line hidden
            BeginContext(1646, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 67 "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy (2).cshtml"
 if (ViewBag.LoginStatus == true)
{

#line default
#line hidden
            BeginContext(1688, 54, true);
            WriteLiteral("<script>\r\n\r\n\r\n    iziToast.success({\r\n        title: \'");
            EndContext();
            BeginContext(1743, 14, false);
#line 73 "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy (2).cshtml"
           Write(ViewBag.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1757, 57, true);
            WriteLiteral("\',\r\n        message: \'Login Success\',\r\n    });\r\n</script>");
            EndContext();
#line 76 "E:\StudentManagement\StudentManagementSystem\Areas\Admin\Views\Student\Index - Copy (2).cshtml"
         }

#line default
#line hidden
            BeginContext(1817, 45, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<script>\r\n\r\n    $(function () {\r\n\r\n");
            EndContext();
            BeginContext(1980, 550, true);
            WriteLiteral(@"
        function pqDatePicker(ui) {
            var $this = $(this);
            $this
                //.css({ zIndex: 3, position: ""relative"" })
                .datepicker({
                    yearRange: ""-25:+0"", //25 years prior to present.
                    changeYear: true,
                    changeMonth: true,
                    showButtonPanel: true,

                    onClose: function (evt, ui) {
                        $(this).focus();
                    }
                });
            //default from date
");
            EndContext();
            BeginContext(2633, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2767, 3160, true);
            WriteLiteral(@"
        }




        var obj = {
            width: 1000, height: 500,
            title: ""Students table"",
            pageModel: { type: ""remote"", rPP: 20, strRpp: ""{0}"" },
            numberCell: { resizable: true, title: ""S.N."" },
            filterModel: { on: true, mode: ""AND"", header: true },
            selectionModel: {type:'row',mode:'single'},
            editable: false,
            scrollModel: { autoFit: true },
            //flexWidth: true,
            showBottom: true,
            resizable: true
        };

        obj.colModel = [
            { title: ""RollNo"", width: 50, dataIndx: ""rollNo"", dataType: ""integer"",  filter: { type: 'textbox', condition: 'begin', listeners: ['keyup'] } },
            {
                title: ""Photo"", width: 40, dataIndx: ""photoPath"", dataType: ""image""
            },
            { title: ""Name"", width: 75, dataIndx: ""concatName"", dataType: ""string"", filter: { type: 'textbox', condition: 'begin', listeners: ['keyup'] } },
            {");
            WriteLiteral(@" title: ""Address"", width: 75, dataIndx: ""address"", dataType: ""string"", filter: { type: 'textbox', condition: 'begin', listeners: ['keyup'] }},
            { title: ""Class"", width: 75, dataIndx: ""class"", dataType: ""int"", filter: { type: 'textbox', condition: 'begin', listeners: ['keyup'] }},
            {
                title: ""BloodGroup"", width: 75, dataIndx: ""bloodGroup"", dataType: ""string"",
                render: function (ui) {


                    switch (ui.cellData) {

                        case 1:
                            return ""APositive"";
                        case 2:
                            return ""ANegative"";
                        case 3:
                            return ""BPositive"";
                        case 4:
                            return ""BNegative"";
                        case 5:
                            return ""ABPositive"";
                        case 6:
                            return ""ABNegative"";
                        case 7:
    ");
            WriteLiteral(@"                        return ""OPositive"";
                        case 8:
                            return ""ONegative"";

                    }
                },

                filter: {
                    type: ""select"",
                    condition: 'equal',
                    prepend: { 1: ""APositive"", 2: ""ANegative"", 3: ""BPositive"", 4: ""BNegative"", 5: ""ABPositive"", 6: ""ABNegative"", 7: ""OPositive"", 8: ""ONegative"", '0': '--Select--' },
                    valueIndx: ""gender"",
                    labelIndx: ""gender"",
                    listeners: ['change']
                }



            },

            { title: ""MobileNumber"", width: 75, dataIndx: ""mobileNumber"", dataType: ""string"", filter: { type: 'textbox', condition: 'begin', listeners: ['keyup'] }},
            {
                title: ""Birthdate"", width: 75, dataIndx: ""birthDate"", dataType: ""Datetime"", init: pqDatePicker, filter: { type: 'textbox', condition: 'begin', init: pqDatePicker, listeners: ['change'] }, render");
            WriteLiteral(": function (val) {\r\n\r\n                    //return ui.cellData.format(\"YYYY-MM-DD\");\r\n\r\n");
            EndContext();
            BeginContext(5988, 4075, true);
            WriteLiteral(@"                    //display format different from data format (optional).
                    return $.datepicker.formatDate(""M dd, yy"", new Date(val.cellData));

                }

            },
            {
                title: ""Gender"", width: 75, dataIndx: ""gender"", dataType: ""string"", render: function (ui) {

                    if (ui.cellData == 1) {
                        return ""Male"";
                    }
                    else if (ui.cellData == 2) {
                        return ""Female"";
                    }
                    else if (ui.cellData == 3) {
                        return ""Others"";
                    }

                },

                filter: {
                    type: ""select"",
                    condition: 'equal',
                    prepend: { 0: '--Select--', 1: ""Male"", 2: ""Female"", 3: ""Others""},
                    valueIndx: ""gender"",
                    labelIndx: ""gender"",
                    listeners: ['change']
            ");
            WriteLiteral(@"    }
            },

            {
                title: ""Action"", editable: false, minWidth: 83, sortable: false,
                render: function (ui) {


                    var link = `<a href='/Admin/Student/Edit/${ui.rowData.id}' data-ajax=""true""
                           data-ajax-method=""GET"" data-ajax-mode=""replace""
                           data-ajax-update=""#main-div"" class='edit_btn'><svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-pencil-square"" viewBox=""0 0 16 16"">
  <path d=""M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z""/>
  <path fill-rule=""evenodd"" d=""M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z""/>
</svg></a>


<a href='/Admin/Stud");
            WriteLiteral(@"ent/details/${ui.rowData.id}' data-ajax=""true""
                           data-ajax-method=""GET"" data-ajax-mode=""replace""
                           data-ajax-update=""#main-div"" class='details_btn' ><svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-file-earmark"" viewBox=""0 0 16 16"">
  <path d=""M14 4.5V14a2 2 0 0 1-2 2H4a2 2 0 0 1-2-2V2a2 2 0 0 1 2-2h5.5L14 4.5zm-3 0A1.5 1.5 0 0 1 9.5 3V1H4a1 1 0 0 0-1 1v12a1 1 0 0 0 1 1h8a1 1 0 0 0 1-1V4.5h-2z""/>
</svg></button > <a href='/Admin/Student/Delete/${ui.rowData.id}' data-ajax=""true""
                           data-ajax-method=""GET"" data-ajax-mode=""replace""
                           data-ajax-update=""#main-div"" class='delete_btn'><svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-trash"" viewBox=""0 0 16 16"">
  <path d=""M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0");
            WriteLiteral(@" 1 0V6z""/>
  <path fill-rule=""evenodd"" d=""M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z""/>
</svg></a>`;


                    return link;

                }
            }
          
        ];
        obj.dataModel = {
            postData: null,
            location: ""remote"",
            dataType: ""Json"",
            method: ""Get"",
            url: ""/admin/student/GridIndexData"",
            getData: function (gridIndexData) {

                return { curPage: gridIndexData.curPage, totalRecords: gridIndexData.totalRecords, data: gridIndexData.dataRow };
            }

        };

      
       






        var $grid = $(""#grid_array"").pqGrid(obj);

        $grid.pqGrid('option', 'width', 'auto')
            .pqGrid('refresh');


    });




</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591
