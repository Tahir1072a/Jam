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
        
       
    }
    void OnShoot()
    {
        //Debug.Log("Space basýldý");
        klon = Instantiate(mermi, nokta.position, namlu.rotation);
        Rigidbody2D klonRigidbody = klon.GetComponent<Rigidbody2D>();
        klon.GetComponent<Rigidbody2D>().AddForce(-namlu.right* 100f);
      

    }
}
