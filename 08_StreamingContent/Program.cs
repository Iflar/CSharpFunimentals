using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client wants a console app for users to store a collection of streaming content.
            //list<string>, list<StreamingContent>
            //StreamingContent.cs
            //point of app is for the users to interact with their collection so that they can keep
            //up to date with their favorite streaming content
            //interact with users inside my console app - user interface - ProgramUI 
            //users interact with collection - business logic (combination of methods) - Repository Pattern - Repo.cs > CRUD methods(Create.Read.Update.Delete)

            //Single Reposinsibility Priciple
            //console app project - be the application/user Interface
            //program.cs
            //programUI.cs

            //Class Library users interact with collection - business logic
            //Repo.cs
            //StreamingContent.cs
            ProgramUI UI = new ProgramUI();
            UI.Run();


        }
    }
}
