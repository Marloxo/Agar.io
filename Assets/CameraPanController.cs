using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPanController : MonoBehaviour
{
   public Vector2 panLimit;

   void Update()
   {
      Vector3 pos = transform.position;

      pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);

      pos.y = Mathf.Clamp(pos.y, -panLimit.y, panLimit.y);

      transform.position = pos;
   }
}
