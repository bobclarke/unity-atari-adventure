using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Pickup _currentItem;

    internal void Pickup(Pickup pickup)
    {
        if(_currentItem != null){
            _currentItem.gameObject.transform.SetParent(null);
        }

        _currentItem = pickup;
        _currentItem.gameObject.transform.SetParent(transform);
    }

    void Update(){
        if(Input.GetKey("space") && _currentItem != null){
            _currentItem.gameObject.transform.SetParent(null);
            _currentItem = null;

        }
    }
}
