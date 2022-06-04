using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class FootStepSounds : MonoBehaviour
{
    [SerializeField] private AudioClip footStep;
    [SerializeField] private AudioSource audioSource;


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void FootStepSound()
    {
        Debug.Log("Звук шага");
        audioSource.PlayOneShot(footStep);
    }
}
