using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float m_Torque;
    [SerializeField] float m_BaseSpeed;
    [SerializeField] float m_BoostSpeed;

    SurfaceEffector2D m_surfaceEffector2D;

    Rigidbody2D m_Rigidbody;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        m_surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        Rotate();
        RespondToBoost();
    }

    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_surfaceEffector2D.speed = m_BoostSpeed;
        }
        else
        {
            m_surfaceEffector2D.speed = m_BaseSpeed;
        }
    }

    private void Rotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_Rigidbody.AddTorque(m_Torque);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Rigidbody.AddTorque(-m_Torque);
        }
    }
}
