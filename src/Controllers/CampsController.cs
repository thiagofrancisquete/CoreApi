using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreCodeCamp.Controllers
{
  [Route("api/[controller]")]
  public class CampsController
  {

    public string[] Get()
    {
      return new[] { "Hello", "From","Pluralsight" };
    }
  }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreCodeCamp.Controllers 
{
 [Route("api/camps")]
  public class CampsController: ControllerBase 
  {
    public object Get() 
    {
      return new { Moniker = "ATL2018", Name = "Atlanta code camp"};
    }
  }
}

*/