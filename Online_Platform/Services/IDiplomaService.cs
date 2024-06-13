namespace Online_Platform.Services
{
    using Online_Platform.Services.Models.Diplomas;
    using System.Threading.Tasks;


    public interface IDiplomaService
    {
        Task<DiplomaServiceModel> GetByIdAsync(string id);
    }
}
