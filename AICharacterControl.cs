using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
  [RequireComponent(typeof (NavMeshAgent))]
  [RequireComponent(typeof (ThirdPersonCharacter))]
  
  public class AICharacterControl : MonoBehaviour {
    public NavMeshAgent agent { get; private set;
    public ThirdPersonCharacter character { get; private set; }
    public Transform target;
    
    private void Start() {
      agent = GetComponentInChildren<NavMeshAgent>();
      character = GetComponent<ThirdPersonCharacter>();
      
      agent.updateRotation = false;
      agent.updatePosition = true;
    }
    
    private void Update() {
      if (target != null) {
        agent.SetDestination(target.position);
        
        // use the values to move the character
        character.Move(agent.desiredVelocity, false, false);
      }
      else {
        character.Move(Vector3.zero, false, false);
      }
    }
    public void SetTarget(Transform target) {
      
    }
  }
  
}
