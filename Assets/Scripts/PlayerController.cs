using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] private CharacterController controller;
   
   
   [SerializeField] private float speed = 2f;
   [SerializeField] private float gravity = -9.81f;
   
   private Vector3 velocity;

   private void Start()
   {
      controller = GetComponent<CharacterController>();
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
   }
}
