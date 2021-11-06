using AutoMapper;
using CVApp.DTO.DTO.AppUserDTO;
using CVApp.DTO.DTO.CertificationDTO;
using CVApp.DTO.DTO.EducationDTO;
using CVApp.DTO.DTO.ExperienceDTO;
using CVApp.DTO.DTO.InterestDTO;
using CVApp.DTO.DTO.ProjectsDTO;
using CVApp.DTO.DTO.SkillDTO;
using CVApp.DTO.DTO.SocialMediaDTO;
using CVApp.Entities.Models.DataModels;
using CVApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp.Web.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AppUser, AppUserListDTO>();
            CreateMap<AppUserListDTO, AppUser>();
            CreateMap<AppUser, AppUserUpdateDTO>();
            CreateMap<AppUserUpdateDTO, AppUser>();
            CreateMap<AppUser, AppUserCreateDTO>();
            CreateMap<AppUserCreateDTO, AppUser>();
            CreateMap<AppUserCreateModel, AppUser>().ReverseMap();


            CreateMap<Certification, CertificationListDTO>();
            CreateMap<CertificationListDTO, Certification>();

            CreateMap<Certification, CertificationAddDTO>();
            CreateMap<CertificationAddDTO, Certification>();

            CreateMap<Certification, CertificationUpdateDTO>();
            CreateMap<CertificationUpdateDTO, Certification>();

            CreateMap<Education, EducationListDTO>();
            CreateMap<EducationListDTO, Education>();

            CreateMap<Education, EducationAddDTO>();
            CreateMap<EducationAddDTO, Education>();

            CreateMap<Education, EducationUpdateDTO>();
            CreateMap<EducationUpdateDTO, Education>();

            CreateMap<Experience, ExperienceListDTO>();
            CreateMap<ExperienceListDTO, Experience>();

            CreateMap<Experience, ExperienceAddDTO>();
            CreateMap<ExperienceAddDTO, Experience>();

            CreateMap<Experience, ExperienceUpdateDTO>();
            CreateMap<ExperienceUpdateDTO, Experience>();

            CreateMap<Interest, InterestListDTO>();
            CreateMap<InterestListDTO, Interest>();
            CreateMap<Interest, InterestAddDTO>();
            CreateMap<InterestAddDTO, Interest>();
            CreateMap<Interest, InterestUpdateDTO>();
            CreateMap<InterestUpdateDTO, Interest>();

            CreateMap<Skill, SkillListDTO>();
            CreateMap<SkillListDTO, Skill>();
            CreateMap<Skill, SkillAddDTO>();
            CreateMap<SkillAddDTO, Skill>();
            CreateMap<Skill, SkillUpdateDTO>();
            CreateMap<SkillUpdateDTO, Skill>();


            CreateMap<SocialMediaIcon, SocialMediaAddDTO>();
            CreateMap<SocialMediaAddDTO, SocialMediaIcon>();
            CreateMap<SocialMediaIcon, SocialMediaUpdateDTO>();
            CreateMap<SocialMediaUpdateDTO, SocialMediaIcon>();
            CreateMap<SocialMediaIcon, SocialMediaListDTO>();
            CreateMap<SocialMediaListDTO, SocialMediaIcon>();

            CreateMap<Projects, ProjectsAddDTO>();
            CreateMap<ProjectsAddDTO, Projects>();
            CreateMap<Projects, ProjectsUpdateDTO>();
            CreateMap<ProjectsUpdateDTO, Projects>();
            CreateMap<Projects, ProjectsListDTO>();
            CreateMap<ProjectsListDTO, Projects>();
        }
    }
}
