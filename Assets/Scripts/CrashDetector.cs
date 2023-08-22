using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float m_DelaySeconds;
    [SerializeField] ParticleSystem m_CrashEffect;
    [SerializeField] AudioClip m_CrashSFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            m_CrashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(m_CrashSFX);
            Invoke("ReloadScene", m_DelaySeconds);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
