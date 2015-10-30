using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson {
	[RequireComponent(typeof(Rigidbody))]
  	[RequireComponent(typeof(CapsuleCollider))]
  	[RequireComponent(typeof(Animator))]
  	public class ThirdPersonCharacter : MonoBehaviour {
    		[SerializeField] float m_MovingTurnSpeed = 360;
		[SerializeField] float m_StationaryTurnSpeed = 180;
  	}
}
