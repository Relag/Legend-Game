using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TownManager : MonoBehaviour
{
    public static TownManager townManager;
    public List<LegendIcons> icons = new List<LegendIcons>();

    private void Awake() {
        if (townManager != null) {
            Destroy(gameObject);
        }
        else {
            townManager = this;
        }
    }

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
        totalFood = 0;
        foodUsed = 0;
        totalMaterial = 0;
        materialUsed = 0;
        totalKnowledge = 0;
        knowledgeUsed = 0;
        totalCommerce = 0;
        totalReligion = 0;
        totalMilitary = 0;

        icons.Add(new Blacksmith());
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

    public List<string> getStats() {
        List<string> stats = new List<string>();
        stats.Add("Military\t" + totalMilitary);
        stats.Add("Commerce\t" + totalCommerce);
        stats.Add("Religion\t" + totalReligion + "/" + totalFood);
        stats.Add("Food\t" + foodUsed + "/" + totalFood);
        stats.Add("Materials\t" + materialUsed + " / " + totalMaterial);
        stats.Add("Knowledge\t" + knowledgeUsed + " / " + totalKnowledge);
        return stats;
    }
}
