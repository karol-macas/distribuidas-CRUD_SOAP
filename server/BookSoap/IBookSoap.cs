using System.Collections.Generic;
using System.ServiceModel;

[ServiceContract]
public interface IBookSoap
{
    [OperationContract]
    Book CreateBook(BookDTO newBook);

    [OperationContract]
    Book UpdateBook(Book updateBook);

    [OperationContract]
    Book DeleteBook(int id);

    [OperationContract]
    Book GetBook(int id);

    [OperationContract]
    List<Book> GetBooks();
}
