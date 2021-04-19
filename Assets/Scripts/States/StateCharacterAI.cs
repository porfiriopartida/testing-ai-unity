using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class StateCharacterAI : MonoBehaviour
    {
        private MyStateMachine stateMachine;
        private MyState currentState;
        public MyCharacterController CharacterController;

        private void Start()
        {
            stateMachine = new MyStateMachine();
            stateMachine.CharacterController = CharacterController;
            currentState = stateMachine.IdleState;
        }

        public void Update()
        {
            currentState = currentState.Update();
        }
    }
}