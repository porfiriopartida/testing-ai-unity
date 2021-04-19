using DefaultNamespace;
using UnityEngine;

namespace Strategy
{
    public abstract class EnemyStrategy : MonoBehaviour
    {
        public MyState state;
        public MyCharacterController CharacterController;
        public abstract void DoYourThing();
    }
}