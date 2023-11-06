using System;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

namespace Code.Scripts.XLSX
{
    public class XLSXRequester : MonoBehaviour
    {
        [SerializeField] private List<JobIndustry> jobIndustries;
        
        private void Start()
        {
            jobIndustries = XLSXReader.ReadFile(new JobIndustryWriter());
        }
    }
}