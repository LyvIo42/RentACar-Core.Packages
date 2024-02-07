using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Pipelines.Authonrization;

public interface ISecuredRequest
{
    public string[] Roles { get; }
}
