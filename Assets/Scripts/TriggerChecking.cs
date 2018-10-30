using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Completed
{



    public class TriggerChecking : MonoBehaviour
    {

        /// <summary>
        /// Happens when this obejct enters a trigger
        /// </summary>
        /// <param name="other">The other object</param>
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("<color=regd>On Trigger enter!</color>");    
        }

        /// <summary>
        /// Happens when this object COLLIDES with another
        /// </summary>
        /// <param name="collision">The colliding object</param>
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("<color=yellow>On Collision Enter!</color>");
        }

    }



}