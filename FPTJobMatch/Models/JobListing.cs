using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace FPTJobMatch.Models

{
    public class JobListing
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Company Name is required.")]
        [StringLength(100, ErrorMessage = "Company Name cannot exceed 100 characters.")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Position is required.")]
        [StringLength(100, ErrorMessage = "Position cannot exceed 100 characters.")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Salary is required.")]
        // You might want to add a regular expression for salary validation here
        public string Salary { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public int LocationId { get; set; }
        public string UserId { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<JobApplication> JobApplications { get; set; }

        internal static async Task<object> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
