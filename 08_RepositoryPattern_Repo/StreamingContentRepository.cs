using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_RepositoryPattern_Repo
{
    public class StreamingContentRepository
    {
        //REPO - holds business logic
        // allows transfer of info from collection to user interface
        //CRUD methods

        //Create
        //take in a streaming content object and add it to the list

        //Read

        //Update

        //Delete

        //new list object that contains StreamingContent objects
        //protected vs private??
        protected readonly List<StreamingContent> _contentDirecory = new List<StreamingContent>();

        //refactor - change code to improve/adjust for breaking changes


        /*Create*/
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startCount = _contentDirecory.Count;
            _contentDirecory.Add(content);
            bool wasAdded = _contentDirecory.Count > startCount ? true : false;
            return wasAdded;
        }

        /*Delete*/
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            return _contentDirecory.Remove(existingContent);
        }

        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirecory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }

        /*Update*/
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Genre = newContent.Genre;
                oldContent.Discription = newContent.Discription;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRating = newContent.MaturityRating;

                return true;
            }
            else
            {
                return false;
            }
        }
        /*Read*/ public List<StreamingContent> GetAllContents()
        {
            return _contentDirecory;
        }
    }
}
