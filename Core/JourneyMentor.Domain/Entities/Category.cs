using JourneyMentor.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyMentor.Domain.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {

        }
        public Category(int parentId, string name, int priorty)
        {
            ParentId = parentId;
            Name = name;
            Priorty = priorty;
        }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public int Priorty { get; set; }


    }
}
