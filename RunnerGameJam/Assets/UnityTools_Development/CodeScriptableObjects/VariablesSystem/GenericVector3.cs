using UnityEngine;

namespace UnityTools.ScriptableVariables
{
    [CreateAssetMenu(fileName = "Vec3_", menuName = "Variables/Var_Vector3", order = 6)]
    public class GenericVector3 : ScriptableObject
    {
        public Vector3 var;

        public void Set(Vector3 value)
        {
            var = value;
        }

        public void Set(float _x, float _y, float _z)
        {
            var.x = _x;
            var.y = _y;
            var.z = _z;
        }

        public Vector3 Get()
        {
            return var;
        }
    }
}