using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SalesWebMVC.Models;
using System.Threading.Tasks;

namespace SalesWebMVC.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection Departments{ get; set; }
    }
}
