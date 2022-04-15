using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AddMomentum : MonoBehaviour
{
    //Our Physics Body
    private Rigidbody2D PhysicsBody;

    //The Body's Speed
    [SerializeField] private float Speed;

    //The speed the x velocity increaces per fixed frame
    [SerializeField] private float gainSpeedAmount = 0.1f;
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

        //Increase the speed by the speedAmount each fixed frame.
        Speed += gainSpeedAmount;
    }

    //Checks if we collided with another object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Checks if speed is less than 0.
        if(Speed < 0)
        {
            //Changes speed and speedAmount to the postive version of itself
            Speed = Mathf.Abs(Speed);
            gainSpeedAmount = Mathf.Abs(gainSpeedAmount);
        }

        //Checks if Speed is greater than 0
        else if(Speed > 0)
        {
            //Changes speed and speedAmount to the negative version of itself.
            Speed = -Speed;
            gainSpeedAmount = -gainSpeedAmount;
        }
    }
}
