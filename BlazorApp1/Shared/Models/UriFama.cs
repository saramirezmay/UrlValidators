using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared.Models
{
    public class UriFama
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public bool State { get; set; }
        public DateTime LastComprobation { get; set; }
    }
}
