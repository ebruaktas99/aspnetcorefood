#pragma checksum "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00114471f79db85fd71095de75124b20183381af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_FoodAdd), @"mvc.1.0.view", @"/Views/Food/FoodAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00114471f79db85fd71095de75124b20183381af", @"/Views/Food/FoodAdd.cshtml")]
    public class Views_Food_FoodAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Food>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
  
    ViewData["Title"] = "FoodAdd";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>FoodAdd</h1>\r\n\r\n\r\n<br />\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
 using (Html.BeginForm("FoodAdd", "Food", FormMethod.Post))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>");
#nullable restore
#line 16 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
  Write(Html.Label("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 17 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <b>");
#nullable restore
#line 21 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
  Write(Html.Label("Stock"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 22 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextBoxFor(x => x.Stock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>");
#nullable restore
#line 26 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
  Write(Html.Label("Price"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 27 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>");
#nullable restore
#line 30 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
  Write(Html.Label("ImageURL"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 31 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextBoxFor(x => x.ImageURL, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>");
#nullable restore
#line 34 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
  Write(Html.Label("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 35 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>) ViewBag.v1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>");
#nullable restore
#line 37 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
  Write(Html.Label("Description"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 38 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-warning\"> Save</button>\r\n");
#nullable restore
#line 43 "C:\Users\Ebru Aktaş\Desktop\PROJELERİM\ASPNETCORE-YOUTUBE\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.Food> Html { get; private set; }
    }
}
#pragma warning restore 1591