using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float m_DelaySeconds;
    [SerializeField] ParticleSystem m_FinishEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            m_FinishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", m_DelaySeconds);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
