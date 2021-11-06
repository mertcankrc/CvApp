using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.Entities.Models.DataModels;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp.Web.TagHelpers
{
    [HtmlTargetElement("GetIcons")]
    public class SocialMediaTagHelper : TagHelper
    {
        private readonly IGenericService<SocialMediaIcon> _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaTagHelper(IGenericService<SocialMediaIcon> socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var icons = _socialMediaService.GetAll();
            string data = "<div class='social-icons'>";

            foreach(var item in icons)
            {
                data += "<a target='_blank' class='social-icon' href='"+item.Link+"'><i class='"+item.Icon+"'></i></a>";
            }

            data += "</div>";
            output.Content.SetHtmlContent(data);
        }
    }
}
