using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CinemachineBrain brain;
    public CharacterController characterController;
    public float speed = 6f;

    private void Start()
    {
        brain = CinemachineCore.Instance.GetActiveBrain(0);

    }
    void Update()
    {

      
        Move();
    }
    private void Move()
    {

        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        Debug.Log(horizontalMove);
        Vector3 move = transform.forward * verticalMove + transform.right * horizontalMove;
        characterController.Move(speed * Time.deltaTime * move);
        

    }
    
}
