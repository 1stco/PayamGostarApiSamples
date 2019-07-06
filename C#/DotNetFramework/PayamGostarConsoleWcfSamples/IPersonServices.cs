namespace PayamGostarConsoleWcfSamples
{
    using PgPerson;
    using System;

    internal interface IPersonServices
    {
        PersonInfoResult FindPersonById(Guid personId);
        SaveCrmObjectResult SavePerson(PersonInfo personInfo);
    }
}
