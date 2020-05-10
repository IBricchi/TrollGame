using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Animations : MonoBehaviour
{
    public Animator anim;
    public BobControl Bob;

    InputMaster controls;

    private void Awake()
    {
        controls = new InputMaster();
        controls.Bob.Move.performed += _ => SetMoveProperties(_.ReadValue<Vector2>());
        controls.Bob.Move.canceled += _ => SetMoveProperties(Vector2.zero);
        controls.Bob.CTR.performed += _ => SetRunProperties(true);
        controls.Bob.CTR.canceled += _ => SetRunProperties(false);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        SetJumpProperties(Bob.vel.y, Bob.is_grounded);
    }

    void SetMoveProperties(Vector2 dir){
        anim.SetFloat("Vertical", dir.y);
        anim.SetFloat("Horizontal", dir.x);
    }

    void SetRunProperties(bool r){
        anim.SetBool("Run", r);
    }
    
    void SetJumpProperties(float up, bool grounded){
        anim.SetFloat("Up", up);
        anim.SetBool("Grounded", grounded);
    }
}
