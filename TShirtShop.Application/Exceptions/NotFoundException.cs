using System;

namespace TShirtShop.Application.Exceptions
{
    public class NotFoundException : Exception
    {
        // TODO: Move to resource
        public NotFoundException(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        {
        }
    }
}
