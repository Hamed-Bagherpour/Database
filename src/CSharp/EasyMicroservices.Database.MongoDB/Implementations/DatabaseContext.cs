﻿using EasyMicroservices.Database.Interfaces;
using MongoDB.Driver;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMicroservices.Database.MongoDB.Implementations
{
    internal class DatabaseContext : IContext
    {
        public DatabaseContext(IMongoDatabase dbContext)
        {
            _dbContext = dbContext;
            ContextType = _dbContext.GetType();
        }

        IMongoDatabase _dbContext;
        public Type ContextType { get; set; }

        public string GetContextName()
        {
            return _dbContext.DatabaseNamespace.DatabaseName;
        }

        public void ChangeModificationPropertyState<T>(T entity, string property, bool isModified) where T : class
        {

        }

        public Task Reload<T>(T entity, CancellationToken cancellationToken) where T : class
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public virtual void Dispose()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public ValueTask DisposeAsync()
        {
            return ValueTask.CompletedTask;
        }
    }
}
