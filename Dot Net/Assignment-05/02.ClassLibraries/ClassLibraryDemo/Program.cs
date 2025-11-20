
using CompA = CompanyA.Reporting.Report;
using CompB = CompanyB.Analytics.Report;

CompA report1 = new CompA();
CompB report2 = new CompB();


report1.Generate();
report2.Generate();