using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private CharacterController characterController;
    private float speed = 0.25f;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        characterController.Move(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed);
    }
}
