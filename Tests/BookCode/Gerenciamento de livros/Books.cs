using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_livros
{
    public class Books
    {
        public string Title { get; set; }

        public string Gender { get; set; }

        public Books(string title, string gender)
        {
            Title = title;
            Gender = gender;
        }
    }
}
