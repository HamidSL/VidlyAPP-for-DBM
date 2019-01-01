using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyApp.Models;

namespace VidlyApp.ViewModels
{
    public class CustomerMovieViewModel
    {
        public Movies Movies { get; set; }
        public List<Customer> Customer { get; set; }
        public MembershipType MembershipType { get; set; }

        public List<Genre> Genres { get; set; }
        

     
    }
}