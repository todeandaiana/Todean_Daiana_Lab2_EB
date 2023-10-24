namespace Todean_Daiana_Lab2.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }

        public ICollection<Book>? Books { get; set; }
        public string FullName
        {
            get { return $"{FirstName + " "+ LastName}"; }
        }


    }
}
