using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{

    List<LegendIcons> legendIcondList;

   //Blacksmith blacksmith;
    // Start is called before the first frame update
    void Start()
    {
        Blacksmith blacksmith = new Blacksmith();
        legendIcondList.Add(blacksmith);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
