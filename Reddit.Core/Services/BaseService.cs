using System;
using System.Net;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using Polly;
using Polly.Fallback;
using Polly.Timeout;
using Polly.Wrap;
using Reddit.Core.Services.Interfaces;

namespace Reddit.Core.Services
{
    public class BaseService
    {
        public IApiService ApiService { get; private set; }
        public IMvxTrace Logger { get; private set; }

        public BaseService()
        {
            ApiService = Mvx.Resolve<IApiService>();
            Logger = Mvx.Resolve<IMvxTrace>();
        }

        public PolicyWrap<T> GetPolicy<T>()
        {
            var timeoutPolicy = Policy
               .TimeoutAsync(GlobalConstants.Api.TimeoutSpan, TimeoutStrategy.Pessimistic);

            var waitAndRetryPolicy = Policy
                  .Handle<Exception>()
                 .WaitAndRetryAsync(
                      retryCount: GlobalConstants.Api.RetryCount,
                      sleepDurationProvider: (arg) => GlobalConstants.Api.SleepRetrySpan,
                      onRetry: (exception, calculatedWaitDuration) =>
                      {
                      Logger.Trace(MvxTraceLevel.Error, "Base service", exception.Message);
                      //if (exception is Exceptions.MommrException)
                      //throw exception;
                  });

            FallbackPolicy<T> fallbackForTimeout = Policy<T>
                 .Handle<TimeoutRejectedException>()
                  .Or<WebException>()
                  .Or<TimeoutException>()
                  .FallbackAsync(
                      fallbackValue: default(T),
                   onFallbackAsync: async b =>
                   {
                    Logger.Trace(MvxTraceLevel.Error, "Base service", b.Exception.Message);
               }
                );

            FallbackPolicy<T> fallbackForAnyException = Policy<T>
              .Handle<Exception>()
               .FallbackAsync(
                    fallbackAction: async ct =>
                    {
                        return default(T);
                    },
                    onFallbackAsync: async e =>
                    {
                    Logger.Trace(MvxTraceLevel.Error, "Base service", e.Exception.Message);
                    throw e.Exception;
                }
              );

            return fallbackForAnyException
             .WrapAsync(fallbackForTimeout)
             .WrapAsync(waitAndRetryPolicy)
             .WrapAsync(timeoutPolicy);
        }

        public PolicyWrap GetPolicy()
        {
            var timeoutPolicy = Policy
               .TimeoutAsync(GlobalConstants.Api.TimeoutSpan, TimeoutStrategy.Pessimistic);

            var waitAndRetryPolicy = Policy
                  .Handle<Exception>()
                 .WaitAndRetryAsync(
                      retryCount: GlobalConstants.Api.RetryCount,
                      sleepDurationProvider: (arg) => GlobalConstants.Api.SleepRetrySpan,
                      onRetry: (exception, calculatedWaitDuration) =>
                      {
                      Logger.Trace(MvxTraceLevel.Error, "Base service", exception.Message);
                      //if (exception is Exceptions.MommrException)
                      //throw exception;
                  });

            FallbackPolicy fallbackForTimeout = Policy
               .Handle<TimeoutRejectedException>()
                  .Or<WebException>()
                  .Or<TimeoutException>()
                  .FallbackAsync(
                      fallbackAction: async ct => { },
                     onFallbackAsync: async b =>
                     {
                     Logger.Trace(MvxTraceLevel.Error, "Base service", b.Message);
                 }
                );

            FallbackPolicy fallbackForAnyException = Policy
                .Handle<Exception>()
               .FallbackAsync(
                    fallbackAction: async ct => { },
                   onFallbackAsync: async e =>
                   {
                   Logger.Trace(MvxTraceLevel.Error, "Base service", e.Message);
                   throw e;
               }
              );

            return fallbackForAnyException
             .WrapAsync(fallbackForTimeout)
             .WrapAsync(waitAndRetryPolicy)
             .WrapAsync(timeoutPolicy);
        }
    }
}
