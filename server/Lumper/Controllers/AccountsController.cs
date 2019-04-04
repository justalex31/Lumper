using Lumper.Data;
using Lumper.Entities;
using Lumper.Helpers;
using Lumper.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Lumper.Controllers
{
    public class AccountsController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public AccountsController(UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CustomerRegistrationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userIdentity = new ApplicationUser()
            {
                UserName = model.Email,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(userIdentity, model.Password);

            if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));

            await _context.Customers.AddAsync(new Customer
            {
                IdentityId = userIdentity.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                CompanyName = model.CompanyName,
                Address = model.Address
            });
            await _context.SaveChangesAsync();

            return new OkObjectResult("Account created");
        }
    }
}
