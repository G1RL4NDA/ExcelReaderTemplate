using ExcelDataReader;

namespace Code.Scripts.XLSX
{
    public class CareerDirectionWriter : IExcelWritable<CareerDirection>
    {
        public int PageNumber => 3;

        public CareerDirection Create(IExcelDataReader reader)
        {
            return new CareerDirection()
            {
                title = reader.GetValue(1).ToString(),
                description = reader.GetValue(2).ToString(),
                iconName = reader.GetValue(3).ToString()
            };
        }
    }
}