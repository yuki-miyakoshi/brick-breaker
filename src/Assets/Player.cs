using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRigidBody;

    public float playerSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 force = Vector2.zero;

        if(Input.GetKey(KeyCode.LeftArrow) || Keyboard.current[Key.LeftArrow].wasPressedThisFrame){
            force = new Vector2(playerSpeed * -1,0);
        }

        if(Input.GetKey(KeyCode.RightArrow) || Keyboard.current[Key.RightArrow].wasPressedThisFrame){
            force = new Vector2(playerSpeed,0);
        }

        myRigidBody.MovePosition(myRigidBody.position + force * Time.fixedDeltaTime);
    }
}
