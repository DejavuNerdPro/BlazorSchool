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
    [Microsoft.AspNetCore.Components.RouteAttribute("/refkeydownhandle")]
    public partial class RefDirectiveComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\BlazorServer App\WebApplication1\BlazorSchool\Pages\RefDirectiveComponent.razor"
       
    private string name = "John Doe";
    private ElementReference nameInput;

    private string age = "45";
    private ElementReference ageInput;

    private ElementReference currentElement;

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\BlazorServer App\WebApplication1\BlazorSchool\Pages\RefDirectiveComponent.razor"
           

private void HandleNameChange(ChangeEventArgs e)
{
    // Custom logic when the name changes
    // For example, you can validate the input or perform other actions
    name = e.Value.ToString();
    currentElement = ageInput;
    currentElement.FocusAsync();
    nameInput.FocusAsync();
}

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
