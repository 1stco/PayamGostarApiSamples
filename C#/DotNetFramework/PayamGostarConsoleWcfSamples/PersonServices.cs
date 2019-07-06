using System;
using PayamGostarConsoleWcfSamples.PgPerson;

namespace PayamGostarConsoleWcfSamples
{
    internal class PersonServices : IPersonServices
    {
        private readonly PersonClient _personClient;

        public PersonServices() : this(new PersonClient())
        {
            
        }

        public PersonServices(PersonClient personClient)
        {
            _personClient = personClient;
        }

        public PersonInfoResult FindPersonById(Guid personId)
        {
            return _personClient.FindPersonById(Auth.UserName, Auth.Password, personId);
        }
    }
}
