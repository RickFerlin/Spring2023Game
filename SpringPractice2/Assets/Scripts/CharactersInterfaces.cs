using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
public class CharactersInterfaces : MonoBehaviour, IMove, ITrigger
{
    public UnityEvent triggerEnterEvent;
    public void Move()
    {
        Debug.Log("Oh ho I'm a character movin'");
    }

    public void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
