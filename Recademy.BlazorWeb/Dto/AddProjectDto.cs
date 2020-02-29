﻿using System.Collections.Generic;

namespace Recademy.BlazorWeb.Dto
{
    public class AddProjectDto
    {
        public AddProjectDto(string projectName, int userId, string url, string tag)
        {
            UserId = userId;
            ProjectUrl = url;
            ProjectName = projectName;
            Tags = new List<string> {tag};
        }
        public int UserId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectUrl { get; set; }
        public List<string> Tags { get; set; }

    }
}