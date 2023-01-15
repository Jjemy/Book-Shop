using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data.ViewModels
{
    public class NewBookDropdownsVM
    {
        public NewBookDropdownsVM()
        {
            Authors = new List<Author>();
            Publishers = new List<Publisher>();
        }

        public List<Author> Authors { get; set; }
        public List<Publisher> Publishers { get; set; }
    }
}
