using System.Linq;
using practicaLinq;
internal class Program
{
    private static void Main(string[] args)
    {
        LinqQueries querie= new LinqQueries();
        // ImprimirValores(querie.BooksAction250());
        // ImprimirValores(querie.AllCollection());
        // Console.WriteLine(querie.BooksAll()?"Todos los libros tienen un Status PUBLISH (ALL)":"No se cumplio");
        // Console.WriteLine(querie.BooksAny()?"Almenos un libro tiene un Status PUBLISH (ANY)":"No se cumplio");
        ImprimirValores(querie.BooksOnly2005());
        
        // if(querie.BooksAll()){
        //     Console.WriteLine("Todos los libros tienen un Status PUBLISH (ALL)");
        // }
        // if(querie.BooksAny()){
        //     Console.WriteLine("Al menos un libro tienen un Status PUBLISH (ANY)");
        // }
        
    }

    private static void ImprimirValores(IEnumerable<Book> books)
    {
        int registro = 0;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("{0,-70} {1,7} {2,20}", "Titulo", "N. Paginas", "Fecha publicacion");
        foreach (Book book in books)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            registro += 1;
            Console.WriteLine("{0,-70} {1,7} {2,20}",book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
        }
    }
}