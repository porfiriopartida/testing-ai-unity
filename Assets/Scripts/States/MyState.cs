using Strategy;

namespace DefaultNamespace
{
    public abstract class MyState
    {
        protected MyStateMachine stateMachine;

        public abstract MyState Update();
    }
}