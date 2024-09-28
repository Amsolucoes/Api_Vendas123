using System.Collections.Generic;

namespace Domain.Models
{
    public class BookModel : BaseModel
    {
        private int _id;
        public int Id 
        { 
            get { return _id; } 
            set { _id = value; } 
        }

        private string _name;
        public string Name 
        { 
            get { return _name;} 
            set { _name = value; } 
        }

        private string _price;
        public string Price
        {
            get { return _price;}
            set { _price = value; }
        }

        public Specifications specifications;

        public class Specifications
        {
            private string _originallyPublished;
            public string OrigallyPublished
            {
                get { return _originallyPublished;}
                set { _originallyPublished = value; }
            }

            private string _author;
            public string Author
            {
                get { return _author;}
                set { _author = value; }
            }

            private string _pageCount;
            public string PageCount
            {
                get { return _pageCount;}
                set
                {
                    _pageCount = value;
                }
            }
            private List<string> _illustrator;
            public List<string> Illustrator
            {
                get { return _illustrator;}
                set
                {
                    _illustrator = value;
                }
            }

            private List<string> _genres;

            public List<string> Genres
            {
                get { return _genres;}
                set
                {
                    _genres = value;
                }
            }
        }
    }
}
