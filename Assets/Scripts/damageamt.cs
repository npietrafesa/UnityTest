using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageamt : MonoBehaviour {
    public int damageAmount = 5;
    public float targetDistance;
    public float allowedRange = 15f;
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            RaycastHit Shot;
            if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out Shot)) {
                targetDistance = Shot.distance;
                if (targetDistance < allowedRange) {
                    Shot.transform.SendMessage("deductPoints", damageAmount, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
