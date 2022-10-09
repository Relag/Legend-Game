using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class StatCanvasUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI statText;

    [SerializeField]
    private Button button;

    [SerializeField]
    private GameObject image;

    public void TownStats() {
        clearSidebar();
        List<string> stats = new List<string>(TownManager.townManager.getStats()); 
 
        foreach (string stat in stats) {
            TextMeshProUGUI currentStat = Instantiate(statText);
            currentStat.text = stat;
            currentStat.transform.SetParent(image.transform);
            currentStat.transform.localScale = new Vector3(1,1,1);
            currentStat.color = Color.black;
        }   
    }

    public void clearSidebar() {
        foreach (Transform child in image.transform)
            Destroy(child.gameObject);
            
    }

    public void LegendIconList() {
        clearSidebar();
        foreach (LegendIcons icon in TownManager.townManager.icons) {
            if (icon.shouldBeShown()) {
                Button currentButton = Instantiate(button);
                currentButton.transform.parent = image.transform;
                TextMeshProUGUI currentText = button.GetComponentInChildren<TextMeshProUGUI>();
                currentText.text = icon.name + "\n Food " + icon.foodRequired + " | Mat. " + icon.materialRequired + " | Kno. " + icon.knowledgeRequired;
            }
        }
    }
}
