using System.Collections.Generic;

namespace XXX.YYY.TechnicalTest
{
    public interface IClassificationRulesEngine
    {
        IEnumerable<ClassificationRuleResult> Execute(IEnumerable<Person> persons);
    }
}