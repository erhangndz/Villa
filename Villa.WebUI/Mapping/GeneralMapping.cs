using AutoMapper;
using Villa.Dto.Dtos.BannerDtos;
using Villa.Dto.Dtos.ContactDtos;
using Villa.Dto.Dtos.CounterDtos;
using Villa.Dto.Dtos.DealDtos;
using Villa.Dto.Dtos.FeatureDtos;
using Villa.Dto.Dtos.MessageDtos;
using Villa.Dto.Dtos.ProductDtos;
using Villa.Dto.Dtos.QuestDtos;
using Villa.Dto.Dtos.SubHeaderDtos;
using Villa.Dto.Dtos.VideoDtos;
using Villa.Entity.Entities;

namespace Villa.WebUI.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<ResultBannerDto,Banner>().ReverseMap();
            CreateMap<UpdateBannerDto,Banner>().ReverseMap();
            CreateMap<CreateBannerDto,Banner>().ReverseMap();

            CreateMap<CreateContactDto, Contact>().ReverseMap();
            CreateMap<UpdateContactDto, Contact>().ReverseMap();
            CreateMap<ResultContactDto, Contact>().ReverseMap();


            CreateMap<ResultCounterDto, Counter>().ReverseMap();
            CreateMap<UpdateCounterDto, Counter>().ReverseMap();
            CreateMap<CreateCounterDto, Counter>().ReverseMap();


            CreateMap<CreateDealDto, Deal>().ReverseMap();
            CreateMap<UpdateDealDto, Deal>().ReverseMap();
            CreateMap<ResultDealDto, Deal>().ReverseMap();


            CreateMap<ResultFeatureDto, Feature>().ReverseMap();
            CreateMap<CreateFeatureDto, Feature>().ReverseMap();
            CreateMap<UpdateFeatureDto, Feature>().ReverseMap();


            CreateMap<ResultMessageDto, Message>().ReverseMap();
            CreateMap<UpdateMessageDto, Message>().ReverseMap();
            CreateMap<CreateMessageDto, Message>().ReverseMap();


            CreateMap<ResultProductDto, Product>().ReverseMap();
            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();


            CreateMap<ResultQuestDto, Quest>().ReverseMap();
            CreateMap<UpdateQuestDto, Quest>().ReverseMap();
            CreateMap<CreateQuestDto, Quest>().ReverseMap();

            CreateMap<ResultVideoDto, Video>().ReverseMap();
            CreateMap<CreateVideoDto, Video>().ReverseMap();
            CreateMap<UpdateVideoDto, Video>().ReverseMap();

            CreateMap<ResultSubHeaderDto,SubHeader>().ReverseMap();
            CreateMap<CreateSubHeaderDto,SubHeader>().ReverseMap();
            CreateMap<UpdateSubHeaderDto,SubHeader>().ReverseMap();


        }

    }
}
