using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//////////////////////////
//   Kristofer Ledoux   //
// Copyright &copy 2022 //
//////////////////////////

namespace FroggyJump
{
    public abstract class Charactere : Actor
    {
        public const string EATMETHOD = "Eat";
        public const string DIEMETHOD = "Die";
        public const string JUMPMETHOD = "Jump";

        protected int maxLife = 100;
        protected int life = 0;

        public virtual void Move(){}
        public virtual void Move(InputAction.CallbackContext ctx) {}

        public virtual void Jump(){}
        public virtual void Jump(InputAction.CallbackContext ctx) {}

        public virtual void Eat(){}
        public virtual void Eat(InputAction.CallbackContext ctx) {}

        public virtual void Die(){}
    }
}
