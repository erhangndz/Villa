using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.FeatureDtos;

namespace Villa.WebUI.ViewComponents.Default_Index
{
    public class _DefaultFeature: ViewComponent
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public _DefaultFeature(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _featureService.TGetListAsync();
            var featureList= _mapper.Map<List<ResultFeatureDto>>(values);
            return View(featureList);
        }
    }
}
