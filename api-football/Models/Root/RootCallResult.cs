using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Models.Root
{
    public class RootCallResult<T> where T : class
    {
        public required string get { get; set; }
        public object? parameters { get; set; }
        public object[]? errors { get; set; }
        public int results { get; set; }
        public required Paging paging { get; set; }
        public List<T>? response { get; set; }
    }
}
