using Ecommerce.Data.Base;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data.Services
{
    public class AuthorsService : EntityBaseRepository<Author>, IAuthorsService
	{
        public AuthorsService(AppDbContext context) : base(context){ }
    }
}