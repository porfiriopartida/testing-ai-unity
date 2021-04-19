using Strategy;

namespace DefaultNamespace
{
    public class AgressiveStrategy : EnemyStrategy
    {
        //------------- AI core ----------------
        //Triggers 
        //Updated with colliders/or methods that check for distance/path
        public bool isPlayerNearTrigger = false;
        public bool isPlayerInShootDistanceTrigger = false;
        //States
        private bool _stateAttacking = false;
        private bool _stateLooking = false;
        private bool _stateWalkingTowardsPlayer = false;
        //--------------------------------------

        private void Start()
        {
            _stateLooking = true;
            _stateWalkingTowardsPlayer = false;
            _stateAttacking = false;
        }

        public override void DoYourThing()
        {
            StateUpdate();
            TriggerUpdate();
        }

        private void StateUpdate()
        {
            if (isPlayerNearTrigger)
            {
                _stateLooking = false;
                _stateWalkingTowardsPlayer = true;
                _stateAttacking = false;
            }
            else if(isPlayerInShootDistanceTrigger)
            {
                _stateLooking = false;
                _stateWalkingTowardsPlayer = false;
                _stateAttacking = true;
            }
            else
            {
                _stateLooking = true;
                _stateWalkingTowardsPlayer = false;
                _stateAttacking = false;
            }
        }

        void TriggerUpdate()
        {
            if (_stateLooking)
            {
                CharacterController.LookForPlayer();
            }
            else if (_stateWalkingTowardsPlayer)
            {
                CharacterController.WalkTowardsPlayer();
            } else if (_stateAttacking)
            {
                CharacterController.Attack();
            }
        }
    }
}