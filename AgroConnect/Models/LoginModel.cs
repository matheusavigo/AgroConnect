using AgroConnect.Data;
using System.Threading.Tasks;
using System.Data.Entity; 


namespace AgroConnect.Models
{
    public class LoginModel
    {
        public string Username { get; set; }
        public string Telefone { get; set; }
        public string Password { get; set; }  

        public async Task<bool> ValidateUserAsync(ApplicationDbContext context)
        {
            bool isEmail = Username.Contains("@");
            var user = isEmail
                ? await context.Cadastroes
                    .FirstOrDefaultAsync(u => u.Email == Username) 
                : await context.Cadastroes
                    .FirstOrDefaultAsync(u => u.Telefone == Username);

            if (user != null && user.Senha == Password) 
            {
                return true;
            }

            return false;
        }
    }
}
