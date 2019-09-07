using UnityEngine;

namespace UnityTools.ScriptableVariables
{
    [CreateAssetMenu(fileName = "Float_", menuName = "Variables/Var_Float", order = 2)]
    public class GenericFloat : ScriptableObject
    {
        public float var;

        public void Set(float value)
        {
            var = value;
        }

        public float Get()
        {
            return var;
        }
    }
}