using UnityEngine;


[ExecuteInEditMode]
public class DayTime : MonoBehaviour
{
    [SerializeField] private Gradient directinalLightGradient;
    [SerializeField] private Gradient ambientLightGradient;

    [SerializeField, Range(0, 3600)] float timeDayInSeconds = 60;
    [SerializeField, Range(0f, 1f)] float timeProgress;

    [SerializeField] private Light directinalLight;

    private Vector3 defaultAngles;

    private void Start()
    {
        defaultAngles = directinalLight.transform.localEulerAngles;
    }

    private void Update()
    {
        DayTimeChange();
    }


    private void DayTimeChange()
    {
        if(Application.isPlaying)
        {
            timeProgress += Time.deltaTime / timeDayInSeconds;
        }
        if(timeProgress > 1f)
        {
            timeProgress = 0f;
        }

        directinalLight.color = directinalLightGradient.Evaluate(timeProgress);
        RenderSettings.ambientLight = ambientLightGradient.Evaluate(timeProgress);
        directinalLight.transform.localEulerAngles = new Vector3(360f * timeProgress - 90, defaultAngles.x, defaultAngles.z);
    }
}
