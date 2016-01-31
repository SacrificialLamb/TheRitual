using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class ThirdPersonUserControl : MonoBehaviour
    {
        private ThirdPersonCharacter m_Character; // A reference to the ThirdPersonCharacter on the object
        private Camera m_Cam;                  // A reference to the main camera in the scenes transform
        private Vector3 m_CamForward;             // The current forward direction of the camera
        private Vector3 m_Move;
        private bool m_Jump;                      // the world-relative desired move direction, calculated from the camForward and user input.
        private bool camBack;
        public GameObject grabbed;
        
        private void Start()
        {
            // get the transform of the main camera
            if (Camera.main != null)
            {
                m_Cam = Camera.main;
            }
            else
            {
                Debug.LogWarning(
                    "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.");
                // we use self-relative controls in this case, which probably isn't what the user wants, but hey, we warned them!
            }

            // get the third person character ( this should never be null due to require component )
            m_Character = GetComponent<ThirdPersonCharacter>();
            camBack = false;
        }

        void OnCollisionStay(Collision c)
        {
            if (CrossPlatformInputManager.GetButtonDown("Fire1"))
            {
                if(grabbed != null)
                {
                    detachGrab();
                }
                else {
                    PickMe script = c.gameObject.GetComponent<PickMe>();
                    if (script != null)
                    {
                        grabbed = c.gameObject;
                        script.SetPlayer(this);
                    }
                }
            }
        }

        public void detachGrab()
        {
            grabbed.GetComponent<PickMe>().SetPlayer(null);
            grabbed = null;
        }


        private void Update()
        {
            if (!m_Jump)
            {
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
        }


        // Fixed update is called in sync with physics
        private void FixedUpdate()
        {
            // read inputs
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            bool crouch = Input.GetKey(KeyCode.C);

            if(v < 0)
            {
                if(!camBack)
                {
                    camBack = true;
                    transform.Rotate(0, 180, 0);
                }
                else
                {
                    v = -v;
                }
            } else if(v > 0)
            {
                if(camBack)
                {
                    camBack = false;
                    transform.Rotate(0, 180, 0);
                }
            }

            // calculate move direction to pass to character
            if (m_Cam != null)
            {
                // calculate camera relative direction to move:
                m_CamForward = Vector3.Scale(transform.forward, new Vector3(1, 0, 1)).normalized;
                m_Move = v*m_CamForward + h*transform.right;
            }
            else
            {
                // we use world-relative directions in the case of no main camera
                m_Move = v*Vector3.forward + h*Vector3.right;
            }
#if !MOBILE_INPUT
			// walk speed multiplier
	        if (Input.GetKey(KeyCode.LeftShift)) m_Move *= 0.5f;
#endif

            // pass all parameters to the character control script
            m_Character.Move(m_Move, crouch, m_Jump);
            m_Jump = false;
            Vector3 camDir;
            if (camBack)
            {
                camDir = new Vector3(2, 0, 2);
            }
            else {
                camDir = new Vector3(-2, 0, -2);
            }
            m_Cam.transform.position = transform.position + Vector3.Scale(transform.forward.normalized, camDir) + new Vector3(0, 2, 0);
            m_Cam.transform.LookAt(transform.position + new Vector3(0, 1, 0), Vector3.up);
        }
    }
}
