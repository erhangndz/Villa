using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.DealDtos;
using Villa.Dto.Dtos.VideoDtos;
using Villa.Entity.Entities;

namespace Villa.WebUI.Controllers
{
    public class VideoController : Controller
    {
        private readonly IVideoService _videoService;
        private readonly IMapper _mapper;

        public VideoController(IVideoService videoService, IMapper mapper)
        {
            _videoService = videoService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _videoService.TGetListAsync();
            var valueList = _mapper.Map<List<ResultVideoDto>>(values);
            return View(valueList);
        }

        public async Task<IActionResult> DeleteVideo(ObjectId id)
        {
            await _videoService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }

        public IActionResult CreateVideo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateVideo(CreateVideoDto createVideoDto)
        {
            var newValue = _mapper.Map<Video>(createVideoDto);
            await _videoService.TCreateAsync(newValue);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateVideo(ObjectId id)
        {
            var value = await _videoService.TGetByIdAsync(id);
            var updateValue = _mapper.Map<UpdateVideoDto>(value);
            return View(updateValue);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateVideo(UpdateVideoDto updateVideoDto)
        {
            var updateValue = _mapper.Map<Video>(updateVideoDto);
            await _videoService.TUpdateAsync(updateValue);
            return RedirectToAction("Index");
        }
    }
}
