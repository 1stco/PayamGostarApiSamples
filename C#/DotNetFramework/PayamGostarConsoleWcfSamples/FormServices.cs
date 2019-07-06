namespace PayamGostarConsoleWcfSamples
{
    using PgForm;
    using System;

    internal class FormServices : IFormServices
    {
        private readonly FormClient _formClient;

        public FormServices() : this(new FormClient())
        {
            
        }

        public FormServices(FormClient formClient)
        {
            _formClient = formClient;
        }


        public FormInfoResult FindFormById(Guid formId)
        {
            return _formClient.FindFormById(Auth.UserName, Auth.Password, formId);
        }
    }
}
