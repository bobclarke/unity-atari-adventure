using System;
using UnityEngine;

public class locamotion : MonoBehaviour
{
    [Header("Locomation vars")]
    public float _speed = 5f;

    Vector2 movement;
    public Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //var x = UnityEngine.Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        //var y = UnityEngine.Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        
        //if (Mathf.Abs(x) > 0){
        //if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)){
            //rbody.MovePosition(rbody.position += new Vector2 (x,0));
             
        //}
        //if (Mathf.Abs(y) > 0)
        //{
            //rbody.position += new Vector2 (0,y) ;
        //}
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    } 

    void FixedUpdate(){
        rbody.MovePosition(rbody.position + movement * _speed * Time.fixedDeltaTime);

    }
}
