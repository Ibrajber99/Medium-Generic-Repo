using Generic_Repository_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Repository_Demo.Data
{
    public class ActorRepo : IActorRepo
    {
        public Task<int> Create(Actor item)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Actor item)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Actor> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Actor>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Actor item)
        {
            throw new NotImplementedException();
        }
    }
}
