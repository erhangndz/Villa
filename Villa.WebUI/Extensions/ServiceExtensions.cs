using Villa.Business.Abstract;
using Villa.Business.Concrete;
using Villa.DataAccess.Abstract;
using Villa.DataAccess.EntityFramework;
using Villa.DataAccess.Repositories;

namespace Villa.WebUI.Extensions
{
    public static class ServiceExtensions
    {

        public static void AddServiceExtensions(this IServiceCollection Services)
        {
            Services.AddScoped<IBannerDal, EfBannerDal>();
            Services.AddScoped<IBannerService, BannerManager>();

            Services.AddScoped<IContactDal, EfContactDal>();
            Services.AddScoped<IContactService, ContactManager>();

            Services.AddScoped<ICounterDal, EfCounterDal>();
            Services.AddScoped<ICounterService, CounterManager>();

            Services.AddScoped<IDealDal, EfDealDal>();
            Services.AddScoped<IDealService, DealManager>();

            Services.AddScoped<IFeatureDal, EfFeatureDal>();
            Services.AddScoped<IFeatureService, FeatureManager>();

            Services.AddScoped<IMessageDal, EfMessageDal>();
            Services.AddScoped<IMessageService, MessageManager>();

            Services.AddScoped<IProductDal, EfProductDal>();
            Services.AddScoped<IProductService, ProductManager>();

            Services.AddScoped<IQuestDal, EfQuestDal>();
            Services.AddScoped<IQuestService, QuestManager>();

            Services.AddScoped<IVideoDal, EfVideoDal>();
            Services.AddScoped<IVideoService, VideoManager>();

            Services.AddScoped<ISubHeaderDal, EfSubHeaderDal>();
            Services.AddScoped<ISubHeaderService, SubHeaderManager>();


            Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
            Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
        }



    }
}
