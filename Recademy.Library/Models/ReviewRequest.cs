using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Recademy.Library.Types;

namespace Recademy.Library.Models
{
    public class ReviewRequest
    {
        [Key] 
        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public ProjectState State { get; set; }
        public string Description { get; set; }
        public ICollection<ReviewResponse> ReviewResponse { get; set; }

        [ForeignKey("ProjectInfo")] 
        public int ProjectId { get; set; }
        public ProjectInfo ProjectInfo { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}