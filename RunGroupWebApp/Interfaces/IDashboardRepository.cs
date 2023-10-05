using RunGroupWebApp.Models;

namespace RunGroupWebApp.Interfaces
{
    public interface IDashboardRepository
    {
        Task<List<Race>> GetAllUserRaces();
        Task<List<Club>> GetAllUserClubs();
        Task<AppUser> GetUserById(string id);
        Task<AppUser> GetByIdNoTracking(string id);//queries dont have to tracking, changes dont have to update
        bool Update(AppUser user);
        bool Save();
    }
}
