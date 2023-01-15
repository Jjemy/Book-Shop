using Ecommerce.Data.Base;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data.Services
{
    public class BooksService : EntityBaseRepository<Book>, IBooksService
    {
        public BooksService(AppDbContext context) : base(context) { }
    }
}