using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float fltInvokeTime = .5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Player"))
        {
            Invoke("ReloadScene", fltInvokeTime);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}