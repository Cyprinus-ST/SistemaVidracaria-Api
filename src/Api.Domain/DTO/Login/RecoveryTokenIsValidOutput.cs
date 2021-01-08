using System;

namespace Api.Domain.DTO.Login
{
    public class RecoveryTokenIsValidOutput
    {
        public bool recoveryTokenIsValid { get; set; }
        public Guid userId { get; set; }
    }
}
