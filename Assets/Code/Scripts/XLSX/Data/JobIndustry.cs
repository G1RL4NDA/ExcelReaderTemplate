using System.Collections.Generic;
using Unity.VisualScripting;

namespace Code.Scripts.XLSX
{
    [System.Serializable]
    public struct JobIndustry
    {
        public Industry industry;
        public string description;
        public List<IndustryFact> industryFact;
    }

    [System.Serializable]
    public struct IndustryFact
    {
        public string firstField;
        public string secondField;
        public string thirdField;
    }
}