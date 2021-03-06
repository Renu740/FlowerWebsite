#pragma checksum "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90b351e73ca663c6b24105e1e19715e1322a0141"
// <auto-generated/>
#pragma warning disable 1591
namespace FlowersWebsite.Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
using FlowersWebsite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
using FlowersWebsite.Services;

#line default
#line hidden
#nullable disable
    public partial class FlowerList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
#nullable restore
#line 8 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
     foreach (var flower in FlowerService.GetFlowers())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-img");
            __builder.AddAttribute(6, "style", "background-image:url(\'" + (
#nullable restore
#line 11 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                                                                flower.Image

#line default
#line hidden
#nullable disable
            ) + "\');" + " width" + " :100%" + " ;height" + " :200px");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.OpenElement(10, "h5");
            __builder.AddAttribute(11, "class", "card-title");
            __builder.AddContent(12, 
#nullable restore
#line 13 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                                        flower.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-footer");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "text-muted");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                                  e => SelectFlower(flower.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "data-toggle", "modal");
            __builder.AddAttribute(21, "data-target", "#flowerModal");
            __builder.AddAttribute(22, "class", "btn btn-primary");
            __builder.AddContent(23, "MoreInfo");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/fontawesome.min.css\">");
#nullable restore
#line 26 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
 if (selectFlowers != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "id", "flowerModal");
            __builder.AddAttribute(27, "class", "modal fade");
            __builder.AddAttribute(28, "role", "dialog");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(31, "role", "document");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "modal-content");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "modal-header");
            __builder.OpenElement(36, "h5");
            __builder.AddAttribute(37, "class", "modal-title");
            __builder.AddContent(38, 
#nullable restore
#line 34 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                                             selectFlowers.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.AddMarkupContent(40, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        &times;\r\n                    </button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "card");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "card-img");
            __builder.AddAttribute(46, "style", "background-image:url(\'" + (
#nullable restore
#line 40 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                                                                        selectFlowers.Image

#line default
#line hidden
#nullable disable
            ) + "\');" + " width" + " :100%" + " ;height" + " :200px");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "card-body");
            __builder.OpenElement(50, "h5");
            __builder.AddAttribute(51, "class", "card-text");
            __builder.AddContent(52, 
#nullable restore
#line 42 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                                               selectFlowers.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "modal-footer");
#nullable restore
#line 46 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                     if (voteCount == null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(56, "<span>Please give the First Vote</span>");
#nullable restore
#line 49 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(57, "span");
            __builder.AddContent(58, 
#nullable restore
#line 52 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                               voteCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(59, " ");
            __builder.AddContent(60, 
#nullable restore
#line 52 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                                          voteLable

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 53 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                     for (int i = 0; i < 3; i++)
                    {
                        var currentStar = i;
                        if (i <= currentStar)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(61, "span");
            __builder.AddAttribute(62, "class", "fa-star fa checked");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                                                                       e => SubmitRating(currentStar)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 61 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "span");
            __builder.AddAttribute(65, "class", "fa-star fa");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                                                               e => SubmitRating(currentStar)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 65 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "D:\Ltts Trainning\FlowersWebsite\FlowersWebsite\Component\FlowerList.razor"
       
    Flowers selectFlowers;
    string selectFlowerId;

    void SelectFlower(string flowerId)
    {
        selectFlowerId = flowerId;
        selectFlowers = FlowerService.GetFlowers().First(x => x.Id == flowerId);
        GetCurrentRating();
    }

    int currenrRating = 0;
    int voteCount = 0;
    string voteLable;

    void GetCurrentRating()
    {
        if (selectFlowers.Ratings == null)
        {
            currenrRating = 0;
            voteCount = 0;
        }
        else
        {
            voteCount = selectFlowers.Ratings.Count();
            voteLable = voteCount > 1 ? "Votes" : "Vote";
            currenrRating = selectFlowers.Ratings.Sum() / voteCount;
        }
        System.Console.WriteLine($"Current rating for {selectFlowers.Id}:{currenrRating}");
    }

    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Rating Received for {selectFlowers.Id}:{rating}");
        FlowerService.AddFlowerRating(selectFlowers.Id, rating);
        SelectFlower(selectFlowerId);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileFlowersService FlowerService { get; set; }
    }
}
#pragma warning restore 1591
