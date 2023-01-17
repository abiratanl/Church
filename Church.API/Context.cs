using Microsoft.EntityFrameworkCore;
using Church.Contexts.AccountContext.UseCases.Create;
using Church.Contexts.AccountContext.UseCases.Create.Contracts;
using Church.Contexts.SharedContext;
using Church.Data;
using Church.Data.Contexts.AccountContext.UseCases.Create;

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
                    options => { options.MigrationsAssembly("OldCare.API"); });
            });
    }

    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IRepository, Repository>();
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
    }
}