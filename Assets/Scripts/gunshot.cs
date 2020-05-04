using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshot : MonoBehaviour {
    public AudioSource gunfire;
    public Animation Gunshot;
    public GameObject Flash;
    //int ammo = 15;
    void Start() {
        gunfire = GetComponent<AudioSource>();
        Gunshot = GetComponent<Animation>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !Input.GetMouseButton(1) && !Gunshot.IsPlaying("Gunshot") && GlobalAmmo.LoadedAmmo != 0) {
            gunfire.Play();
            Flash.SetActive(true);
            StartCoroutine(MuzzleOff());
            Gunshot.Play("Gunshot");
            GlobalAmmo.LoadedAmmo -= 1;
        } else if (Input.GetKeyDown(KeyCode.Mouse0) && Input.GetMouseButton(1) && !Gunshot.IsPlaying("adsgunshot") && GlobalAmmo.LoadedAmmo != 0) {
            gunfire.Play();
            Flash.SetActive(true);
            StartCoroutine(MuzzleOff());
            Gunshot.Play("adsgunshot");
            GlobalAmmo.LoadedAmmo -= 1;
        }
    }
    IEnumerator MuzzleOff() {
        yield return new WaitForSeconds(.15f);
        Flash.SetActive(false);
    }
}
