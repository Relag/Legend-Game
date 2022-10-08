using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SideTabUI {
    [SerializeField]
    private Button townOpenButton;
    [SerializeField]
    private Button legendOpenButton;
    [SerializeField]
    private Button townClosedButton;
    [SerializeField]
    private Button legendClosedButton;

    [SerializeField]
    GameObject sidePanel;

    bool town = false;
    bool legend = false;


}
