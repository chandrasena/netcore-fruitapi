using System;
using fruit_api.Models;

namespace fruit_api
{
    public interface IUnitOfWork : IDisposable
    {
        #region Properties

        IRepository<FruitItem> FruitRepository { get; set; }

        #endregion

        #region Public Methods

        void SaveChanges();

        // void AddValidationErrors(ValidationResults validationResults);

        // void AddValidationError(ValidationResult validationResult);

        #endregion
    }
}