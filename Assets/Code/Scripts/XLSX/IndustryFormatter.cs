using System;

namespace Code.Scripts.XLSX
{
    public static class IndustryFormatter
    {
        private const string Healthcare = "Здравоохранение";
        private const string Education = "Образование";
        private const string Transport = "Транспорт и логистика"; 
        private const string Construction = "Строительство";
        private const string Agriculture = "Сельское хозяйство";
        private const string IT = "IT-сфера";
        private const string Tourism = "Туризм и гостеприимство";
        
        public static Industry ToIndustry(this string name)
        {
            return name switch
            {
                Healthcare => Industry.Healthcare,
                Education => Industry.Education,
                Transport => Industry.Transport,
                Construction => Industry.Construction,
                Agriculture => Industry.Agriculture,
                IT => Industry.IT,
                Tourism => Industry.Tourism,
                _ => throw new ArgumentOutOfRangeException(nameof(name), name, null)
            };
        }
    }
}