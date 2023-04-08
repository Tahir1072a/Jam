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
        Debug.Log("Space basýldý");
        klon = Instantiate(mermi, nokta.position, namlu.rotation);
        //klon.GetComponent<Rigidbody2D>().AddForce(klon.forward * 1000f);
       
        Rigidbody2D klonRigidbody = klon.GetComponent<Rigidbody2D>();
        klon.GetComponent<Rigidbody2D>().AddForce(-namlu.right * bulletSpeed);
        //klonRigidbody.AddForce(klon.transform.right * 10f);

    }
}
