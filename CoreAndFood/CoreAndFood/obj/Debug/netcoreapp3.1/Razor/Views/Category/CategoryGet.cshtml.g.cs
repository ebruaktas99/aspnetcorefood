#pragma checksum "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd10ba02c1caef8cf21c2bc76ba7b7951945b17e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryGet), @"mvc.1.0.view", @"/Views/Category/CategoryGet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd10ba02c1caef8cf21c2bc76ba7b7951945b17e", @"/Views/Category/CategoryGet.cshtml")]
    public class Views_Category_CategoryGet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
  
    ViewData["Title"] = "CategoryGet";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CategoryGet</h1>\r\n\r\n\r\n\r\n<br />\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
 using (Html.BeginForm("CategoryUpdate", "Category", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>");
#nullable restore
#line 16 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
  Write(Html.LabelFor(x => x.CategoryID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 17 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.TextAreaFor(x => x.CategoryID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <b>");
#nullable restore
#line 21 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
  Write(Html.LabelFor(x => x.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 22 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.ValidationMessageFor(x => x.CategoryName, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <b>");
#nullable restore
#line 26 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
  Write(Html.LabelFor(x => x.CategoryDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 27 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.TextAreaFor(x => x.CategoryDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-warning\"> Update</button>\r\n");
#nullable restore
#line 32 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591