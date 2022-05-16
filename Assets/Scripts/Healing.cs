using UnityEngine;

public class Healing : MonoBehaviour
{
   [SerializeField] private float health =5f ;


    private void OnTriggerEnter(Collider collision)
    {
        HpBarGUI hpBar = collision.GetComponent<HpBarGUI>();
        if (collision.GetComponent<CharacterController>() && hpBar.HpBar < hpBar.MaxValue)
        {
            hpBar.Healing(health);
            Destroy(gameObject);
        }
    }
}
