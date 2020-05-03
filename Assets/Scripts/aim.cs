using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aim : MonoBehaviour {
    public Vector3 aimDownSights;
    public Vector3 hipFire;
    public float aimspeed;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButton(1)) {
           // Console.WriteLine("A");
            transform.localPosition = Vector3.Slerp(transform.localPosition, aimDownSights, aimspeed * Time.deltaTime);
        } else {
          //  Console.WriteLine("B");
            transform.localPosition = Vector3.Slerp(transform.localPosition, hipFire, aimspeed * Time.deltaTime);
        }
    }
}
