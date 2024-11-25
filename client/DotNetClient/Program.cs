using DotNetClient;

class Program
{
    static void Main()
    {

        var client = new BookSoapClient();
        var newBook = new BookDTO
        {
            Title = " book 1",
            Author = "Jose",
            Year = 2024
        };

        try
        {
            var createdBook = client.CreateBookAsync(newBook).Result;

            Console.WriteLine($"New book id: {createdBook.Id}");

            var books = client.GetBooksAsync().Result;

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}: {book.Title} - {book.Author}");
            }

            Console.ReadLine();

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
        finally
        {
            client.CloseAsync().Wait();
        }
    }
}