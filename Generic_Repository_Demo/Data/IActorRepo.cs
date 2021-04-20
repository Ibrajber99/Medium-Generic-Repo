using Generic_Repository_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Repository_Demo.Data
{
    public interface IActorRepo : IGenericRepo<Actor>, IDisposable
    {


    }



}
