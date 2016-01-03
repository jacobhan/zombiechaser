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
    [SerializeField] [Range(0f, 1f)] private float m_RunstepLenghten;
    [SerializeField] private float m_JumpSpeed;
    [SerializeField] private float m_StickToGroundForce;
    [SerializeField] private float m_GravityMultiplier;
    [SerializeField] private MouseLook m_MouseLook;
    [SerializeField] private bool m_UseFovKick;
    [SerializeField] private FOVKick m_FovKick = new FOVKick();
    [SerializeField] private bool m_UseHeadBob;
    [SerializeField] private CurveControlledBob m_HeadBob = new CurveControlledBob();
    [SerializeField] private LerpControlledBob m_JumpBob = new LerpControlledBob();
    [SerializeField] private float m_StepInterval;
    [SerializeField] private AudioClip[] m_FootstepSounds;
    [SerializeField] private AudioClip m_JumpSound;
    [SerializeField] private AudioClip m_LandSound;
    
    private Camera m_Camera;
    private bool m_Jump;
    private float m_YRotation;
    private Vector2 m_Input;
    private Vector3 m_MoveDir = Vector3.zero;
    private CharacterController m_CharacterController;
    private CollisionFlags m_CollisionFlags;
    private bool m_PreviouslyGrounded;
    private Vector3 m_OriginalCameraPosition;
    private float m_StepCycle;
    private float m_NextStep;
    private bool m_Jumping;
    private AudioSource m_AudioSource;
    
    private void Start() {
      m_CharacterController = GetComponent<CharacterController>();
      m_Camera = Camera.main;
      m_OriginalCameraPosition = m_Camera.transform.localPosition;
      m_FovKick.Setup(m_Camera);
      m_HeadBob.Setup(m_Camera, m_StepInterval);
      m_StepCycle = 0f;
      m_NextStep = m_StepCycle/2f;
      m_Jumping = false;
      m_AudioSource = GetComponent<AudioSource>();
      m_MouseLook.Init(transform , m_Camera.transform);
      
    }
    
    private void Update() {
      RotateView();
      if (!m_Jump) {
        m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
      }
      if (!m_PreviouslyGrounded && m_CharacterController.isGrounded) {
        StartCoroutine(m_JumpBob.DoBobCycle());
        PlayLandingSound();
        m_MoveDir.y = 0f;
        m_Jumping = false;
      }
      if (!m_CharacterController.isGrounded && !m_Jumping && m_PreviouslyGrounded) {
        m_MoveDir.y = 0f;
      }
      m_PreviouslyGrounded = m_CharacterController.isGrounded;
    }
    private void PlayLandingSound() {
      m_AudioSource.clip = m_LandSound;
      m_AudioSource.Play();
      m_NextStep = m_StepCycle + .5f;
    }
    private void FixedUpdate() {
      
      
    }
  }
  
  
  
}


