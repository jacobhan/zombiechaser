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
    }
    
    
  }
  
}
