using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using fruit_api.Models;

namespace fruit_api
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields

        private readonly FruitContext _dbContext;
        private bool disposed;

        #endregion

        public List<string> ValidationErrors { get; set; }

        #region Constructors

        public UnitOfWork(IRepository<FruitItem> fruitRepository, FruitContext dbContext)

        {
            // set to public auto properties 
            FruitRepository = fruitRepository;
            _dbContext = dbContext;
            //ShouldDispose = false;

            SetupContextForRepositories();

            //ValidationErrors = new List<string>();
        }


        #endregion

        #region Private Methods

        private void SetupContextForRepositories()
        {
            IEnumerable<PropertyInfo> properties = GetType().GetProperties().Where(p => p.Name.ToLower().EndsWith("repository"));
            foreach (PropertyInfo propertyInfo in properties)
            {
                // find the context property
                dynamic repo = propertyInfo.GetValue(this, null);
                repo.Context = _dbContext;
                repo.UnitOfWork = this;
            }
        }

        #endregion

        #region Protected Methods

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            disposed = true;
        }

        #endregion

        #region IUnitOfWork Members

        // public bool ShouldDispose { get; set; }
        // public string InitialisedMethod { get; set; }

        public IRepository<FruitItem> FruitRepository { get; set; }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        // public void AddValidationErrors(ValidationResults validationResults)
        // {
        //     foreach (var validationResult in validationResults)
        //     {
        //         ValidationErrors.Add(validationResult.Message); 
        //     }
        // }

        // public void AddValidationError(ValidationResult validationResult)
        // {
        //     ValidationErrors.Add(validationResult.Message); 
        // }

        #endregion

        // public Guid GetGuidForSavedModel(Type modelType, string guidPropertyName)
        // {
        //     Guid guid = Guid.Empty;

        //     foreach (var savedEntity in _dbContext.SavedEntities)
        //     {
        //         if (savedEntity.Key == modelType)
        //         {
        //             var value = savedEntity.Value;
        //             guid = (Guid)value.GetType().GetProperty(guidPropertyName).GetValue(value, null);

        //             break;
        //         }
        //     }

        //     return guid;
        // }



    }
}
