﻿using FPTJobMatch.Models;

namespace FPTJobMatch.ViewModels
{
    public class AppliedCandidateViewModel
    {
        public JobApplication JobApplication { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UploadFile { get; set; }
    }
}
