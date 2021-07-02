using Abp.Modules;
using Abp.MultiTenancy;
using Abp.TestBase;
using Abp.Zero.Configuration;
using AbpCompanyName.AbpProjectName.Something;
using Castle.MicroKernel.Registration;
using NSubstitute;
using Abp.Configuration.Startup;

namespace AbpCompanyName.AbpProjectName.Tests
{
    [DependsOn(
        typeof(AbpProjectNameApplicationModule),
        typeof(AbpProjectNameDataModule),
        typeof(AbpTestBaseModule))]
    public class AbpProjectNameTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            //Registering fake services

            IocManager.IocContainer.Register(
                Component.For<IAbpZeroDbMigrator>()
                    .UsingFactoryMethod(() => Substitute.For<IAbpZeroDbMigrator>())
                    .LifestyleSingleton()
                );

        }

        public override void PostInitialize()
        {
            base.PostInitialize();
            Configuration.ReplaceService<ISomething, MockSomething>();
        }
    }
}
