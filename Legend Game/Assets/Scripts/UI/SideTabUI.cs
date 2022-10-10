using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SideTabUI : MonoBehaviour {
    [SerializeField]
    private GameObject townOpenButton;
    [SerializeField]
    private GameObject legendOpenButton;
    [SerializeField]
    private GameObject townClosedButton;
    [SerializeField]
    private GameObject legendClosedButton;
    [SerializeField]
    StatCanvasUI statCanvasUI;

    [SerializeField]
    TextMeshProUGUI tabText;

    [SerializeField]
    Image infoText;

    [SerializeField]
    Image sidePanel;

    bool town = false;
    bool legend = false;

    public void pressTownButton() {
        if (town) {
            statCanvasUI.clearSidebar();
            townClosedButton.SetActive(true);
            legendClosedButton.SetActive(true);
            townOpenButton.SetActive(false);
            legendOpenButton.SetActive(false);
            town = false;
            sidePanel.enabled = false;
            tabText.enabled = false;
            infoText.enabled = false;
            
        }
        else {
            town = true;
            legend = false;
            tabText.text = "Town Stats";
            statCanvasUI.TownStats();
        }
    }

    public void pressLegendButton() {
        if (legend) {
            statCanvasUI.clearSidebar();
            townClosedButton.SetActive(true);
            legendClosedButton.SetActive(true);
            legend = false;
            sidePanel.enabled = false;
            townOpenButton.SetActive(false);
            legendOpenButton.SetActive(false);
            tabText.enabled = false;
            infoText.enabled = false;
            
        }
        else {
            legend = true;
            town = false;
            tabText.text = "Legend";
            statCanvasUI.clearSidebar();
        }
    }
}
