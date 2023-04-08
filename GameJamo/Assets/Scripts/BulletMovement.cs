using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletMovement : MonoBehaviour
{
    public Transform player, namlu,mermi,nokta;
    Transform klon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           klon= Instantiate(mermi, nokta.position, namlu.rotation);
            klon.GetComponent<Rigidbody2D>().AddForce(klon.forward*100f);
        }
    }
}
