using UnityEngine;

namespace Strategy
{
    //Your MyCharacterController game object must have one of this to be AI Controlled.
    public class StratCharacterAI : MonoBehaviour
    {
        //Add another mono behavior to define this behavior.
        public EnemyStrategy aiBehaviorStrategy;

        private void Start()
        {
            aiBehaviorStrategy = GetComponent<EnemyStrategy>();
        }

        private void Update()
        {
            aiBehaviorStrategy.DoYourThing(); //Not needed if you have your logic in the Update 
        }
    }
}