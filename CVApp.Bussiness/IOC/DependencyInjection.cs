using CVApp.Bussiness.Interface;
using CVApp.Bussiness.Methods;
using CVApp.Bussiness.ValidationRules.AppUserValidators;
using CVApp.Bussiness.ValidationRules.CertificationValidators;
using CVApp.Bussiness.ValidationRules.EducationValidators;
using CVApp.Bussiness.ValidationRules.ExperienceValidators;
using CVApp.Bussiness.ValidationRules.InterestValidators;
using CVApp.Bussiness.ValidationRules.SkillValidators;
using CVApp.Bussiness.ValidationRules.SocialMediaValidators;
using CVApp.DataAccess.Interface;
using CVApp.DataAccess.Methods.Dapper;
using CVApp.DTO.DTO.AppUserDTO;
using CVApp.DTO.DTO.CertificationDTO;
using CVApp.DTO.DTO.EducationDTO;
using CVApp.DTO.DTO.ExperienceDTO;
using CVApp.DTO.DTO.InterestDTO;
using CVApp.DTO.DTO.SkillDTO;
using CVApp.DTO.DTO.SocialMediaDTO;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CVApp.Bussiness.IOC
{
    public static class DependencyInjection
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDbConnection>(con => new SqlConnection(configuration.GetConnectionString("remote")));


            //genericrepo gördüğün zaman bana ilgili örnek için dpdataaccess'i getir
            //app user gelirse genericrepo için, app user için dpdataaccess ver
            services.AddScoped(typeof(IGenericRepo<>), typeof(DpDataAccess<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped<IAppUserRepo, DpUserRepo>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<ICertificationRepo, DpCertificationRepo>();
            services.AddScoped<ICertificationService, CertificationManager>();
            services.AddScoped<IEducationRepo, DpEducationRepo>();
            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<IInterestRepo, DpInterestRepo>();
            services.AddScoped<IInterestService, InterestManager>();
            services.AddScoped<IProjectsRepo, DpProjectsRepo>();
            services.AddScoped<IProjectService, ProjectManager>();
            services.AddScoped<ISkillsRepo, DpSkillsRepo>();
            services.AddScoped<ISkillService, SkillManager>();

            services.AddScoped<IExperienceRepo, DpExperienceRepo>();
            services.AddScoped<IExperienceService, ExperienceManager>();

            services.AddTransient<IValidator<AppUserUpdateDTO>, AppUserUpdateValidator>();
            services.AddTransient<IValidator<AppUserUpdateDTO>, AppUserUpdateValidator>();
            services.AddTransient<IValidator<CertificationAddDTO>, CertificationAddDValidator>();
            services.AddTransient<IValidator<CertificationUpdateDTO>, CertificationUpdateValidator>();
            services.AddTransient<IValidator<EducationAddDTO>, EducationAddValidator>();
            services.AddTransient<IValidator<EducationUpdateDTO>, EducationUpdateValidator>();
            services.AddTransient<IValidator<ExperienceAddDTO>, ExperienceAddValidator>();
            services.AddTransient<IValidator<ExperienceUpdateDTO>, ExperienceUpdateValidator>();
            services.AddTransient<IValidator<InterestAddDTO>, InterestAddValidator>();
            services.AddTransient<IValidator<InterestUpdateDTO>, InterestUpdateValidator>();
            services.AddTransient<IValidator<SkillAddDTO>, SkillAddValidator>();
            services.AddTransient<IValidator<SkillUpdateDTO>, SkillUpdateValidator>();
            services.AddTransient<IValidator<SocialMediaAddDTO>, SocialMediaAddValidator>();
            services.AddTransient<IValidator<SocialMediaUpdateDTO>, SocialMediaUpdateValidator>();





        }
    }
}
