using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
