#pragma checksum "D:\BlazorServer App\WebApplication1\Pages\GenericComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca955314e614482204c9770677f25e27264b7735"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\BlazorServer App\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BlazorServer App\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BlazorServer App\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\BlazorServer App\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\BlazorServer App\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\BlazorServer App\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\BlazorServer App\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\BlazorServer App\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\BlazorServer App\WebApplication1\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\BlazorServer App\WebApplication1\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BlazorServer App\WebApplication1\Pages\GenericComponent.razor"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/generictypeparam")]
    public partial class GenericComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>GenericComponent</h3>\r\n\r\n");
            __Blazor.WebApplication1.Pages.GenericComponent.TypeInference.CreateGenericTypeComponent_0(__builder, 1, 2, 
#nullable restore
#line 6 "D:\BlazorServer App\WebApplication1\Pages\GenericComponent.razor"
                                  sampleObject

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\BlazorServer App\WebApplication1\Pages\GenericComponent.razor"
      
    private SampleObject sampleObject { get; set; } = new SampleObject()
    {
        DisplayName = "Anony",
        Age = 12
    };

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.WebApplication1.Pages.GenericComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericTypeComponent_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::WebApplication1.Pages.GenericTypeComponent<T>>(seq);
        __builder.AddAttribute(__seq0, "TInstance", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591