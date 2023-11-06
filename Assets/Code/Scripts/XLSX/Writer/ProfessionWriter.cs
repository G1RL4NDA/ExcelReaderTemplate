using System;
using ExcelDataReader;
using Unity.VisualScripting.Dependencies.NCalc;

namespace Code.Scripts.XLSX
{
    public class ProfessionWriter : IExcelWritable<Profession>
    {
        public int PageNumber => 0;

        public Profession Create(IExcelDataReader reader)
        {
            return new Profession()
            {
                name = reader.GetValue(1).ToString(),
                industry = reader.GetValue(2).ToString().ToIndustry(),
                shortDescription = reader.GetValue(3).ToString(),
                fullDescription = reader.GetValue(4).ToString(),
                soughtAfterProfession = reader.GetValue(5).ToString() == "1",
                imageName = reader.GetValue(6).ToString(),
            };
        }
    }
}