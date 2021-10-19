using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_RepositoryPattern_Repo
{
    public enum MaturityRating
    {
        G = 1,
        PG,
        PG_13,
        R,
        NC_17,
        TV_MA,
        NR
    }

    public enum TypeGenre
    {
        Action = 1,
        Thriller,
        Horror,
        Romance,
        Sci_Fi,
        Mystery,
        Documentery,
    }
    public class StreamingContent
    {
        //object that we will create a collection of
        //get method = retrieving value of prop
        //set method = giving value of the prop 
        public string Title { get; set; }
        public string Discription { get; set; }
        public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public TypeGenre Genre { get; set; }

        public bool isFamilyFriendly
        {
            get
            {
                //return true or false based on maturity rating
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                        return true;
                    case MaturityRating.NC_17:
                    case MaturityRating.PG_13:
                    case MaturityRating.NR:
                    case MaturityRating.R:
                    case MaturityRating.TV_MA:
                    default:
                        return false;
                }
                //another Conditional option:
                //if((int)MaturityRating <= 2)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}

            }
        }
        //Constructors - tell a dev what they need to create that object/instance of that object.
        //Default Constructor  - value of any type is unneeded
        public StreamingContent()
        {

        }
        //Overload Constructor - value is needed
        public StreamingContent(string title, string discription, double starRating, MaturityRating maturityRating, TypeGenre genreType)
        {
            //prop NAME = parameter NAME/Value
            Title = title;
            Discription = discription;
            StarRating = starRating;
            MaturityRating = maturityRating;
            Genre = genreType;
        }
    }
}
