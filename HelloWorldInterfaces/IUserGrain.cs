using System.Threading.Tasks;

namespace Vylon.Achievement.Interfaces
{
    /// <summary>
    /// Orleans grain communication interface IUserGrain
    /// </summary>
    public interface IUserGrain : Orleans.IGrainWithGuidKey
    {
        Task Did(IActionGrain action);
    }
}
