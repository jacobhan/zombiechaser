using System;
using UnityEngine;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Characters.FirstPerson {
  public class HeadBob : MonoBehaviour {
    public Camera Camera;
    public CurveControlledBob motionBob = new CurveControlledBob();
    public LerpControlledBob jumpAndLandingBob = new LerpControlledBob();
    
  }
  
}
