using UnityEngine;

public class FlashLight : MonoBehaviour
{
    [SerializeField] private Light _flashLight;
    [SerializeField] private KeyCode _keyCode;

    private bool flashlightIsOn = true;

    private void Update()
    {
        SwitchFlashLight();
    }

    private void SwitchFlashLight()
    {
        if (Input.GetKeyDown(_keyCode) && flashlightIsOn == true)
        {
            _flashLight.enabled = false;
            flashlightIsOn = false;
        }
        else if (Input.GetKeyDown(_keyCode) && flashlightIsOn == false)
        {
            _flashLight.enabled |= true;
            flashlightIsOn = true;
        }
        
    }
}
