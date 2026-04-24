using TheGreatLogbook.DAL;
using TheGreatLogbook.Entities;

namespace TheGreatLogbook.BLL
{
    public class BookBLL
    {
        BookDAL dal = new BookDAL();

        public List<Book> GetBooks()
        {
            return dal.GetAll();
        }

        public void AddBook(Book book)
        {
            if (string.IsNullOrWhiteSpace(book.Title))
                throw new Exception("El título es obligatorio");

            if (book.Price <= 0)
                throw new Exception("Precio inválido");

            dal.Insert(book);
        }

        public void UpdateBook(Book book)
        {
            if (book.Id <= 0)
                throw new Exception("ID inválido");

            dal.Update(book);
        }

        public void DeleteBook(int id)
        {
            dal.Delete(id);
        }
    }
}