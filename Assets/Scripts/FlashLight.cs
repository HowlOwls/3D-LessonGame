using UnityEngine;

public class FlashLight : MonoBehaviour
{
    [SerializeField] private Light _flashLight;
    [SerializeField] private KeyCode _keyCode;

    private void Update()
    {
        SwitchFlashLight();
    }

    private void SwitchFlashLight()
    {
        if (Input.GetKeyDown(_keyCode))
            _flashLight.enabled = !_flashLight.enabled;
    }
}
