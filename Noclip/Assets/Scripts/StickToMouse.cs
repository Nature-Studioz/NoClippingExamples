using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Takes mouse pos And coverts that from screen to world space.
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
