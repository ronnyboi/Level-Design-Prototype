using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulbFlicker : MonoBehaviour {
    public AudioClip clip;
    bool canFlicker = true;
    AudioSource audio;

    void Update()
    {
        StartCoroutine(Flicker());

    }

    IEnumerator Flicker()
    {
        if (canFlicker)
        {
            canFlicker = false;
            audio = GetComponent<AudioSource>();
            audio.PlayOneShot(clip);
            GetComponent<Light>().GetComponent<Light>().enabled = true;
            yield return new WaitForSeconds(Random.Range(0.1f, 0.4f));
            GetComponent<Light>().GetComponent<Light>().enabled = false;
            yield return new WaitForSeconds(Random.Range(0.1f, 5));
            canFlicker = true;
        }
    }
}
