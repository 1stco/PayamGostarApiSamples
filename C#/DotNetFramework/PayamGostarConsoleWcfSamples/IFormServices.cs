namespace PayamGostarConsoleWcfSamples
{
    using PgForm;
    using System;

    internal interface IFormServices
    {
        FormInfoResult FindFormById(Guid formId);
    }
}
