#pragma checksum "C:\Users\msami\OneDrive\Documents\GitHub\Car_Rentals_Task_Csharp\CarRent\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99bff01b9acebaa294f013205e1d38666a1f1b25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\msami\OneDrive\Documents\GitHub\Car_Rentals_Task_Csharp\CarRent\Views\_ViewImports.cshtml"
using CarRent;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99bff01b9acebaa294f013205e1d38666a1f1b25", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4a6afb89a2dbc5978105e9f53f909d68284230a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarRent.Models.Rentals>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 7 "C:\Users\msami\OneDrive\Documents\GitHub\Car_Rentals_Task_Csharp\CarRent\Views\Home\Index.cshtml"
     foreach (var item in Model) {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" style=\"width: 20rem; background-color: #d4d9d7; margin: 10px;\">\r\n\r\n          <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\msami\OneDrive\Documents\GitHub\Car_Rentals_Task_Csharp\CarRent\Views\Home\Index.cshtml"
                              Write(item.Car.RegisterationNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">Make:&ensp;");
#nullable restore
#line 13 "C:\Users\msami\OneDrive\Documents\GitHub\Car_Rentals_Task_Csharp\CarRent\Views\Home\Index.cshtml"
                                       Write(item.Car.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">Model:&ensp;");
#nullable restore
#line 14 "C:\Users\msami\OneDrive\Documents\GitHub\Car_Rentals_Task_Csharp\CarRent\Views\Home\Index.cshtml"
                                        Write(item.Car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">Driver Info</p>\r\n            <p class=\"card-text\">Driver Name:&ensp;");
#nullable restore
#line 16 "C:\Users\msami\OneDrive\Documents\GitHub\Car_Rentals_Task_Csharp\CarRent\Views\Home\Index.cshtml"
                                              Write(item.Driver.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\msami\OneDrive\Documents\GitHub\Car_Rentals_Task_Csharp\CarRent\Views\Home\Index.cshtml"
                                                                Write(item.Driver.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">Driver Phone:&ensp;");
#nullable restore
#line 17 "C:\Users\msami\OneDrive\Documents\GitHub\Car_Rentals_Task_Csharp\CarRent\Views\Home\Index.cshtml"
                                               Write(item.Driver.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">Date of Rent:&ensp;");
#nullable restore
#line 18 "C:\Users\msami\OneDrive\Documents\GitHub\Car_Rentals_Task_Csharp\CarRent\Views\Home\Index.cshtml"
                                               Write(item.RentData);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">Date of Return:&ensp;");
#nullable restore
#line 19 "C:\Users\msami\OneDrive\Documents\GitHub\Car_Rentals_Task_Csharp\CarRent\Views\Home\Index.cshtml"
                                                 Write(item.ReturnDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 21 "C:\Users\msami\OneDrive\Documents\GitHub\Car_Rentals_Task_Csharp\CarRent\Views\Home\Index.cshtml"
             if (@item.IsReturned)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"card-text\">Date of return:&ensp;");
#nullable restore
#line 23 "C:\Users\msami\OneDrive\Documents\GitHub\Car_Rentals_Task_Csharp\CarRent\Views\Home\Index.cshtml"
                                                     Write(item.Driver.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 24 "C:\Users\msami\OneDrive\Documents\GitHub\Car_Rentals_Task_Csharp\CarRent\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </div>\r\n        </div>\r\n");
#nullable restore
#line 28 "C:\Users\msami\OneDrive\Documents\GitHub\Car_Rentals_Task_Csharp\CarRent\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarRent.Models.Rentals>> Html { get; private set; }
    }
}
#pragma warning restore 1591
