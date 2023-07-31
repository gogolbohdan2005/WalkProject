using WalkMVC.Models;
using WalkMVC.Models.Dto;

namespace WalkMVC.Repository
{
    public interface IRegionRepository
    {
        Task<List<Region>> GetRegionsAsync();
        Task<Region> CreateAsync(Region region);
        Task<Region> UpdateAsync(int id, Region region);


    }
}
