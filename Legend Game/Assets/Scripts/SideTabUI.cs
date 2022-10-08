using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    Image sidePanel;

    bool town = false;
    bool legend = false;

    public void pressTownButton() {
        if (town) {
            townClosedButton.SetActive(true);
            legendClosedButton.SetActive(true);
            townOpenButton.SetActive(false);
            legendOpenButton.SetActive(false);
            town = false;
            sidePanel.enabled = false;
        }
        else {
            town = true;
            legend = false;
        }
    }

    public void pressLegendButton() {
        if (legend) {
            townClosedButton.SetActive(true);
            legendClosedButton.SetActive(true);
            legend = false;
            sidePanel.enabled = false;
            townOpenButton.SetActive(false);
            legendOpenButton.SetActive(false);
        }
        else {
            legend = true;
            town = false;
        }
    }


}
