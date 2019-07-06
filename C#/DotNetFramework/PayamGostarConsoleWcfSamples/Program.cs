namespace PayamGostarConsoleWcfSamples
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            IFormServices form = new FormServices();

            // Form
            var findFormById = form.FindFormById("admin", "admin", Guid.NewGuid());
        }
    }
}
