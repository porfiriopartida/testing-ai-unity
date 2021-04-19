namespace DefaultNamespace
{
    public class IdleState : MyState
    {
        public bool isPlayerNear;
        
        public IdleState(MyStateMachine myStateMachine)
        {
            this.stateMachine = myStateMachine;
        }

        public override MyState Update()
        {
            if (isPlayerNear)
            {
                stateMachine.CharacterController.Move();
                return stateMachine.ChaseState;
            }
            else
            {
                stateMachine.CharacterController.Dance();
                return this;
            }
        }
    }
}