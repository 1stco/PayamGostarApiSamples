namespace PayamGostarConsoleWcfSamples
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Init
            IFormServices form = new FormServices();
            IPersonServices person = new PersonServices();

            // Form samples
            var findFormById = form.FindFormById(Guid.NewGuid());

            // Person samples
            var findPersonById = person.FindPersonById(Guid.NewGuid());
        }
    }
}
