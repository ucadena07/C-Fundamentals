using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class MoviesController
    {
        internal void SavePoster(string poster, IFileStorage fileStorage)
        {

            fileStorage.Save(poster);
        }
    }
}
