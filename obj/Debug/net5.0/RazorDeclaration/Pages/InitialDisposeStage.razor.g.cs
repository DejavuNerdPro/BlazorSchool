// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\BlazorServer App\WebApplication1\BlazorSchool\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/initialDisposeStage")]
    public partial class InitialDisposeStage : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "D:\BlazorServer App\WebApplication1\BlazorSchool\Pages\InitialDisposeStage.razor"
       
    public string SampleText { get; set; } = "";

    protected override void OnInitialized()
    {
        SampleText = "Blazor";
        NavigationManager.LocationChanged += OnLocationChanged;
    }

    public void OnLocationChanged(object? sender, LocationChangedEventArgs eventArgs)
    {
        SampleText = "Blazor Location Changed";
    }

    public void Dispose()
    {
        NavigationManager.LocationChanged -= OnLocationChanged;
        JSRuntime.InvokeVoidAsync("alert", "Disposed.");
    }

    //public async ValueTask DisposeAsync() => NavigationManager.LocationChanged -= OnLocationChanged;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
