using KitchenLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DragNDropDesigner
{
    public class CreateCursorObject
    {
        public static GameObject cursor;

        public static void CreateCursor()
        {
            GameObject cursorObject = new GameObject("Cursor Object");

            cursorObject.AddComponent<MousePosition>();
            cursorObject.AddComponent<MeshRenderer>();

            cursorObject.GetComponent<MeshRenderer>().material = MaterialUtils.GetExistingMaterial("AppleGreen");

            // Create a new sphere mesh
            Mesh sphereMesh = new Mesh();

            // Assign the mesh to the filter
            MeshFilter filter = cursorObject.AddComponent<MeshFilter>();
            filter.mesh = sphereMesh;

            cursor = cursorObject;
        }
    }
}
