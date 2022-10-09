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
    private GameObject image;

    public void TownStats() {
        clearTownStats();
        List<string> stats = new List<string>(TownManager.townManager.getStats()); 
 
        foreach (string stat in stats) {
            TextMeshProUGUI currentStat = Instantiate(statText);
            currentStat.text = stat;
            currentStat.transform.SetParent(image.transform);
            currentStat.transform.localScale = new Vector3(1,1,1);
            currentStat.color = Color.black;
        }
            
    }

    public void clearTownStats() {
        foreach (Transform child in image.transform)
            Destroy(child.gameObject);
            
    }

}
