using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletMovement : MonoBehaviour
{
    public Transform player, namlu,mermi,nokta;
    Transform klon;
    [SerializeField] float bulletSpeed = 100f;
    
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
//<<<<<<< HEAD
        klon.GetComponent<Rigidbody2D>().AddForce(-namlu.right* 100f);
      
//=======
        klon.GetComponent<Rigidbody2D>().AddForce(-namlu.right * bulletSpeed);
        //klonRigidbody.AddForce(klon.transform.right * 10f);
//>>>>>>> 8a673660953adffeb3d8aec43de23439a4f05819

    }
}
