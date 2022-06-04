using UnityEngine;

[RequireComponent(typeof(Animator))]
public class IkLook : MonoBehaviour
{

    private Animator _animator;

    [SerializeField]
    private Transform _lookAt;

    [SerializeField]
    private bool _isLooking;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        if(_isLooking)
        {
            _animator.SetLookAtWeight(1);
            _animator.SetLookAtPosition(_lookAt.position);
        }
        else
        {
            _animator.SetLookAtWeight(0);
        }
    }

    private void OnTriggerStay(Collider collider)
    {
        if(collider.CompareTag("NPC"))
        {
            _isLooking = true;
        } 
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("NPC"))
        {
            _isLooking = false;
        }
    }
}
