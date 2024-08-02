using MailCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailTest
{
    public class MailTest
    {

        public static IEnumerable<object[]> MailData =>
        new List<object[]>
        {
            new object[] { "teste@dominio.com", true },
            new object[] { "teste@dominio", false },
            new object[] { "teste.dominio.com", false },
            new object[] { "teste@.com", false },
            new object[] { "@dominio.com", false },
            new object[] { "", false },
            new object[] { null, false }
        };

        [Theory]
        [MemberData(nameof(MailData))]
        public void MailValidation(string mail, bool expected)
        {
            // Act
            bool result = Mail.ValidationMail(mail);

            // Assert
            Assert.Equal(expected, result);
        }
    }
    
}
