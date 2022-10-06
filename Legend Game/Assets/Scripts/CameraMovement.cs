using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float speed = 5f;
    public float snapBackSpeed = 3f;
    public float maxXDiviation = 3;
    public float maxYDiviation = 2;

    float vertMovement;
    float horzMovement;

    Transform trans;

    private void Start() {
        trans = transform;
    }

    // Update is called once per frame
    void Update() {
        vertMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        horzMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        if (horzMovement > 0 && trans.position.x < maxXDiviation)
            transform.Translate(horzMovement, 0, 0);
        else if (horzMovement < 0 && trans.position.x > -maxXDiviation)
            transform.Translate(horzMovement, 0, 0);

        if (vertMovement > 0 && trans.position.y < maxYDiviation)
            transform.Translate(0, vertMovement, 0);
        else if (vertMovement < 0 && trans.position.y > -maxYDiviation)
            transform.Translate(0, vertMovement, 0);

        if (horzMovement == 0 && vertMovement == 0)
         trans.position = Vector3.MoveTowards(trans.position, new Vector3(0, 0, -10), snapBackSpeed * Time.deltaTime);
    }
}
