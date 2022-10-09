using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TownManager : MonoBehaviour
{
    public static TownManager townManager;
    public List<LegendIcons> icons = new List<LegendIcons>();

    [SerializeField]
    StatCanvasUI statCanvasUI;

    int totalFood;
    int totalMaterial;
    int totalKnowledge;
    int totalReligion;
    int totalMilitary;
    int totalCommerce;
    int foodUsed;
    int knowledgeUsed;
    int materialUsed;

    private void Awake() {
        if (townManager != null) {
            Destroy(gameObject);
        }
        else {
            townManager = this;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        totalFood = 15;
        foodUsed = 0;
        totalMaterial = 15;
        materialUsed = 0;
        totalKnowledge = 15;
        knowledgeUsed = 0;
        totalCommerce = 0;
        totalReligion = 0;
        totalMilitary = 0;

        icons.Add(new Blacksmith());
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
        stats.Add("Religion\t" + totalReligion);
        stats.Add("Food\t\t" + foodUsed + "/" + totalFood);
        stats.Add("Materials\t" + materialUsed + " / " + totalMaterial);
        stats.Add("Knowledge\t" + knowledgeUsed + " / " + totalKnowledge);
        return stats;
    }

    public void purchaseIcon(LegendIcons icon) {
        if (foodAvailable() > icon.foodRequired && materialAvailable() > icon.materialRequired && knowledgeAvailable() > icon.knowledgeRequired) {
            foodUsed += icon.foodRequired;
            materialUsed += icon.materialRequired;
            knowledgeUsed += icon.knowledgeRequired;

            totalFood += icon.foodGiven;
            totalMaterial += icon.materialGiven;
            totalKnowledge += icon.knowledgeGiven;

            totalReligion += icon.religion;
            totalMilitary += icon.military;
            totalCommerce += icon.commerce;

            icons.Remove(icon);
            statCanvasUI.TownStats();
        }     
    }
}
