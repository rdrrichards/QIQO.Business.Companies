using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace QIQO.Business.Core
{
    public class QIQOController : Controller
    {
        protected readonly ILogger Logger;

        public QIQOController(ILogger<QIQOController> logger)
        {
            Logger = logger;
        }
        protected Task ExecuteHandledOperationAsync(Action codetoExecute)
        {
            return Task.Run(() => ExecuteHandledOperation(codetoExecute));
        }

        protected void ExecuteHandledOperation(Action codetoExecute)
        {
            try
            {
                codetoExecute.Invoke();
            }
            catch (Exception ex)
            {
                Logger.LogError($"{ex.Source}:{ex.Message}");
                throw ex;
            }
        }

        protected Task<IActionResult> ExecuteHandledOperationAsync<T>(Func<T> codetoExecute)
        {
            return Task.Run(() => ExecuteHandledOperation(codetoExecute));
        }

        protected IActionResult ExecuteHandledOperation<T>(Func<T> codetoExecute)
        {
            try
            {
                return Json(codetoExecute.Invoke());
            }
            catch (Exception ex)
            {
                Logger.LogError($"{ex.Source}:{ex.Message}");
                return Json(ex);
            }
        }

    }
}
