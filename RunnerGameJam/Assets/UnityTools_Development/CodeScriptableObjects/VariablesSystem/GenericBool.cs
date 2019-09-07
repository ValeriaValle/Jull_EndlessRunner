using UnityEngine;

namespace UnityTools.ScriptableVariables
{
    [CreateAssetMenu(fileName = "Bool_", menuName = "Variables/Var_Bool", order = 4)]
    public class GenericBool : ScriptableObject
    {
        public bool var;

        public void Set(bool value)
        {
            var = value;
        }

        public bool Get()
        {
            return var;
        }
    }
}