#pragma checksum "C:\Git\GreatView\src\GreatView\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8df2af0fcf436599ffa68960859b4e34f24c767"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GreatView.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Git\GreatView\src\GreatView\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Git\GreatView\src\GreatView\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Git\GreatView\src\GreatView\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Git\GreatView\src\GreatView\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 5 "C:\Git\GreatView\src\GreatView\_Imports.razor"
using GreatView;

#line default
#line hidden
#line 6 "C:\Git\GreatView\src\GreatView\_Imports.razor"
using GreatView.Shared;

#line default
#line hidden
#line 2 "C:\Git\GreatView\src\GreatView\Pages\FetchData.razor"
using GreatView.Data;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 36 "C:\Git\GreatView\src\GreatView\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591