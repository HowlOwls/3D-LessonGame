using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Healing : MonoBehaviour
{
   [SerializeField] private float health =5f ;


    private void OnTriggerEnter(Collider collision)
    {
        HpBarGUI hpBar = collision.GetComponent<HpBarGUI>();
        if (collision.tag == "Player" && hpBar.HpBar < hpBar.MaxValue)
        {
            hpBar.Healing(health);
            Destroy(gameObject);
        }
    }
}
