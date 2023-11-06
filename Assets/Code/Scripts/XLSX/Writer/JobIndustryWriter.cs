using System.Collections.Generic;
using ExcelDataReader;

namespace Code.Scripts.XLSX
{
    public class JobIndustryWriter : IExcelWritable<JobIndustry>
    {
        public int PageNumber => 4;
        public JobIndustry Create(IExcelDataReader reader)
        {
            var jobIndustry = new JobIndustry()
            {
                industry = reader.GetValue(1).ToString().ToIndustry(),
                description = reader.GetValue(2).ToString(),
                industryFact = new List<IndustryFact> {GetFact(reader)}
            };
            
            while (reader.Read())
            {
                if(reader.GetValue(0) != null) break;
                
                jobIndustry.industryFact.Add(GetFact(reader));
            }

            return jobIndustry;
        }

        private IndustryFact GetFact(IExcelDataReader reader)
        {
            return new IndustryFact()
            {
                firstField = reader.GetValue(3)?.ToString(),
                secondField = reader.GetValue(4)?.ToString(),
                thirdField = reader.GetValue(5)?.ToString(),
            };
        }
    }
}