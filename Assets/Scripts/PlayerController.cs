using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviourParent
{
    public List<GameObject> Charater;
    public GameObject enemypref;
    public static PlayerController Instance;
    public TMP_Text Label;
    public Transform spawnpoint;
    GameObject prefcharac;
    Vector3 spawnpos;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 2, 3);
        int characterselection = PlayerPrefs.GetInt("SelectedCharacter");
        GameObject prefcharac = Charater[characterselection];
        GameObject clonecharac = Instantiate(prefcharac, spawnpoint.position, Quaternion.identity);
        Label.text = "You Started as " + prefcharac.name ;
    }
    void SpawnEnemy()
    {
            spawnpos = new Vector3(Random.Range(160, 216), 29, Random.Range(-24, 24));
             Instantiate(enemypref, spawnpos, Quaternion.identity);   
    }
    private void Update()
    {
        
    }





}
