using Lumper.Data;
using Lumper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lumper.DAL
{
    public class UnitOfWork : IDisposable
    {
        #region [Attribute]
        private ApplicationDbContext context;
        private GenericRepository<Customer> customerRepository;
        private GenericRepository<Application> applicationRepository;
        private GenericRepository<Comment> commentRepository;
        private GenericRepository<UserRating> userRatingRepository;
        #endregion

        #region [Constructor]
        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
        }
        #endregion

        #region [Properties]
        public GenericRepository<Customer> CustomerRepository
        {
            get
            {
                if (this.customerRepository == null)
                {
                    this.customerRepository = new GenericRepository<Customer>(context);
                }
                return customerRepository;
            }
        }

        public GenericRepository<Application> ApplicationRepository
        {
            get
            {
                if (this.applicationRepository == null)
                {
                    this.applicationRepository = new GenericRepository<Application>(context);
                }
                return applicationRepository;
            }
        }

        public GenericRepository<Comment> CommentRepository
        {
            get
            {
                if (this.commentRepository == null)
                {
                    this.commentRepository = new GenericRepository<Comment>(context);
                }
                return commentRepository;
            }
        }

        public GenericRepository<UserRating> UserRatingRepository
        {
            get
            {
                if (this.userRatingRepository == null)
                {
                    this.userRatingRepository = new GenericRepository<UserRating>(context);
                }
                return userRatingRepository;
            }
        }
        #endregion

        #region [SaveChanges]
        public void Save() => context.SaveChanges();
        #endregion

        #region [Dispose]
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
