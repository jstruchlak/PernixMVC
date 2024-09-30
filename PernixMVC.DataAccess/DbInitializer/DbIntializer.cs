using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PernixMVC.DataAccess.Data;
using PernixMVC.Models;
using PernixMVC.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PernixMVC.DataAccess.DbInitializer
{
	public class DbInitializer : IDbInitializer
	{
		private readonly UserManager<IdentityUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly ApplicationDbContext _db;
		public DbInitializer(
			UserManager<IdentityUser> userManager,
			RoleManager<IdentityRole> roleManager,
			ApplicationDbContext db)
		{
			_roleManager = roleManager;
			_userManager = userManager;
			_db = db;
		}


		public void Initialize()
		{

			//migrations if they are not applied
			try
			{
				if (_db.Database.GetPendingMigrations().Count() > 0)
				{
					_db.Database.Migrate();
				}
			}
			catch (Exception ex) { }


			//create roles if they are not created
			if (!_roleManager.RoleExistsAsync(StaticDetails.Role_Customer).GetAwaiter().GetResult())
			{
				_roleManager.CreateAsync(new IdentityRole(StaticDetails.Role_Customer)).GetAwaiter().GetResult();
				_roleManager.CreateAsync(new IdentityRole(StaticDetails.Role_Employee)).GetAwaiter().GetResult();
				_roleManager.CreateAsync(new IdentityRole(StaticDetails.Role_Admin)).GetAwaiter().GetResult();
				_roleManager.CreateAsync(new IdentityRole(StaticDetails.Role_Company)).GetAwaiter().GetResult();


				// create an admin user
				_userManager.CreateAsync(new ApplicationUser
				{
					UserName = "joeys@pernix.com.au",
					Email = "joeys@pernix.com.au",
					Name = "Joey Struchlak",
					PhoneNumber = "1112223333",
					StreetAddress = "101 Richmond Road",
					State = "SA",
					PostalCode = "5038",
					City = "Mile End South"
				}, "Admin123*").GetAwaiter().GetResult();
				ApplicationUser user = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "joeys@pernix.com.au");
				_userManager.AddToRoleAsync(user, StaticDetails.Role_Admin).GetAwaiter().GetResult();
			}

			return;
		}
	}
}
