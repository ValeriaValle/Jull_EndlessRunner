using System;

namespace UnityTools.ScriptableVariables
{
    [Serializable]
    public class BoolReference
    {
        public bool UseConstant = true;
        public bool ConstantValue;
        public GenericBool Variable;

        public BoolReference()
        { }

        public BoolReference(bool value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public bool Value
        {
            get { return UseConstant ? ConstantValue : Variable.Get(); }
            set { if (UseConstant) ConstantValue = value; else Variable.Set(value); }
        }

        public static implicit operator bool(BoolReference reference)
        {
            return reference.Value;
        }
    }
}