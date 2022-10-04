using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSpecs : MonoBehaviourParent
{
    public int damage;
    public static GunSpecs instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
