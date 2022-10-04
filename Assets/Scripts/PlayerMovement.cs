using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviourParent
{
    public static PlayerMovement Instance;
    RaycastHit hit;
    public float rotationSpeed;
    public float speed = 10f;
    public Vector3 offset;
    public float horizontalinput;
    public float verticalinput;
    

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {

    }


    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        verticalinput = Input.GetAxis("Vertical");
        if (horizontalinput != 0 || verticalinput !=0)
        {
            transform.Rotate(Vector3.up * horizontalinput * speed);
            transform.Translate(Vector3.forward * verticalinput * speed *Time.deltaTime);
        }
        camerapos();
       


        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }
    void shoot()
    {
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100f));
        Vector3 direction = mousepos - Camera.main.transform.position;
        if (Physics.Raycast(Camera.main.transform.position, direction, out hit, Mathf.Infinity))
        {
            Debug.DrawLine(Camera.main.transform.position, hit.point, Color.green, 0.5f);
            hit.collider.gameObject.GetComponent<EnemyMovement>().TakeDamage(20);
            //EnemyMovement.instance.TakeDamage(20);
            //Destroy(hit.collider.gameObject);
            //if (hit.collider.gameObject.CompareTag("Enemy"))
            //{
            //    Debug.Log("Called");
            //    hit.collider.GetComponent<EnemyMovement>().TakeDamage(10);
            //}


        }
        else
        {
            Debug.DrawLine(Camera.main.transform.position, hit.point, Color.red, 0.5f);

        }
    }
    void camerapos()
    {
        Camera.main.transform.rotation = transform.rotation;
        Camera.main.transform.position = transform.position + offset;
    }

    

    // Update is called once per frame
    
}
