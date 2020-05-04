using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M9pickup : MonoBehaviour
{
    public float TheDistance = PlayerCasting.DistanceFromTarget;
    public GameObject TextDisplay;

    public GameObject FakeGun;
    public GameObject RealGun;
    public GameObject GunName;
    public GameObject GunCaliber;
   // public AudioSource PickUpAudio;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                StartCoroutine(TakeNineMil());
            }
        }
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            TextDisplay.GetComponent<Text> ().text = "[E] Take M9";
        }
    }

    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text> ().text = "";
    }

    IEnumerator TakeNineMil()
    {
       // PickUpAudio.Play();
        transform.position = new Vector3(0, -1000, 0);
        FakeGun.SetActive(false);
        RealGun.SetActive(true);
        GunName.SetActive(true);
        GunCaliber.SetActive(true);
        GunName.GetComponent<Text>().text = "M9";
        GunCaliber.GetComponent<Text>().text = "9x19mm";
        TextDisplay.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(0.1f);
    }
}
