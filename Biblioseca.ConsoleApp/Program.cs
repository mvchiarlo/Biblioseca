using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioseca.Model;
using NHibernate;
using NHibernate.Cfg;


namespace Biblioseca.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)

        {
            ISessionFactory sessionFactory = new Configuration()
                .Configure()
                .BuildSessionFactory();


            ISession session = sessionFactory.OpenSession();


            List<int> values1 = new List<int>();
            values1.Add(1);

            List<string> values2 = new List<string>();
            values2.Add("hello world!");


            // Author author = session.Get<Author>(1);
            //Category category = session.Get<Category>(1);
            //Book book = new Book();
            //book.Title = "Op masacre";
            //book.Author = author;
            //book.Description = "dsfjgrengtht";
            //book.Category = category;
            //book.ISBN = "123345";
            //book.Price = 1000;
            //session.Save(book);

            //Book book = session.Get<Book>(1);



            //Author author = new Author();
            //author.FirstName = "Ernesto";
            //author.LastName = "Sábato";



            //Author author2 = new Author();
            //author.FirstName = "Ernesto";
            //author.LastName = "Sanchez";

            //session.Save(author2);

            //Console.WriteLine(author2.Id);

            Console.ReadKey();
        }
    }



}

