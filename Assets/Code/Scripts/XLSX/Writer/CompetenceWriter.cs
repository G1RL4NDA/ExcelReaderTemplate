using ExcelDataReader;

namespace Code.Scripts.XLSX
{
    public class CompetenceWriter : IExcelWritable<Competence>
    {
        public int PageNumber => 1;
        
        public Competence Create(IExcelDataReader reader)
        {
            return new Competence()
            {
                competence = reader.GetValue(0).ToString(),
                industry = reader.GetValue(1).ToString().ToIndustry(),
                group = reader.GetValue(2)?.ToString(),
            };
        }
    }
}