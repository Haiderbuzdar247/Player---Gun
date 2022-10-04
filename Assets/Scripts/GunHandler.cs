using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunHandler : MonoBehaviour
{
    public List<GameObject> Guns;
    GameObject prefgun;
    int gunind;
    public static GunHandler instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

        int gunselected = PlayerPrefs.GetInt("SelectedGun");
        gunind = gunselected;
        GameObject prefgun = Guns[gunselected];
        GameObject clonegun = Instantiate(prefgun, transform.position, Quaternion.Euler(0, -90, 0), transform);
        clonegun.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetAxis("Mouse ScrollWheel") != 0)
        //{
        //    if (Input.GetAxis("Mouse ScrollWheel") > 0)
        //    {
        //        Destroy(GameObject.Find(prefgun.name));
        //        gunind = (gunind + 1) % Guns.Count;
        //        Instantiate(Guns[gunind], transform.position, Quaternion.Euler(0, -90, 0), transform);
        //        Guns[gunind].SetActive(true);
        //    }
        //    if (Input.GetAxis("Mouse ScrollWheel") < 0)
        //    {
        //        Destroy(GameObject.Find(prefgun.name));

        //        gunind--;
        //        if (gunind < 0)
        //        {
        //            gunind += Guns.Count;
        //        }
        //        Instantiate(Guns[gunind], transform.position, Quaternion.Euler(0, -90, 0), transform);
        //        Guns[gunind].SetActive(true);
        //    }
        //}
    }
}
