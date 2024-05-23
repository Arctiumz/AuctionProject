using AuctionProject.Models;

namespace AuctionProject.Data.Services
{
    public interface IListingsService
    {
        IQueryable<Listing> GetAllListings();
    }
}
