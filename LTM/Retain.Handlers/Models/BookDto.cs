using System;
using System.Collections.Generic;
using System.Text;

namespace Retain.Handlers.Models
{
    public class BookDto
    {
        public Guid Id { get; set; }
        public int Capacity { get; set; }
        public string ProjectName { get; set; }
    }
}
