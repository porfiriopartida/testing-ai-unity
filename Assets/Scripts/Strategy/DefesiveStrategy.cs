namespace Strategy
{
    public class DefensiveStrategy : EnemyStrategy
    {
        //------------- AI core ----------------
        //Triggers 
        //Updated with colliders/or methods that check for distance/path
        public bool isPlayerNearTrigger;
        //States
        private bool _statePassive;
        private bool _stateDefensive;
        //--------------------------------------

        public override void DoYourThing()
        {
            StateUpdate();

            TriggerUpdate();
        }
        void TriggerUpdate()
        {
            if (_stateDefensive)
            {
                CharacterController.RunAway();
            }
            else if (_statePassive)
            {
                CharacterController.Dance();
            }
        }
        private void StateUpdate()
        {
            if (isPlayerNearTrigger)
            {
                _statePassive = false;
                _stateDefensive = true;
            }
            else
            {
                _statePassive = true;
                _stateDefensive = false;
            }
        }
    }
}