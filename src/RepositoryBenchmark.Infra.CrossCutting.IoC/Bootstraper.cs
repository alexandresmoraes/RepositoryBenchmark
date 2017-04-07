using SimpleInjector;

namespace RepositoryBenchmark.Infra.CrossCutting.IoC
{
  public class Bootstraper
  {
    public static void RegisterServices(Container container)
    {
      //container.RegisterPerWebRequest<ApplicationDbContext>();
      //container.RegisterPerWebRequest<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
      //container.RegisterPerWebRequest<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>());
      //container.RegisterPerWebRequest<ApplicationRoleManager>();
      //container.RegisterPerWebRequest<ApplicationUserManager>();
      //container.RegisterPerWebRequest<ApplicationSignInManager>();

      //container.RegisterPerWebRequest<IUsuarioRepository, UsuarioRepository>();
    }
  }
}