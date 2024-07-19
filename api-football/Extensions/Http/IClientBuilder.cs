using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_football.Extensions.Http
{
    public interface IClientBuilder
    {
        HttpClient Build();
    }
}
