namespace PayamGostarConsoleWcfSamples
{
    using PgForm;
    using System;

    public class FormServices : IFormServices
    {
        private readonly FormClient _formClient;

        public FormServices() : this(new FormClient())
        {
            
        }

        public FormServices(FormClient formClient)
        {
            _formClient = formClient;
        }


        public FormInfoResult FindFormById(string username, string password, Guid formId)
        {
            return _formClient.FindFormById(username, password, formId);
        }
    }
}
