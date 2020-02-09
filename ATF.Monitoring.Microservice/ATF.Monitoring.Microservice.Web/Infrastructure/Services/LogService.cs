﻿using System;
using Calabonga.EntityFrameworkCore.UOW;
using ATF.Monitoring.Microservice.Core.Exceptions;
using ATF.Monitoring.Microservice.Data;
using ATF.Monitoring.Microservice.Entities;
using Microsoft.Extensions.Logging;

namespace ATF.Monitoring.Microservice.Web.Infrastructure.Services
{
    /// <summary>
    /// Business logic logger can save messages to database
    /// </summary>
    public class LogService:ILogService
    {
        private readonly IUnitOfWork<ApplicationDbContext> _unitOfWork;

        /// <inheritdoc />
        public LogService(IUnitOfWork<ApplicationDbContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        /// <inheritdoc />
        public void LogInformation(string message)
        {
            Log(LogLevel.Information, message);
        }

        /// <summary>
        /// Allows to save data logs to the database Logs table
        /// </summary>
        private void Log(LogLevel level, string message, Exception exception = null)
        {
            var logs = _unitOfWork.GetRepository<Log>();
            var log = new Log
            {
                CreatedAt = DateTime.UtcNow,
                Level = level.ToString(),
                Logger = GetType().Name,
                Message = message,
                ThreadId = "0",
                ExceptionMessage = exception?.Message
            };
            logs.Insert(log);
            _unitOfWork.SaveChanges();
            if (!_unitOfWork.LastSaveChangesResult.IsOk)
            {
                throw new MicroserviceInvalidOperationException();
            }
        }
    }
}