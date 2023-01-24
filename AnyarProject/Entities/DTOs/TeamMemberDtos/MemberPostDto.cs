using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.TeamMemberDtos
{
    public class MemberPostDto
    {
        public string Name { get; set; }
        [Required]
        public string Prefession { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public IFormFile FormFile { get; set; }
        public string? InstagramUrl { get; set; }
        public string? TwitterUrl { get; set; }
        public string? LinkedinUrl { get; set; }
        public string? FacebookUrl { get; set; }
    }
}
