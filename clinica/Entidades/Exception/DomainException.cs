namespace clinica.Entidades.Exception
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
