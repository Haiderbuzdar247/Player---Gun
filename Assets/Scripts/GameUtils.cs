using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUtils : MonoBehaviourParent
{
    public static GameUtils Instance;
    public string GunPrefId;
    public string PlayerPrefId;
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    
}
