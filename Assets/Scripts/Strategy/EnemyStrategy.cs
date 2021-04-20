using States;
using UnityEngine;

namespace Strategy
{
    public abstract class EnemyStrategy : MonoBehaviour
    {
        public MyState state;//must remove
        public MyCharacterController CharacterController;
        public abstract void DoYourThing();
    }
}
