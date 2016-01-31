using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    public class Dumb : MonoBehaviour {

        public GameObject person;

        // Use this for initialization
        void Start() {
            person.GetComponent<AICharacterControl>().SetTarget(transform);
        }

        // Update is called once per frame
        void Update() {

        }
    }
}