﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recademy.Library.Models
{
    public class User
    {
        [Key] 
        public int Id { get; set; }

        public string Name { get; set; }

        public string GithubLink { get; set; }

        public ICollection<UserSkill> UserSkills { get; set; }

        public ICollection<ProjectInfo> ProjectInfos { get; set; }

        public ICollection<ReviewRequest> ReviewRequests { get; set; }
    }
}