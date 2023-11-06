using ExcelDataReader;

namespace Code.Scripts.XLSX
{
    public interface IExcelWritable<out T>
    {
        public int PageNumber { get; }
        
        public T Create(IExcelDataReader reader);
    }
}