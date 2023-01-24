using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DragNDropDesigner
{
    public class MousePosition : MonoBehaviour
    {
        public Vector3 screenPosition;
        public Vector3 worldPosition;
        Plane plane = new Plane(Vector3.down, 0);

        public void Update()
        {
            screenPosition = Mouse.current.position.ReadValue();

            Ray ray = Camera.main.ScreenPointToRay(screenPosition);

            if (plane.Raycast(ray, out float distance))
            {
                worldPosition = ray.GetPoint(distance);
            }

            CreateCursorObject.cursor.transform.position = worldPosition;
        }
    }
}
