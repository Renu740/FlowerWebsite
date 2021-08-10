// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
