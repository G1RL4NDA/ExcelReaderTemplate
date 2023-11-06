using ExcelDataReader;

namespace Code.Scripts.XLSX
{
    public class SuccessStoryWriter : IExcelWritable<SuccessStory>
    {
        public int PageNumber => 2;
        
        public SuccessStory Create(IExcelDataReader reader)
        {
            return new SuccessStory()
            {
                fullName = reader.GetValue(1).ToString(),
                description = reader.GetValue(2).ToString(),
                year = int.Parse(reader.GetValue(3).ToString()),
                photo = reader.GetValue(4).ToString(),
            };
        }
    }
}