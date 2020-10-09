using System.Collections;
using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Validation
{
    public interface IValidationResult
    {
        Error Errors { get; }
        object Data { get; set;}
        bool IsValid { get; }
        void AddError(string error);
    }
}
