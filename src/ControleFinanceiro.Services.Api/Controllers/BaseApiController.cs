using System.Collections.Generic;
using System.Linq;
using ControleFinanceiro.Domain.Validations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ControleFinanceiro.Services.Api.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class BaseApiController : ControllerBase
    {
        private readonly ICollection<string> _errors = new List<string>();

        protected ActionResult CustomResponse(object result = null)
        {
            if (IsOperationValid())
            {
                return Ok(result);
            }

            return BadRequest(new ValidationProblemDetails(new Dictionary<string, string[]>
            {
                { "Messages", _errors.ToArray() }
            }));
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            var errors = modelState.Values.SelectMany(e => e.Errors);
            foreach (var error in errors)
            {
                AddError(error.ErrorMessage);
            }

            return CustomResponse();
        }

        protected ActionResult CustomResponse(IValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors.Value)
            {
                AddError(error);
            }

            return CustomResponse();
        }

        protected bool IsOperationValid()
        {
            return !_errors.Any();
        }

        protected void AddError(string erro)
        {
            _errors.Add(erro);
        }

        protected void ClearErrors()
        {
            _errors.Clear();
        }
    }
}
