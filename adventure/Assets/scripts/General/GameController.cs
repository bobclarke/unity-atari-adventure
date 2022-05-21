using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform _player;


    // private void OnTriggerExit2D(Collision collision)
    // {
    //     if (collision.tag == "Player"){
    //         print("Outside");
    //     }
        
    // }

    private void OnTriggerExit2D(Collider2D collision){
        if (collision.tag == "Player"){
            print("Player has left screen");
        }
    }
}
