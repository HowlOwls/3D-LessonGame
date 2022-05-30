using UnityEngine;

[RequireComponent(typeof(Animator))]
public class IkWallHold : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private Transform _player;

    [SerializeField]
    private Transform _leftHandPos;


    [SerializeField]
    private Transform _rightHandPos;

    [SerializeField]
    private bool _IkActive;

    [SerializeField]
    private LayerMask _rayLayer;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        
        if(Physics.Raycast(_player.position, Vector3.forward, out var hit, 0.3f , _rayLayer))
        {
            WeightHands(1);
            _animator.SetIKPosition(AvatarIKGoal.LeftHand, _leftHandPos.position);
            _animator.SetIKRotation(AvatarIKGoal.LeftHand, _leftHandPos.rotation);
            _animator.SetIKPosition(AvatarIKGoal.RightHand, _rightHandPos.position);
            _animator.SetIKRotation(AvatarIKGoal.RightHand, _rightHandPos.rotation);
        }
        else 
        {
            WeightHands(0);
        }

    }

    private void WeightHands(float value)
    {
        _animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, value);
        _animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, value);
        _animator.SetIKPositionWeight(AvatarIKGoal.RightHand, value);
        _animator.SetIKRotationWeight(AvatarIKGoal.RightHand, value);
    }
}
