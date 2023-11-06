using System.Collections.Generic;
using UnityEngine;

namespace Code.Scripts.XLSX
{
    public struct Company
    {
        public string name;
        public string activity;
        public string description;
        public Wages wages;
        public List<string> vacancy;
        public string logoName;
        public string website;
        public Location location;
        public List<string> advantages;
        public List<string> socialPackage;
        public bool isLeadingCompany;
    }

    public struct Wages
    {
        public string prefix;
        public int number;
    }

    public struct Location
    {
        public string name;
        public Vector2 coordinates;

        public Location(string name, Vector2 coordinates)
        {
            this.name = name;
            this.coordinates = coordinates;
        }
    }
}