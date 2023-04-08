using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class MoviesController
    {
        private readonly IFileStorage _fileStorage;

        public MoviesController(IFileStorage fileStorage)
        {
            _fileStorage = fileStorage;
        }
        internal void SavePoster(string poster)
        {

            _fileStorage.Save(poster);
        }
        internal void DeletePoster(string poster)
        {

            _fileStorage.Delete(poster);
        }
    }
}
