using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

namespace MPTest
{
    public class Player : NetworkBehaviour
    {
        [Client]
        private void Update()
        {
            if(!hasAuthority)
            {
                return;
            }

            if(!Input.GetKeyDown(KeyCode.Space))
            {
                return;
            }
            else
            {
                transform.position += Vector3.up;
            }
        }
    }
}
