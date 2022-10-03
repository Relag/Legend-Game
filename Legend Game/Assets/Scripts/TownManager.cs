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
    int foodUsed;
    int knowledgeUsed;
    int materialUsed;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateStats(LegendIcons newLegendIcon) {
        totalCommerce += newLegendIcon.commerce;
        totalFood += newLegendIcon.foodGiven;
        totalKnowledge += newLegendIcon.knowledgeGiven;
        totalMilitary += newLegendIcon.military;
        totalMaterial += newLegendIcon.materialGiven;
        totalReligion += newLegendIcon.religion;
    }

    public int foodAvailable() { return totalFood - foodUsed; }
    public int materialAvailable() { return totalMaterial - materialUsed; }
    public int knowledgeAvailable() { return totalKnowledge - knowledgeUsed; }
}
