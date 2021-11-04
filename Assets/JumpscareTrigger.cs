using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class B2umpTrigger : MonoBehaviour
{
    public AudioSource JumpscareOne;


    void OnTriggerEnter()
    {
        GetComponent<AudioSource>().Play();

    }

    IEnumerator PlaylumpMusic()
    {
        yield return new WaitForSeconds(0.4f);
        JumpscareOne.Play();
    }

}