using System;
using System.Collections.Generic;

namespace XXX.YYY.TechnicalTest
{
    public interface IReportingService
    {
        /// <summary>
        /// Returns the average GrossSalary for all persons.
        /// </summary>
        string BuildAverageSalary();

        /// <summary>
        /// Returns the average GrossSalary by Gender for all persons, in the following format:
        /// {Gender} - {average GrossSalary}
        /// </summary>
        IEnumerable<string> BuildAverageSalaryByGender();

        /// <summary>
        /// Returns the average GrossSalary by <param name="groupByFunc"></param> for all persons, in the following format:
        /// {group key} - {average GrossSalary}
        /// </summary>
        IEnumerable<string> BuildAverageSalaryBy<TKey>(Func<Person, TKey> groupByFunc);

        /// <summary>
        /// Returns the average GrossSalary for persons filtered by <param name="whereFunc"></param>.
        /// </summary>
        string BuildAverageSalaryWhere(Func<Person, bool> whereFunc);

        /// <summary>
        /// Returns the average GrossSalary by <param name="groupByFunc"></param> for persons filtered by <param name="whereFunc"></param>, in the following format:
        /// {group key} - {average GrossSalary}
        /// </summary>
        IEnumerable<string> BuildAverageSalaryWhereBy<TKey>(Func<Person, bool> whereFunc, Func<Person, TKey> groupByFunc);
    }
}