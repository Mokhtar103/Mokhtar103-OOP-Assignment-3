using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExample
{
    public class Course : IHasId
    {
        public int Id { get; set; }
        public string? Title { get; set; } = null;
        public decimal Price { get; set; }
    }
}
