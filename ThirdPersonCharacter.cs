using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson {
	[RequireComponent(typeof(Rigidbody))]
  	[RequireComponent(typeof(CapsuleCollider))]
  	[RequireComponent(typeof(Animator))]
  	public class ThirdPersonCharacter : MonoBehaviour {
    		[SerializeField] float m_MovingTurnSpeed = 360;
		[SerializeField] float m_StationaryTurnSpeed = 180;
		[SerializeField] float m_JumpPower = 12f;
		[Range(1f, 4f)][SerializeField] float m_GravityMultiplier = 2f;
		[SerializeField] float m_RunCycleLegOffset = 0.2f; //specific to the character in sample assets, will need to be modified to work with others
		[SerializeField] float m_MoveSpeedMultiplier = 1f;
		[SerializeField] float m_AnimSpeedMultiplier = 1f;
		[SerializeField] float m_GroundCheckDistance = 0.1f;
  	}
}
