using _08_RepositoryPattern_Repo;
using _09_Inheritance_ClassLibrary;
using _09_StreamingInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_InheritanceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();

            cat1.Move();
            Console.ReadKey();

            Animal animal1 = new Animal();
            animal1.Move();
            Console.ReadKey();

            Lion lion1 = new Lion();
            lion1.Move();
            lion1.MakeSounds();
            Console.ReadKey();

            Movie movie1 = new Movie();
            Show show1 = new Show();
            Episode episode1 = new Episode();

            List<StreamingContent> _listStreamingContent = new List<StreamingContent>();

            List<Episode> _listEpisodes = new List<Episode>();

            _listStreamingContent.Add(movie1);
            _listStreamingContent.Add(show1);

            Movie movie2 = new Movie("Titanic", "A big ship sank", 4, MaturityRating.PG, TypeGenre.Romance, 230.40);



        }
    }
}
