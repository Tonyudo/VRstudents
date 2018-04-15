using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOORS : MonoBehaviour {

    Animator animator;
    bool DoorOpen;

    private void Start()
    {
        DoorOpen = false;
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider col)
    {
      if(col.gameObject.tag == "Player")
        {
            DoorOpen = true;
            Doors("Open");
        }  
    }

    private void OnTriggerExit(Collider col)
    {
        if (DoorOpen)
        {
            DoorOpen = false;
            Doors("Close");
        }
    }
    void Doors(string direction)
    {
        animator.SetTrigger(direction);
    }
}
