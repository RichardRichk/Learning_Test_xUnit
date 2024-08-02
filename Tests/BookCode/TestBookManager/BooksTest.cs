using Gerenciamento_de_livros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestBookManager
{
    public class BooksTest
    {
        [Fact]
        public void NewBook()
        {
            // Arrange: Cria uma lista de livros e um livro a ser adicionado
            var bookList = new List<Books>();
            var book = new Books("Percy Jackson", "Fiction");

            // Act: Adiciona o livro à lista
            bookList.Add(book);

            // Assert: Verifica se o livro foi adicionado corretamente à lista
            Assert.Contains(book, bookList);
        }
    }
}
