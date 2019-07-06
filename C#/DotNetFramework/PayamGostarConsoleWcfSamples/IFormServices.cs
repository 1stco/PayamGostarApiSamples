namespace PayamGostarConsoleWcfSamples
{
    using PgForm;
    using System;

    public interface IFormServices
    {
        FormInfoResult FindFormById(string username, string password, Guid formId);
    }
}
