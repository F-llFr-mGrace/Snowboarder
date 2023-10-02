using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float fltInvokeTime = .5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    bool hasCrashed = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Terrain") && !hasCrashed)
        {
            hasCrashed = true;
            crashEffect.Play();
            Invoke("ReloadScene", fltInvokeTime);
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            FindObjectOfType<PlayerController>().DisableControls();
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
