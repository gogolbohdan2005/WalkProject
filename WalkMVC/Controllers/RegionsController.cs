using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WalkMVC.Models;
using WalkMVC.Models.Dto;
using WalkMVC.Repository;

namespace WalkMVC.Controllers
{
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }



        //public static List<Region> listDb = new List<Region>();

        public async Task<IActionResult> Index()
        {
            return View(await regionRepository.GetRegionsAsync());
        }
        public IActionResult Create()
        {
            RegionDto regionDto = new RegionDto();
            return View(regionDto);
        }
        public IActionResult Upload(RegionDto regionDto)
        {
            regionRepository.CreateAsync(mapper.Map<Region>(regionDto));
            return View("Success");
        }
    }
}
