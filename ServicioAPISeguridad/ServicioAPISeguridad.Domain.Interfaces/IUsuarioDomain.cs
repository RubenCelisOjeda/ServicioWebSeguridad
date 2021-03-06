using ServicioAPISeguridad.Domain.Entities.Auth;
using ServicioAPISeguridad.Domain.Entities.Sesion;
using ServicioAPISeguridad.Domain.Entities.Usuario;
using System.Threading.Tasks;

namespace ServicioAPISeguridad.Domain.Interfaces
{
    public interface IUsuarioDomain
    {
        Task<UserResponseEntities> Login(AuthRequestEntities authRequestEntities);
        Task<int> GuardarSesion(SesionUsuarioEntities pSesionUsuario);
        Task<int> UserRegister(UserRegisterEntities pUserRegisterDto);
        Task<bool> ValidateByUser(string pUser);
        Task<bool> ValidateByEmail(string pEmail);
    }
}
