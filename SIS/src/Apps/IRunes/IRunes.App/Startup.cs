using IRunes.Data;
using IRunes.Services;
using SIS.MvcFramework;
using SIS.MvcFramework.Routing;
using SIS.MvcFramework.DependencyContainer;

namespace IRunes.App
{
    public partial class Startup : IMvcApplication
    {
        public void Configure(IServerRoutingTable serverRoutingTable)
        {
            using (var context = new RunesDbContext())
            {
                context.Database.EnsureCreated();
            }
        }

        public void ConfigureServices(IServiceProvider serviceProvider)
        {
            serviceProvider.Add<IAlbumService, AlbumService>();
            serviceProvider.Add<IUserService, UserService>();
            serviceProvider.Add<ITrackService, TrackService>();

            //serviceProvider.Add
        }
    }
}
