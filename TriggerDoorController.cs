using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Activate the GameObject before playing the animation
            gameObject.SetActive(true);

            // Play the "DoorOpen" animation
            myDoor.Play("DoorOpen", 0, 0.0f);
        }
        else if (closeTrigger)
        {
            // Activate the GameObject before playing the animation
            gameObject.SetActive(true);

            // Play the "DoorClose" animation
            myDoor.Play("DoorClose", 0, 0.0f);
        }
    }
}
