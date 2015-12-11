using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.FirstPerson {
  [Serializable]
  public class MouseLook {
    public float XSensitivity = 2f;
    public float YSensitivity = 2f;
    public bool clampVerticalRotation = true;
    public float MinimumX = -90F;
    public float MaximumX = 90F;
    public bool smooth;
    public float smoothTime = 5f;
    
    private Quaternion m_CharacterTargetRot;
    private Quaternion m_CameraTargetRot;
    
    public void Init(Transform character, Transform camera) {
      m_CharacterTargetRot = character.localRotation;
      m_CameraTargetRot = camera.localRotation;
    }
    public void LookRotation(Transform character, Transform camera) {
      float yRot = CrossPlatformInputManager.GetAxis("Mouse X") * XSensitivity;
      float xRot = CrossPlatformInputManager.GetAxis("Mouse Y") * YSensitivity;

      m_CharacterTargetRot *= Quaternion.Euler (0f, yRot, 0f);
      m_CameraTargetRot *= Quaternion.Euler (-xRot, 0f, 0f);
      
      if(clampVerticalRotation)
        m_CameraTargetRot = ClampRotationAroundXAxis (m_CameraTargetRot);
        
      if(smooth) {
        
        
      }
    }
    
  }
  
  
}

