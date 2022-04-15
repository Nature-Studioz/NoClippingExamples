using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class NoClipperTool : MonoBehaviour
{
    //Our Physics Body
    private Rigidbody2D PhysicsBody;

    //The Body's Speed
    [SerializeField] private float Speed;

    //Speed to increase width.
    [SerializeField] private float ScaleSpeed;

 
    // Start is called before the first frame update
    void Start()
    {
        //Makes Our Body equal to the rigidbody on our character
        PhysicsBody = GetComponent<Rigidbody2D>();

        //Makes the gravity equal to 0 so that It cannot fall down.
        PhysicsBody.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // FixedUpdate is called a fixed amount of frames.
    private void FixedUpdate()
    {
        //Makes the x velocity equal to our speed variable, and the y velocity stays the same.
        PhysicsBody.velocity = new Vector2(Speed, PhysicsBody.velocity.y);

        //Increases the width of box.
        transform.localScale = new Vector2(transform.localScale.x + ScaleSpeed, transform.localScale.y + 0.1f);
  
    }

    
    
}
