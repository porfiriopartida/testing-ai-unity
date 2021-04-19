namespace States
{
    public class ChaseState : MyState
    {
        public bool isPlayerClose;
        public ChaseState(MyStateMachine myStateMachine)
        {
            this.stateMachine = myStateMachine;
        }

        public override MyState Update()
        {
            if (isPlayerClose)
            {
                return stateMachine.AttackState;
            }

            stateMachine.CharacterController.Move();
            return this;
        }
    }
}