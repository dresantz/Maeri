/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Event : MonoBehaviour
{
    [Tooltip ("o evento Stay permanecerá triggered depois de x segundos")]
    public float triggerStayTime = 0f;
    [Tooltip("objetos com essa tag podem ativar o trigger")]
    public string activatorTag = "Player";
    private float m_timeStayed = 0f;
    private bool m_stayActive = false;

    public UnityEvent inColisor;
    public UnityEvent outColisor;
    public UnityEvent stayColisor;

    [Tooltip("quantas vezes pode ser triggered na entrada")]
    public int triggerCounterEnter = 0;
    [Tooltip("quantas vezes pode ser triggered na saida")]
    public int triggerCounterExit = 0;
    [Tooltip("quantas vezes pode ser triggered na permanencia")]
    public int triggerCounterStay = 0;

    public int m_TriggerCountedEnter = 0;
    public int m_TriggerCountedExit = 0;
    public int m_TriggerCountedStay = 0;

    [Tooltip("Só ativa depois de x entradas")]
    public int triggerAfterEnter = 0;
    [Tooltip("Só ativa depois de x saídas")]
    public int triggerAfterExit = 0;
    [Tooltip("Só ativa depois de x ficadas")]
    public int triggerAfterStay = 0;

    [Tooltip("o trigger terá delay durante esse tempo em segundos")]
    public float triggerDelay = 0f;


    // Sistema de atraso.
    IEnumerator EnterDelay ()
    {
        yield return new WaitForSeconds(triggerDelay);
        inColisor.Invoke();
    }

    IEnumerator ExitDelay()
    {
        yield return new WaitForSeconds(triggerDelay);
        outColisor.Invoke();
    }

    IEnumerator StayDelay()
    {
        yield return new WaitForSeconds(triggerDelay);
        stayColisor.Invoke();
    }


    // Sistema geral.
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag(activatorTag))
        {

            int triggerRange = m_TriggerCountedEnter - triggerAfterEnter;

            if (triggerCounterEnter == 0 || ( triggerRange >= 0 && triggerRange < triggerCounterEnter))
            {
                m_timeStayed = 0f;
                m_stayActive = true;

                if (triggerDelay > 0f)
                {
                    StartCoroutine("EnterDelayed");
                }
                else
                {
                    inColisor.Invoke();
                }
            }
                m_TriggerCountedEnter++;
        }
    }

    private void OntriggerExit2D (Collider2D other)
    {
        if (other.CompareTag(activatorTag))
        {

            int triggerRange = m_TriggerCountedExit - triggerAfterExit;

            if (triggerCounterExit == 0 || (triggerRange >= 0 && triggerRange < triggerCounterExit))
            {
                m_timeStayed = 0f;

                if (triggerDelay > 0f)
                {
                    StartCoroutine("ExitDelayed");
                }
                else
                {
                    outColisor.Invoke();
                }

            }
                m_TriggerCountedExit++;
        }
    }

    private void OntriggerStay2D (Collider2D other)
    {
        if (other.CompareTag(activatorTag))
        {

            int triggerRange = m_TriggerCountedStay - triggerAfterStay;

            m_timeStayed += Time.deltaTime;

            if (m_timeStayed > triggerStayTime && m_stayActive)
            {
                if (triggerCounterStay == 0 || (triggerRange >= 0 && triggerRange < triggerCounterStay))
                {
                    if (triggerDelay > 0f)
                    {
                        StartCoroutine("EnterDelayed");
                    }
                    else
                    {
                        stayColisor.Invoke();
                    }
                    m_stayActive = true;
                }
            }
        }
            m_TriggerCountedStay++;
    }
}
*/
