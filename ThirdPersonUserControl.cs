using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.ThirdPerson {
  [RequireComponent(typeof (ThirdPersonCharacter))]
  public class ThirdPersonUserControl : MonoBehaviour {
    private ThirdPersonCharacter m_Character;
    private Transform m_Cam;
    private Vector3 m_CamForward;
    private Vector3 m_Move;
    private bool m_Jump;
    
    private void Start() {
      if (Camera.main != null) {
        m_Cam = Camera.main.transform;
      }
      else {
        
      }
    }
  }
  
}
