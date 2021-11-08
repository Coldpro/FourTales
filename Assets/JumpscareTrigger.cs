using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareTrigger : MonoBehaviour {

    public AudioSource Scream;
    public GameObject ThePlayer;
    public GameObject JumpCam;
    //public GameObject FlashIng;


    void OnTriggerEnter() {
        Scream.Play();
        JumpCam.SetActive(true);
        ThePlayer.SetActive(false);
        //FlashIng.SetActive(true);

        StartCoroutine(EndJump(2f));
    }
    IEnumerator EndJump(float wait) {
        yield return new WaitForSeconds (wait);
        ThePlayer.SetActive(true);
        JumpCam.SetActive(false);
        //FlashIng.SetActive(false);

    }
}
