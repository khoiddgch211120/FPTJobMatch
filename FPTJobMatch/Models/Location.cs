﻿using System.Collections.Generic;

namespace FPTJobMatch.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public virtual ICollection<JobListing> JobListings { get; set; }
    }
}
