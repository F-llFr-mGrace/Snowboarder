using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float fltInvokeTime = .5f;
    [SerializeField] ParticleSystem finishEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Player"))
        {
            finishEffect.Play();
            Invoke("ReloadScene", fltInvokeTime);
            GetComponent<AudioSource>().Play();
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}