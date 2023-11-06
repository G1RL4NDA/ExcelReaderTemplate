using UnityEngine.Serialization;

namespace Code.Scripts.XLSX
{
    [System.Serializable]
    public struct Profession
    {
        public string name;
        public Industry industry;
        public string shortDescription;
        public string fullDescription;
        public bool soughtAfterProfession;
        public string imageName;
    }

    public enum Industry
    {
        Healthcare,
        Education,
        Transport,
        Construction,
        Agriculture,
        IT,
        Tourism,
    }
}