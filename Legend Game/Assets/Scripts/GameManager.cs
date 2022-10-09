using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    List<LegendIcons> legendIcondList;

    private void Awake() {
        if (gameManager != null) {
            Destroy(gameObject);
        }
        else {
            gameManager = this;
        }
    }
    

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
