#pragma checksum "C:\Users\Sergey\Desktop\ApplianceStore\ApplianceStore.PL\Views\Query\NinthQuery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a2af81e065d9ce5df3bce05896eeb5302bd8dc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Query_NinthQuery), @"mvc.1.0.view", @"/Views/Query/NinthQuery.cshtml")]
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
#line 1 "C:\Users\Sergey\Desktop\ApplianceStore\ApplianceStore.PL\Views\_ViewImports.cshtml"
using ApplianceStore.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sergey\Desktop\ApplianceStore\ApplianceStore.PL\Views\_ViewImports.cshtml"
using ApplianceStore.PL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sergey\Desktop\ApplianceStore\ApplianceStore.PL\Views\_ViewImports.cshtml"
using ApplianceStore.PL.Models.BindingModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sergey\Desktop\ApplianceStore\ApplianceStore.PL\Views\_ViewImports.cshtml"
using ApplianceStore.PL.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a2af81e065d9ce5df3bce05896eeb5302bd8dc2", @"/Views/Query/NinthQuery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"430dd507dd650b82e7b6cc8903b45c7ac12c243e", @"/Views/_ViewImports.cshtml")]
    public class Views_Query_NinthQuery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<table class=\"table_price\">\n    <caption>Результат</caption>\n    <tr>\n        <th>\n            Title\n        </th>\n        <th>\n            Description\n        </th>\n    </tr>\n");
#nullable restore
#line 13 "C:\Users\Sergey\Desktop\ApplianceStore\ApplianceStore.PL\Views\Query\NinthQuery.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 17 "C:\Users\Sergey\Desktop\ApplianceStore\ApplianceStore.PL\Views\Query\NinthQuery.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 20 "C:\Users\Sergey\Desktop\ApplianceStore\ApplianceStore.PL\Views\Query\NinthQuery.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 23 "C:\Users\Sergey\Desktop\ApplianceStore\ApplianceStore.PL\Views\Query\NinthQuery.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
