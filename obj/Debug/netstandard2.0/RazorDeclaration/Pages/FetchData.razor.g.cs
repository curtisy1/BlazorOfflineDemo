#pragma checksum "/home/curtisy/Projects/OpenExamCollection/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3a9b4652c7565cfd53d5add4871d6f2655cf1e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 37 "/home/curtisy/Projects/OpenExamCollection/Pages/FetchData.razor"
            
    WeatherForecast[] forecasts;

    protected override async Task OnInitAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF { get; set; }

        public string Summary { get; set; }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
