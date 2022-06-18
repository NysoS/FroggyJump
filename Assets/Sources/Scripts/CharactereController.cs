using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using FroggyJump.Input;


//////////////////////////
//   Kristofer Ledoux   //
// Copyright &copy 2022 //
//////////////////////////

namespace FroggyJump
{
    [RequireComponent(typeof(Rigidbody))]
    public class CharactereController : Charactere
    {

        private InputCharacterController inputCharacterController;

        private Rigidbody rb;

        private Vector3 moveDirection = Vector3.zero;

        [SerializeField]
        private float force;
        
        [SerializeField]
        [Range(0.1f,1f)]
        private float upForce = 0.2f;

        void Awake() {

            rb = GetComponent<Rigidbody>();

            this.inputCharacterController = new InputCharacterController();
            this.inputCharacterController.PlayerController.MoveActions.performed += Move;
        }

        // Start is called before the first frame update
        void Start()
        {
            Actor.OnDetection += OnDetected;
        }

        // Update is called once per frame
        void Update()
        {
            MoveSystem();
        }

        public override void Move(InputAction.CallbackContext ctx){

            moveDirection = (Vector3.right * ctx.ReadValue<float>());

        }

        private void MoveSystem()
        {
            if (moveDirection != Vector3.zero)
            {
                rb.AddForce(moveDirection * force * Time.deltaTime, ForceMode.Impulse);
                rb.AddForceAtPosition(Vector3.up * upForce, transform.position);
            }
        }
        

        public override void Eat()
        {
            Debug.LogWarning("Je mange " + gameObject.name);
        }

        public override void OnDetected(GameObject source, Actor target, string callback)
        {
            if(target.gameObject == this.gameObject)
            {
                switch (callback)
                {
                    case EATMETHOD:
                        Eat();
                        break;
                    case DIEMETHOD:
                        Die();
                        break;
                    default:
                        break;
                }
            }
        }

        void OnEnable() {
            this.inputCharacterController.PlayerController.Enable();
        }

        void OnDisable() {
            this.inputCharacterController.PlayerController.Disable();
        }

    }
}
