using System.Collections.Generic;
using System.Linq;
using Biblioseca.DataAccess;
using Biblioseca.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;

namespace Biblioseca.Test.DataAccess
{
    [TestClass]
    public class AuthorDaoTest
    {
        private ISessionFactory sessionFactory;
        private ISession session;
        private ITransaction transaction;

        [TestInitialize]
        public void SetUp()
        {
            this.sessionFactory = new Configuration().Configure().BuildSessionFactory();
            this.session = this.sessionFactory.OpenSession();
            this.transaction = this.session.BeginTransaction();
            CurrentSessionContext.Bind(this.session);
        }

        [TestCleanup]
        public void CleanUp()
        {
            this.transaction.Rollback();
            this.session.Close();
        }
        
        [TestMethod]
        public void GetAll()
        {
            AuthorDao authorDao = new AuthorDao(this.sessionFactory);
            
            IEnumerable<Author> authors = authorDao.GetAll();
            
            Assert.IsTrue(authors.Any());
        }
    }
}