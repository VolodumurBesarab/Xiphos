using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class FirstPersonController : MonoBehaviour
{
    private Animator animator;      //....Animator
    private Rigidbody rigidbody;
   // public Transform groundCheckerTransform;
  //  public LayerMask groundLayer;
    public float movementspeed = 5.0f;
    public float mouseSensitivity = 2.0f;
    public float verticalAngleLimit = 60.0f;
    public float jumpSpeed = 5f;

    float verticalRotation = 0;

    GameObject _inventory;
    GameObject _tooltip;
    GameObject _character;
    GameObject _dropBox;
    public bool showInventory = false;
    float verticalVelocity = 0;

    GameObject inventory;
    GameObject craftSystem;
    GameObject characterSystem;

    Camera firstPersonCamera;

    CharacterController characterController;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();  //....get animator
        rigidbody = GetComponent<Rigidbody>();
       
        firstPersonCamera = Camera.main.GetComponent<Camera>();
        characterController = GetComponent<CharacterController>();

        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            PlayerInventory playerInv = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();
            if (playerInv.inventory != null)
                inventory = playerInv.inventory;
            if (playerInv.craftSystem != null)
                craftSystem = playerInv.craftSystem;
            if (playerInv.characterSystem != null)
                characterSystem = playerInv.characterSystem;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (!lockMovement())
        {
            /*
            //Rotation
            float rotationLeftRight = Input.GetAxis("Mouse X") * mouseSensitivity;
            transform.Rotate(0, rotationLeftRight, 0);

            verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
            verticalRotation = Mathf.Clamp(verticalRotation, -verticalAngleLimit, verticalAngleLimit);
            firstPersonCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
            */

            //Movement
            float forwardSpeed = Input.GetAxis("Vertical") * movementspeed;
            float sideSpeed = Input.GetAxis("Horizontal") * movementspeed;

            verticalVelocity += Physics.gravity.y * Time.deltaTime;

            if (Input.GetButtonDown("Jump") && characterController.isGrounded)
            {
                 verticalVelocity = jumpSpeed;
                //Jump();
            }

            //Vector3 speed = new Vector3(sideSpeed, verticalVelocity, forwardSpeed);
            Vector3 speed = new Vector3(sideSpeed, 0, forwardSpeed);
            animator.SetFloat("speed", Vector3.ClampMagnitude(speed, 1).magnitude); //....animazia na big i idle

            //speed = transform.rotation * speed;

            //My rotation
            if (speed.magnitude > Mathf.Abs(0.05f))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(speed), Time.deltaTime * 10);

            characterController.Move(speed * Time.deltaTime);
        }
        /*
        void Jump()
        {
            RaycastHit hit;
            if(Physics.Raycast(groundCheckerTransform.position, Vector3.down, 10f, groundLayer))
            {
                rigidbody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            }
            else 
            {
                Debug.Log("Did not find ground layer");
            }
        }
        */

    }


    bool lockMovement()
    {
        if (inventory != null && inventory.activeSelf)
            return true;
        else if (characterSystem != null && characterSystem.activeSelf)
            return true;
        else if (craftSystem != null && craftSystem.activeSelf)
            return true;
        else
            return false;
    }
}
