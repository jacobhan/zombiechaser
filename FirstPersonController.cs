using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using Random = UnityEngine.Random;

namespace UnityStandardAssets.Characters.FirstPerson {
  [RequireComponent(typeof (CharacterController))]
  [RequireComponent(typeof (AudioSource))]
  public class FirstPersonController : MonoBehaviour {
    [SerializeField] private bool m_IsWalking;
    [SerializeField] private float m_WalkSpeed;
    [SerializeField] private float m_RunSpeed;
    
    
  }
  
  
  
}


