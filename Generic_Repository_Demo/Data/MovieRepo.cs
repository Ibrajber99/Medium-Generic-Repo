using Generic_Repository_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Repository_Demo.Data
{
    public class MovieRepo : IMovieRepo
    {
        public Task<int> Create(Movie item)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Movie item)
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

        public Task<Movie> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Movie>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Movie item)
        {
            throw new NotImplementedException();
        }
    }
}
