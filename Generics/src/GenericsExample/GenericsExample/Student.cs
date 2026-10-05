using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExample
{
    public class Student : IHasId
    {
        public int Id { get; set; }

        public string? Name { get; set; } = null;
    }
}
