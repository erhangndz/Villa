using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.CounterDtos;

namespace Villa.WebUI.ViewComponents.Default_Index
{
    public class _DefaultCounter: ViewComponent
    {
        private readonly ICounterService _counterService;
        private readonly IMapper _mapper;

        public _DefaultCounter(ICounterService counterService, IMapper mapper)
        {
            _counterService = counterService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _counterService.TGetListAsync();
            var counters= _mapper.Map<List<ResultCounterDto>>(values);
            return View(counters);
        }
    }
}
