using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTest : MonoBehaviour
{
   [SerializeField] private float damage = 1;


   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         HpBarGUI hpBar = GetComponent<HpBarGUI>();
         hpBar.TakeDamage(damage);
      }
   }
}
