using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class trigger : MonoBehaviour
{
    [SerializeField] bool destroyOnTriggerEnter;

    [SerializeField] UnityEvent onTriggerEnter;

    [SerializeField] UnityEvent onTriggerExit;
    private void OnTriggerEnter(Collider other)
    {
        onTriggerEnter.Invoke();
        if (destroyOnTriggerEnter)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        onTriggerExit.Invoke();
    }

}
