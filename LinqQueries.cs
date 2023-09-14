using System.Linq;
using System.Reflection.Metadata;
namespace practicaLinq;

    public class LinqQueries
    {
        List<Book> ltsBooks = new List<Book>();
        public LinqQueries(){
            using(StreamReader reader = new StreamReader("books.json")){
                string json = reader.ReadToEnd();
                this.ltsBooks = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json,new System.Text.Json.JsonSerializerOptions(){PropertyNameCaseInsensitive = true}) ?? new List<Book>();
            }
        }
        public IEnumerable<Book> AllCollection(){
            return ltsBooks;
        }
        public IEnumerable<Book> BooksAfter2000(){
            return ltsBooks.Where(book => book.PublishedDate.Year > 2000);
        }
        public IEnumerable<Book> BooksAndroid(){
            return ltsBooks.Where(book => book.Title.Contains("Android"));
        }
        public IEnumerable<Book> BooksAndroid2005(){
            return ltsBooks.Where(book => book.Title.Contains("Android") && book.PublishedDate.Year > 2005);
        }
        public IEnumerable<Book> BooksAction250(){
            return ltsBooks.Where(book => book.Title.Contains("in Action") && book.PageCount > 250);
        }
        public bool BooksAll(){
            return ltsBooks.All(book => book.Status != string.Empty);
        }
        
        public bool BooksAny(){
            return ltsBooks.Any(book => book.Status != string.Empty);
        }
        public  bool Only2005(){
            return ltsBooks.Any(book => book.PublishedDate.Year == 2005);
        }
        public IEnumerable<Book> BooksOnly2005(){
            if(Only2005())
            {
                return ltsBooks.Where(book => book.PublishedDate.Year == 2005); 
            }
                return new List<Book>();
        }
    }
