using _08_RepositoryPattern_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent
{
    public class ProgramUI
    {
        private readonly StreamingContentRepository _streamingRepo = new StreamingContentRepository();
        //User Interface
        // host user interaction
        //point of app is for the users to interact with their collection so that they can keep
        //up to date with their favorite streaming content
        //CRUD
        //creating new streaming content -- add to my collecton
        //read the collection
        //update collection
        //Delete content from collection
        public void Run()
        {
            SeedContentList();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Hello and welcome to the application! \n" +
                "Here is where you can create and interact with a list of your favorite movies and TV shows.\n" +
                "Enter the Option you woul like to select: \n" +
                "1. Show all streaming content.\n" +
                "2. Find streaming content by title.\n" +
                "3. Add new streaming content.\n" +
                "4. Remove streaming content.\n" +
                "5. Exit\n");
                string userInput = Console.ReadLine();
                switch (userInput)
                {

                    case "1":
                    //Show all
                    case "2":
                    //Find by title

                    case "3":
                        //Add new content
                        CreateNewContent();
                        break;

                    case "4":
                    //Remove content

                    case "5":
                    //Exit
                    continueToRun = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
            
        }
        private void CreateNewContent()
        {
            StreamingContent Content = new StreamingContent();
            //the user will need to create a streaming content object
            /*Title
             Discription
             StarRating
             MaturityRating
             TypeOfGenre
             */
            Console.WriteLine("Time to add your streaming content to your collection.\n" +
                "Lets get started!\n" +
                "Please Enter the following:\n" +

                "Title:");
            Content.Title = Console.ReadLine();

            Console.WriteLine("Discription:");
            Content.Discription = Console.ReadLine();

            Console.WriteLine("Star Rating (1-5):");
            string starRatingInput = Console.ReadLine();
            //try catch
            //allow application to move on if there would be an error
            try
            {
                Content.StarRating = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Dude listen... Enter a valid decimal.");
            }

            Console.WriteLine("Maturity Rating (1-7):\n" +
                "1. G \n" +
                "2. PG \n" +
                "3. PG_13 \n" +
                "4. R \n" +
                "5. NC_17 \n" +
                "6. TV_MA \n" +
                "7. NR");
            string maturityString = Console.ReadLine();
            switch (maturityString.ToUpper())
            {
                case "1":
                case "G":
                    Content.MaturityRating = MaturityRating.G;
                    break;
                case "2":
                case "PG":
                    Content.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                case "PG13":
                    Content.MaturityRating = MaturityRating.PG;
                    break;
                case "4":
                case "R":
                    Content.MaturityRating = MaturityRating.R;
                    break;
                case "5":
                case "NC17":
                    Content.MaturityRating = MaturityRating.NC_17;
                    break;
                case "6":
                case "TV MA":
                    Content.MaturityRating = MaturityRating.TV_MA;
                    break;
                case "7":
                case "NR":
                    Content.MaturityRating = MaturityRating.NR;
                    break;

                default:
                    Console.WriteLine("Plz enter valid number");
                    break;
            }

            Console.WriteLine("Please select a genre\n" +
                "1. Action\n" +
                "2. Thriller\n" +
                "3. Horror\n" +
                "4. Romance\n" +
                "5. Sci-Fi\n" +
                "6. Mystery\n" +
                "7. Documentery");
            try
            {
                string genreInput = Console.ReadLine();
                int genreID = int.Parse(genreInput);
                Content.Genre = (TypeGenre)genreID;
            }
            catch
            {
                Console.WriteLine("Please enter a number between 1-8");
            }


            //AddContentToDirectory take in a streaming content object and add it to collection
            _streamingRepo.AddContentToDirectory(Content); 
        }
        private void SeedContentList()
        {
            StreamingContent movieOne = new StreamingContent("Jaws", "Fish eats man", 3.5, MaturityRating.R, TypeGenre.Horror);
            _streamingRepo.AddContentToDirectory(movieOne);
            StreamingContent movieTwo = new StreamingContent("Interstellar", "Vast expance of space over an incomprehencable amount to time", 4.5, MaturityRating.PG_13, TypeGenre.Sci_Fi);
            _streamingRepo.AddContentToDirectory(movieTwo);
        }
    }
}
