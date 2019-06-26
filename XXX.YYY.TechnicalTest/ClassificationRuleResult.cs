namespace XXX.YYY.TechnicalTest
{
    public class ClassificationRuleResult
    {
        public ClassificationRuleResult(Person value, string rule1, string rule2, string rule3)
        {
            Value = value;
            Rule1 = rule1;
            Rule2 = rule2;
            Rule3 = rule3;
        }

        public Person Value { get; }
        public string Rule1 { get; }
        public string Rule2 { get; }
        public string Rule3 { get; }
    }
}