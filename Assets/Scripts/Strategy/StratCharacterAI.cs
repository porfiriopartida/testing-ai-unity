using Strategy;
using UnityEngine;

namespace DefaultNamespace
{
    //Your MyCharacterController game object must have one of this to be AI Controlled.
    public class StratCharacterAI : MonoBehaviour
    {
        //Add another mono behavior to define this behavior.
        public EnemyStrategy AIBehaviorStrategy;

        private void Start()
        {
            AIBehaviorStrategy = GetComponent<EnemyStrategy>();
        }

        private void Update()
        {
            AIBehaviorStrategy.DoYourThing(); //Not needed if you have your logic in the Update 
        }
    }
}