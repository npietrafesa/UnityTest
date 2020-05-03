using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshot : MonoBehaviour {
    public AudioSource gunfire;
    public Animation Gunshot;
    //int ammo = 15;
    void Start() {
        gunfire = GetComponent<AudioSource>();
        Gunshot = GetComponent<Animation>();
        
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !Input.GetMouseButton(1) && !Gunshot.IsPlaying("Gunshot") && GlobalAmmo.LoadedAmmo != 0) {
            gunfire.Play();
            Gunshot.Play("Gunshot");
            //ammo--;
            //GlobalAmmo.CurrentAmmo = ammo;
            GlobalAmmo.LoadedAmmo -= 1;
        } else if (Input.GetKeyDown(KeyCode.Mouse0) && Input.GetMouseButton(1) && !Gunshot.IsPlaying("adsgunshot") && GlobalAmmo.LoadedAmmo != 0) {
            gunfire.Play();
            Gunshot.Play("adsgunshot");
            //ammo--;
            //GlobalAmmo.CurrentAmmo = ammo;
            GlobalAmmo.LoadedAmmo -= 1;
        }
      /*  if (Input.GetKeyDown(KeyCode.R) && !Gunshot.IsPlaying("Gunshot") && !Gunshot.IsPlaying("adsgunshot")  && GlobalAmmo.LoadedAmmo < 15) {
            Gunshot.Play("m9reload");
            //ammo = 15;
            //GlobalAmmo.CurrentAmmo = ammo;
            GlobalAmmo.LoadedAmmo = 15;
        } */
    }
}