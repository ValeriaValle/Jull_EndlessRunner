using UnityEngine;

namespace UnityTools.ScriptableVariables
{
    [CreateAssetMenu(fileName = "String_", menuName = "Variables/Var_String", order = 3)]
    public class GenericString : ScriptableObject
    {
        public string var;

        public void Set(string value)
        {
            var = value;
        }

        public string Get()
        {
            return var;
        }
    }
}