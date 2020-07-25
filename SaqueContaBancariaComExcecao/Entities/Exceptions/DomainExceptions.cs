using System;

namespace SaqueContaBancariaComExcecao.Entities.Exceptions
{
    class DomainExceptions :ApplicationException
    {
        public DomainExceptions (string message) : base(message)
        {

        }
    }
}
