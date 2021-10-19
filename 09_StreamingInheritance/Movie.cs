using _08_RepositoryPattern_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingInheritance
{
    public class Movie : StreamingContent
    {
        public double Runtime { get; set; }

        public Movie()
        {

        }

        public Movie(string title, string description, double startRating, MaturityRating maturityRating, TypeGenre genreType, double runTime)
            : base(title, description, startRating, maturityRating, genreType)
        {
            Runtime = runTime;

        }
    }
}
