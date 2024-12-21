using FPTJobMatch.Models;
using System;
using System.Collections.Generic;

namespace FPTJobMatch.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Tuple<JobListing, string>> JobListingsWithUserEmail { get; set; }
    }
}
