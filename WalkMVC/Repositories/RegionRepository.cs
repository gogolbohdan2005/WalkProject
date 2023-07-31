using WalkMVC.Data;
using WalkMVC.Models;
using Microsoft.EntityFrameworkCore;
using WalkMVC.Models.Dto;

namespace WalkMVC.Repository
{
    public class RegionRepository : IRegionRepository
    {
        private readonly WalksDbContext dbContext;

        public RegionRepository(WalksDbContext dbContext)
        {
            this.dbContext = dbContext; // CONSTRUCTOR I SUPPOSE
        }
        
        public async Task<List<Region>> GetRegionsAsync()
        {
            return await dbContext.Regions.ToListAsync();
        }

        public async Task<Region> CreateAsync(Region region)
        {
            await dbContext.Regions.AddAsync(region);    
            await dbContext.SaveChangesAsync();
            return region;
        }

        public async Task<Region> UpdateAsync(int id, Region region)
        {
            var existingRegion = await dbContext.Regions.FirstOrDefaultAsync(obj => obj.Id == id);

            if (existingRegion == null)
            {
                return null;
            }
            existingRegion.Name = region.Name;
            existingRegion.Spots = region.Spots;
            existingRegion.Links = region.Links;
            existingRegion.Road = region.Road;
            await dbContext.SaveChangesAsync();
            return existingRegion;
        }
    }
}
