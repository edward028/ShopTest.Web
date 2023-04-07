using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShopTest.Web.DataAccess.Data;
using ShopTest.Web.Models;

namespace ShopTest.Web.Utility.DbInitializer
{
    public class DbInitializerRepo : IDbInitializer
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public DbInitializerRepo(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }
        public void Initializer()
        {
            try
            {
                if(_context.Database.GetPendingMigrations().Count() > 0)
                {
                    _context.Database.Migrate();
                }
            }
            catch(Exception)
            {
               
            }

         
                //_userManager.AddToRoleAsync(_context.ApplicationUsers.FirstOrDefault(x => x.Email == "edo@gmail.com"), WebSiteRole.Role_Admin).GetAwaiter().GetResult();
            
            return;
        }
    }
}
