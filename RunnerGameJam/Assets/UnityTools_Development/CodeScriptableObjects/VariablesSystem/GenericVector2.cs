using UnityEngine;

namespace UnityTools.ScriptableVariables
{
    [CreateAssetMenu(fileName = "Vec2_", menuName = "Variables/Var_Vector2", order = 5)]
    public class GenericVector2 : ScriptableObject
    {
        public Vector2 var;

        public void Set(Vector2 value)
        {
            var = value;
        }

        public void Set(float _x, float _y)
        {
            var.x = _x;
            var.y = _y;
        }

        public Vector2 Get()
        {
            return var;
        }
    }
}
