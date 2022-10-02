using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TownManager : MonoBehaviour
{
    int totalFood;
    int totalMaterial;
    int totalKnowledge;
    int totalReligion;
    int totalMilitary;
    int totalCommerce;

    List<LegendIcons> legendIcondList;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateStats(LegendIcons newLegendIcon) {
        totalCommerce += newLegendIcon.military;
        totalFood += newLegendIcon.food;
        totalKnowledge += newLegendIcon.knowledge;
        totalMilitary += newLegendIcon.military;
        totalMaterial += newLegendIcon.material;
        totalReligion += newLegendIcon.religion;
    }
}
