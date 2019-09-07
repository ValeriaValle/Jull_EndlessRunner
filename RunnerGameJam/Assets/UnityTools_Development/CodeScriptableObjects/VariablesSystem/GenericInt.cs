using UnityEngine;

namespace UnityTools.ScriptableVariables
{
    [CreateAssetMenu(fileName = "Int_", menuName = "Variables/Var_Int", order = 1)]
    public class GenericInt : ScriptableObject
    {
        public int var;

        public void Set(int value)
        {
            var = value;
        }

        public int Get()
        {
            return var;
        }
    }
}