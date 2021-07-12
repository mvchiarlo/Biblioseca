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
           



            Author author = new Author();
            author.FirstName = "Ernesto";
            author.LastName = "Sábato";



            Author author2 = new Author();
            author.FirstName = "Ernesto";
            author.LastName = "Sanchez";

            session.Save(author2);

            Console.WriteLine(author2.Id);
            
            Console.ReadKey();
        }
    }



}

