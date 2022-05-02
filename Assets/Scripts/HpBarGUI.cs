using UnityEngine;
using UnityEngine.UI;

public class HpBarGUI : MonoBehaviour
{
    [SerializeField] private float hpBar;
    [SerializeField] private float maxValue;
    [SerializeField] private float minValue;


    public float HpBar => hpBar;
    public float MaxValue => maxValue;

    private void Start()
    {
        hpBar = maxValue;
    }

    private void OnGUI()
    {
        var hpNormolized = hpBar / maxValue;
        GUI.HorizontalSlider(new Rect(100, 100, 200, 50), hpNormolized, minValue, 1);
    }

    public void TakeDamage(float damage)
    {
        if (hpBar > 0)
        {
            hpBar -= damage;
        }
    }

    public void Healing(float health)
    {
        if (hpBar < maxValue)
        {
            hpBar += health;
        }
    }
}
