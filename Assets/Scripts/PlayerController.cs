using UnityEngine;
[RequireComponent(typeof(CharacterController),typeof(Animator))]
public class PlayerController : MonoBehaviour
{
   [Header ("Links")]
   [SerializeField] private CharacterController controller;
   [SerializeField] private Animator animator;

   [Header ("Player Parameters")]
   [SerializeField] private float speed;
   [SerializeField] private float gravity = -9.81f;

    private int hzInputAnimationParameterId;
    private int vInputAnimationParameterId;

    private Vector3 velocity;

   private void Awake()
   {
      controller = GetComponent<CharacterController>();
      animator = GetComponent<Animator>();
      hzInputAnimationParameterId = Animator.StringToHash("MoveX");
      vInputAnimationParameterId = Animator.StringToHash("MoveZ");
    }

   private void Update()
   {
      Movement();
   }
   private void Movement()
   {
      var hzMove = Input.GetAxis("Horizontal");
      var vMove = Input.GetAxis("Vertical");
      var move = transform.right * hzMove + transform.forward * vMove;
      controller.Move(move.normalized * speed * Time.deltaTime);
      velocity.y = gravity;
      controller.Move(velocity);

      animator.SetFloat(hzInputAnimationParameterId, hzMove );
      animator.SetFloat(vInputAnimationParameterId, vMove );
    }
}
