using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.TeamMemberDtos
{
    public class MemberGetDto
    {
        public int Id { get; set; } 
        public string Name { get; set; }     
        public string Prefession { get; set; }      
        public string Description { get; set; }   
        public string ImageUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string LinkedinUrl { get; set; }
        public string FacebookUrl { get; set; }

    }
}
