namespace States
{
    public class MyStateMachine
    {
        public MyStateMachine()
        {
            ChaseState = new IdleState(this);
            IdleState = new ChaseState(this);
            AttackState = new AttackState(this);
        }

        public MyState ChaseState { get; }
        public MyState IdleState { get;  }
        public MyState AttackState { get; }
        public MyCharacterController CharacterController { get; set; }
    }
}