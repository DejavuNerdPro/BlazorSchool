#pragma checksum "D:\BlazorServer App\WebApplication1\Pages\GenericTypeComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f09df24fdb5a8bd665179f92b5225781d72ff117"
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
    public partial class GenericTypeComponent<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Object Component</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "The value of the generic parameter is: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "D:\BlazorServer App\WebApplication1\Pages\GenericTypeComponent.razor"
                                           typeof(T).Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.AddMarkupContent(5, "<p>Instantiating SampleObject :</p>\r\n");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, 
#nullable restore
#line 8 "D:\BlazorServer App\WebApplication1\Pages\GenericTypeComponent.razor"
    typeof(T).GetProperty("DisplayName")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(8, " - Age: ");
            __builder.AddContent(9, 
#nullable restore
#line 8 "D:\BlazorServer App\WebApplication1\Pages\GenericTypeComponent.razor"
                                                 typeof(T).GetProperty("Age")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, 
#nullable restore
#line 9 "D:\BlazorServer App\WebApplication1\Pages\GenericTypeComponent.razor"
    typeof(T).GetProperty("DisplayName").GetValue(TInstance)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " - Age: ");
            __builder.AddContent(14, 
#nullable restore
#line 9 "D:\BlazorServer App\WebApplication1\Pages\GenericTypeComponent.razor"
                                                                     typeof(T).GetProperty("Age").GetValue(TInstance)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "p");
            __builder.AddContent(17, 
#nullable restore
#line 10 "D:\BlazorServer App\WebApplication1\Pages\GenericTypeComponent.razor"
    GetProperty("DisplayName",TInstance)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(18, " - Age: ");
            __builder.AddContent(19, 
#nullable restore
#line 10 "D:\BlazorServer App\WebApplication1\Pages\GenericTypeComponent.razor"
                                                 GetProperty("Age",TInstance)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\BlazorServer App\WebApplication1\Pages\GenericTypeComponent.razor"
       

    // Instantiate an object of type T for illustration
    [Parameter]
    public T TInstance { get; set; } = Activator.CreateInstance<T>();

    // Method to dynamically get property value using reflection
    private object GetProperty(string propertyName, object obj)
    {
        var propertyInfo = typeof(T).GetProperty(propertyName);
        if (propertyInfo != null)
        {
            return propertyInfo.GetValue(obj);
        }
        return null; // Handle the case where the property is not found
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591