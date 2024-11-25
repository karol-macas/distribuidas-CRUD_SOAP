from zeep import Client

url = "http://localhost:2317/BookSoap?wsdl"
client = Client(url)

# Crear un libro
new_book = {"Title": "Libro de Prueba", "Author": "Autor Prueba", "Year": 2024}
response = client.service.CreateBook(newBook=new_book)
print("Libro creado:", response)

# Obtener todos los libros
books = client.service.GetBooks()
print("Lista de libros:", books)

# Obtener un libro por ID
book = client.service.GetBook(1)
print("Libro por ID:", book)

# Actualizar un libro
update_book = {"Id": 2, "Title": "Libro Actualizado", "Author": "Autor Actualizado", "Year": 2019}
response = client.service.UpdateBook(updateBook=update_book)
print("Libro actualizado:", response)

# Eliminar un libro
response = client.service.DeleteBook(3)
print("Libro eliminado:", response)
