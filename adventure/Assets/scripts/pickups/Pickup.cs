using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collider){

        Debug.Log("Message from " + this + ": I have been triggered by " + collider.gameObject.tag );

        if(collider.gameObject.tag != "Player"){
            return;
        } else {    
             var playerInventory = collider.gameObject.GetComponent<Inventory>();
            playerInventory.Pickup(this);
        }
    }
}
