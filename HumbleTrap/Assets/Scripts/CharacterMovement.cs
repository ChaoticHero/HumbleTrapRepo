using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour,ICharacterMovement
{
    private CharacterController characterController;

    [SerializeField]
    private bool isPlayer;
    public bool IsPlayer => isPlayer;

    public bool IsDrowned { get; set; }

    public int Health { get;  set;}
    public int Speed { get; set;}


    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        characterController.Move(new Vector3(Horizontal,0,Vertical));
    }
}
