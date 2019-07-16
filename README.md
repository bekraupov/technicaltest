# .NET Interview Coding Task

You have been given a solution with one project in it - 'XXX.YYY.TechnicalTest'.

- Create a new project called 'XXX.YYY.TechnicalTest.Implementation' and use this for your implementation code.
- Create a new project called 'XXX.YYY.TechnicalTest.Implementation.Tests' and use this for your test code.

## ClassificationRules

### AgeClassificationRule
1) Write an implementation of 'XXX.YYY.TechnicalTest.IAgeClassificationRule' that classifies a persons age as follows:
- If the persons age is less than 30, then return 'Domain.AgeClassification.LOW'
- If the persons age is between 30 and 60, then return 'Domain.AgeClassification.MEDIUM'
- If the persons age is equal to or greater than 60, then 'Domain.AgeClassification.HIGH'
2) Write appropriate tests.

### ContinentClassificationRule
1) Write an implementation of 'XXX.YYY.TechnicalTest.IContinentClassificationRule' that classifies a persons country as follows:
- If the persons country is the "UK", then return 'Domain.ContinentClassification.EMEA'
- If the persons country is the "France", then return 'Domain.ContinentClassification.EMEA'
- If the persons country is the "US", then return 'Domain.ContinentClassification.AMER'
- If the persons country is the "Asia", then return 'Domain.ContinentClassification.APAC'
- If the persons country is none of the above, then return 'Domain.ContinentClassification.UNKNOWN'
2) Write appropriate tests.

### SalaryClassificationRule
1) Write an implementation of 'XXX.YYY.TechnicalTest.ISalaryClassificationRule' that classifies a persons gross salary as follows:
- If the persons gross salary is less than 10000, then return 'Domain.SalaryClassification.BAND_1'
- If the persons gross salary is less than 20000, then return 'Domain.SalaryClassification.BAND_2'
- If the persons gross salary is less than 30000, then return 'Domain.SalaryClassification.BAND_3'
- If the persons gross salary is less than 40000, then return 'Domain.SalaryClassification.BAND_4'
- If the persons gross salary is equal to or greater than 40000, then return 'Domain.SalaryClassification.BAND_5'
2) Write appropriate tests.

## ClassificationRulesEngine
1) Write an implementation of 'XXX.YYY.TechnicalTest.Implementation.IClassificationRulesEngine'. For each person, run the classification rules created above and return a 'ClassificationRuleResult', assigning the results from the classification rules as follows:
- Rule1 = AgeClassificationRule
- Rule2 = ContinentClassificationRule
- Rule3 = SalaryClassificationRule
1.1) Demonstrate usage of CI
2) Write appropriate tests (demonstrate usage of Mocking).

# ReportingService
1) Write an implementation of 'XXX.YYY.TechnicalTest.IReportingService' and implement all the methods on the interface. The list of persons can get retrieved from 'XXX.YYY.TechnicalTest.IPersonDataService.Get()'. Demonstrate usage of DI
2) Write appropriate tests. (demonstrate usage of Mocking)
