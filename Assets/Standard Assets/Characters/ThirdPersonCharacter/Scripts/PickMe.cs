using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    public class PickMe : MonoBehaviour
    {

        public ThirdPersonUserControl player;
        public Vector3 pushPos;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (player != null)
            {
                pushPos = player.transform.position + Vector3.Scale(player.transform.forward.normalized, new Vector3(1.5f, 0, 1.5f)) + player.transform.up.normalized - transform.position;
                //transform.Translate(pushPos - transform.position, Space.World);
                transform.GetComponent<Rigidbody>().AddForce(pushPos*5 - transform.GetComponent<Rigidbody>().velocity);
                transform.GetComponent<Rigidbody>().AddForce(-Physics.gravity);

                /*if (Vector3.Distance(transform.position, player.transform.position) > 4)
                {
                    transform.position = player.transform.position + new Vector3(0, 2, 0);
                    player.detachGrab();
                    // Safe detach
                }*/
            }
        }

        public void SetPlayer(ThirdPersonUserControl tpuc)
        {
            player = tpuc;
        }
    }
}