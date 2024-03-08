using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.BannerDtos;

namespace Villa.WebUI.ViewComponents.Default_Index
{
    public class _DefaultBanner:ViewComponent
    {
        private readonly IBannerService _bannerService;
        private readonly IMapper _mapper;

        public _DefaultBanner(IBannerService bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _bannerService.TGetListAsync();
            var bannerList= _mapper.Map<List<ResultBannerDto>>(values);
            return View(bannerList);
        }
    }
}
