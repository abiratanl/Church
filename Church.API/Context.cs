﻿using Microsoft.EntityFrameworkCore;
using Church.Contexts.AccountContext.UseCases.Create;
using Church.Contexts.AccountContext.UseCases.Create.Contracts;
using Church.Contexts.AdmContext.UseCases.CreateNewsletter.Contracts;
using Church.Contexts.SharedContext;
using Church.Data;
using Church.Data.Contexts.AccountContext.UseCases.Create;
using Church.Data.Contexts.AdmContext.UseCases.CreateNewsletter;

namespace Church.API;

public static class Context
{
    public static void ConfigureDataContext(IServiceCollection services)
    {
        services.AddDbContext<DataContext>(
            x =>
            {
                x.UseSqlServer(
                    Configuration.Database.ConnectionString,
                    options => { options.MigrationsAssembly("Church.API"); });
            });
    }

    public static void ConfigureServices(IServiceCollection services)
    {
       // services.AddTransient<IRepository, Repository>();
        services.AddTransient<IService, Service>();

        #region AccountContext

        services
            .AddTransient<Contexts.AccountContext.UseCases.VerifyEmail.Contracts.IRepository,
                Data.Contexts.AccountContext.UseCases.VerifyEmail.Repository>();
        services
            .AddTransient<Contexts.AccountContext.UseCases.VerifyEmail.Contracts.IService,
                Contexts.AccountContext.UseCases.VerifyEmail.Service>();

        services
            .AddTransient<Contexts.AccountContext.UseCases.ResendEmailVerificationCode.Contracts.IRepository,
                Data.Contexts.AccountContext.UseCases.ResendEmailVerificationCode.Repository>();
        services
            .AddTransient<Contexts.AccountContext.UseCases.ResendEmailVerificationCode.Contracts.IService,
                Contexts.AccountContext.UseCases.ResendEmailVerificationCode.Service>();

        services
            .AddTransient<Contexts.AccountContext.UseCases.ChangeEmail.Contracts.IRepository,
                Data.Contexts.AccountContext.UseCases.ChangeEmail.Repository>();
        services
            .AddTransient<Contexts.AccountContext.UseCases.ChangeEmail.Contracts.IService,
                Contexts.AccountContext.UseCases.ChangeEmail.Service>();

        services
            .AddTransient<Contexts.AccountContext.UseCases.ChangePassword.Contracts.IRepository,
                Data.Contexts.AccountContext.UseCases.ChangePassword.Repository>();

        services
            .AddTransient<Contexts.AccountContext.UseCases.RequestPasswordResetCode.Contracts.IRepository,
                Data.Contexts.AccountContext.UseCases.RequestPasswordResetCode.Repository>();
        services
            .AddTransient<Contexts.AccountContext.UseCases.RequestPasswordResetCode.Contracts.IService,
                Contexts.AccountContext.UseCases.RequestPasswordResetCode.Service>();

        services
            .AddTransient<Contexts.AccountContext.UseCases.ResetPassword.Contracts.IRepository,
                Data.Contexts.AccountContext.UseCases.ResetPassword.Repository>();

        services
            .AddTransient<Contexts.AccountContext.UseCases.VerifyPhone.Contracts.IRepository,
                Data.Contexts.AccountContext.UseCases.VerifyPhone.Repository>();
        
        services
            .AddTransient<Contexts.AccountContext.UseCases.Create.Contracts.IRepository,
                Data.Contexts.AccountContext.UseCases.Create.Repository>();
        services
            .AddTransient<Contexts.AccountContext.UseCases.Edit.Contracts.IRepository,
                Data.Contexts.AccountContext.UseCases.Edit.Repository>();

        services
            .AddTransient<Contexts.AccountContext.UseCases.Details.Contracts.IRepository,
                Data.Contexts.AccountContext.UseCases.Details.Repository>();

        services
            .AddTransient<Contexts.AccountContext.UseCases.Authenticate.Contracts.IRepository,
                Data.Contexts.AccountContext.UseCases.Authenticate.Repository>();

        #endregion

        #region PersonContext

        services
            .AddTransient<Contexts.PersonContext.UseCases.Create.Contracts.IRepository,
                Data.Contexts.PersonContext.UseCases.Create.Repository>();

        services
            .AddTransient<Contexts.PersonContext.UseCases.Get.Contracts.IRepository,
                Data.Contexts.PersonContext.UseCases.Get.Repository>();
        
        services
            .AddTransient<Contexts.PersonContext.UseCases.Delete.Contracts.IRepository,
                Data.Contexts.PersonContext.UseCases.Delete.Repository>();
        
        services
            .AddTransient<Contexts.PersonContext.UseCases.Edit.Contracts.IRepository,
                Data.Contexts.PersonContext.UseCases.Edit.Repository>();

        #endregion

        #region MemberContext

        services
            .AddTransient<Contexts.MemberContext.UseCases.Create.Contracts.IRepository,
                Data.Contexts.MemberContext.UseCases.Create.Repository>();
        services
            .AddTransient<Contexts.MemberContext.UseCases.Create.Contracts.IRepositoryCongregation,
                Data.Contexts.MemberContext.UseCases.Create.RepositoryCongregation>();

        services
            .AddTransient<Contexts.MemberContext.UseCases.Get.Contracts.IRepository,
                Data.Contexts.MemberContext.UseCases.Get.Repository>();

        services
            .AddTransient<Contexts.MemberContext.UseCases.Delete.Contracts.IRepository,
                Data.Contexts.MemberContext.UseCases.Delete.Repository>();

        services
            .AddTransient<Contexts.MemberContext.UseCases.Edit.Contracts.IRepository,
                Data.Contexts.MemberContext.UseCases.Edit.Repository>();

        #endregion
        
        #region AdmContext_Newsletter

        services
            .AddTransient<Contexts.AdmContext.UseCases.CreateNewsletter.Contracts.IRepository,
                Data.Contexts.AdmContext.UseCases.CreateNewsletter.Repository>();
        
        services
            .AddTransient<Contexts.AdmContext.UseCases.DeleteNewsletter.Contracts.IRepository,
                Data.Contexts.AdmContext.UseCases.DeleteNewsletter.Repository>();
        
        services
            .AddTransient<Contexts.AdmContext.UseCases.GetNewsletter.Contracts.IRepository,
                Data.Contexts.AdmContext.UseCases.GetNewsletter.Repository>();
        
        #endregion
    }
}