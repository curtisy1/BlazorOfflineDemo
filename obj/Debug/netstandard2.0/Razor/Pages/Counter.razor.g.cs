#pragma checksum "/home/curtisy/Projects/OpenExamCollection/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4fabfd6e6d002e957b53fad126e1419708789b9"
// <auto-generated/>
#pragma warning disable 1591
namespace OpenExamCollection.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/home/curtisy/Projects/OpenExamCollection/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/home/curtisy/Projects/OpenExamCollection/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/home/curtisy/Projects/OpenExamCollection/_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "/home/curtisy/Projects/OpenExamCollection/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "/home/curtisy/Projects/OpenExamCollection/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "/home/curtisy/Projects/OpenExamCollection/_Imports.razor"
using OpenExamCollection;

#line default
#line hidden
#line 7 "/home/curtisy/Projects/OpenExamCollection/_Imports.razor"
using OpenExamCollection.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            builder.OpenElement(1, "p");
            builder.AddContent(2, "Current count: ");
            builder.AddContent(3, 
#line 5 "/home/curtisy/Projects/OpenExamCollection/Pages/Counter.razor"
                   currentCount

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(4, "\r\n\r\n");
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "class", "btn btn-primary");
            builder.AddAttribute(7, "onclick", 
#line 7 "/home/curtisy/Projects/OpenExamCollection/Pages/Counter.razor"
                                          IncrementCount

#line default
#line hidden
            );
            builder.AddContent(8, "Click me");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 9 "/home/curtisy/Projects/OpenExamCollection/Pages/Counter.razor"
            
    int currentCount = 0;

    void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
