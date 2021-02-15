#pragma checksum "C:\Projects\GitHub\DinoManager_Blazor\Pages\Reports.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cd166631c4089a34d0967c6de7e708fe9490d25"
// <auto-generated/>
#pragma warning disable 1591
namespace DinoManager_Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\GitHub\DinoManager_Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\GitHub\DinoManager_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\GitHub\DinoManager_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\GitHub\DinoManager_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\GitHub\DinoManager_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\GitHub\DinoManager_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\GitHub\DinoManager_Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\GitHub\DinoManager_Blazor\_Imports.razor"
using DinoManager_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\GitHub\DinoManager_Blazor\_Imports.razor"
using DinoManager_Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\GitHub\DinoManager_Blazor\Pages\Reports.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\GitHub\DinoManager_Blazor\Pages\Reports.razor"
using DinoManager_Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\GitHub\DinoManager_Blazor\Pages\Reports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/people")]
    public partial class Reports : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>People</h3>\r\n\r\n\r\n\r\n");
#nullable restore
#line 13 "C:\Projects\GitHub\DinoManager_Blazor\Pages\Reports.razor"
 if (people == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 16 "C:\Projects\GitHub\DinoManager_Blazor\Pages\Reports.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "blueTable");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>Nombre</th>\r\n                <th>Apellido</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 27 "C:\Projects\GitHub\DinoManager_Blazor\Pages\Reports.razor"
             foreach (var p in people)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.AddContent(15, 
#nullable restore
#line 31 "C:\Projects\GitHub\DinoManager_Blazor\Pages\Reports.razor"
                         p.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.AddContent(20, 
#nullable restore
#line 34 "C:\Projects\GitHub\DinoManager_Blazor\Pages\Reports.razor"
                         p.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 37 "C:\Projects\GitHub\DinoManager_Blazor\Pages\Reports.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.AddContent(27, "    ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Projects\GitHub\DinoManager_Blazor\Pages\Reports.razor"
                                              InsertData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Insert");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-warning");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Projects\GitHub\DinoManager_Blazor\Pages\Reports.razor"
                                              UpdateData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-danger");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Projects\GitHub\DinoManager_Blazor\Pages\Reports.razor"
                                             DeleteData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 44 "C:\Projects\GitHub\DinoManager_Blazor\Pages\Reports.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Projects\GitHub\DinoManager_Blazor\Pages\Reports.razor"
       
    List<PersonModel> people;

    private async Task InsertData()
    {
        string sql = "insert into people (FirstName, LastName) values (@FirstName, @LastName);";

        await _data.SaveData(sql, new { FirstName = "Billy", LastName = "Bob" }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    private async Task UpdateData()
    {
        string sql = "update people set FirstName = @FirstName where LastName = @LastName";

        await _data.SaveData(sql, new { FirstName = "Timothy", LastName = "Corey" }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    private async Task DeleteData()
    {
        string sql = "delete from people where LastName = @LastName";

        await _data.SaveData(sql, new { LastName = "Bob" }, _config.GetConnectionString("default"));

        await OnInitializedAsync();
    }

    protected override async Task OnInitializedAsync()
    {
        string sql = "select * from people";

        people = await _data.LoadData<PersonModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591