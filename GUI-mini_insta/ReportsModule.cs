using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_mini_insta
{
    internal class ReportsModule
    {
        public class Report
        {

            public string monthlyReport { get; set; }

            public string annualReport { get; set; }

            public int accounts { get; set; }

            public int userEngagement { get; set; }

            public void Display()
            {
                Console.WriteLine($"Your Bank accounts: {accounts}");
                Console.WriteLine($"Your Monthly report as follows: {monthlyReport}");
                Console.WriteLine($"Your annual report as follows: {annualReport}");
                Console.WriteLine($"Your Engagement as follows: {userEngagement}");
            }

        }

        public interface IReportBuilder
        {
            void SetMonthlyReport(string report);
            void SetAnnualReport(string report);
            void SetAccounts(int accountCount);
            void SetUserEngagement(int engagement);
            Report GetReport();
        }

        public class TransactionSummaryBuilder : IReportBuilder
        {
            private Report _report;

            public TransactionSummaryBuilder()
            {
                Reset();
            }

            private void Reset()
            {
                _report = new Report();
            }

            public void SetMonthlyReport(string report)
            {
                _report.monthlyReport = report;
            }

            public void SetAnnualReport(string report)
            {
                _report.annualReport = report;
            }

            public void SetAccounts(int accountCount)
            {
                _report.accounts = accountCount;
            }

            public void SetUserEngagement(int engagement)
            {
                _report.userEngagement = engagement;
            }

            public Report GetReport()
            {
                Report completedReport = _report;
                Reset();
                return completedReport;
            }
        }

        public class ReportDirector
        {
            private readonly IReportBuilder _builder;

            public ReportDirector(IReportBuilder builder)
            {
                _builder = builder;
            }

            public void BuildReport()
            {
                _builder.SetMonthlyReport("This is the monthly summary."); 
                _builder.SetAnnualReport("This is the annual summary.");
                _builder.SetAccounts(5); 
                _builder.SetUserEngagement(85); 
            }

            public Report GetReport()
            {
                return _builder.GetReport();
            }
        }
    }
}