using System.Collections.Generic;

namespace XXX.YYY.TechnicalTest
{
    public class PersonSmallDataService : IPersonDataService
    {
        public IEnumerable<Person> Get()
        {
            return new List<Person>
            {
                new Person
                {
                    Gender = Domain.Gender.MALE,
                    Country = Domain.Country.UK,
                    GrossSalary = 1,
                    Age = 10
                },
                new Person
                {
                    Gender = Domain.Gender.MALE,
                    Country = Domain.Country.UK,
                    GrossSalary = 2,
                    Age = 20
                },
                new Person
                {
                    Gender = Domain.Gender.MALE,
                    Country = Domain.Country.FRANCE,
                    GrossSalary = 3,
                    Age = 30
                },
                new Person
                {
                    Gender = Domain.Gender.MALE,
                    Country = Domain.Country.FRANCE,
                    GrossSalary = 4,
                    Age = 40
                },
                new Person
                {
                    Gender = Domain.Gender.FEMALE,
                    Country = Domain.Country.USA,
                    GrossSalary = 5,
                    Age = 50
                },
                new Person
                {
                    Gender = Domain.Gender.FEMALE,
                    Country = Domain.Country.USA,
                    GrossSalary = 6,
                    Age = 60
                },
                new Person
                {
                    Gender = Domain.Gender.FEMALE,
                    Country = Domain.Country.USA,
                    GrossSalary = 7,
                    Age = 70
                },
                new Person
                {
                    Gender = Domain.Gender.FEMALE,
                    Country = Domain.Country.ASIA,
                    GrossSalary = 8,
                    Age = 80
                },
                new Person
                {
                    Gender = Domain.Gender.FEMALE,
                    Country = Domain.Country.ASIA,
                    GrossSalary = 9,
                    Age = 90
                },
                new Person
                {
                    Gender = Domain.Gender.UNKNOWN,
                    Country = Domain.Country.ASIA,
                    GrossSalary = 10,
                    Age = 90
                },
            };
        }
    }
}