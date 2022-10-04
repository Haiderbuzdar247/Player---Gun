using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;

public class EnemyMovement : MonoBehaviour
{
    public NavMeshAgent enemy;
    public static EnemyMovement instance;
    Vector3 pos;
    [SerializeField] private TMP_Text healthText;
    [SerializeField] private int _power ;
    //public int Power
    //{
    //    get
    //    {
    //        return _power;
    //    }
    //    set
    //    {
    //        _power = value;
    //        healthText.text = "Health: " + _power.ToString();
    //    }


    //}    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        _power = 100;
        healthText.text = _power.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        pos = PlayerMovement.Instance.transform.position;
        enemy.SetDestination(pos);
    }
    public void TakeDamage(int damage)
    {
        _power = _power - damage;
        healthText.text = _power.ToString();
        if (_power <= 0)
        {
            Destroy(this.gameObject);
        }

    }
}
