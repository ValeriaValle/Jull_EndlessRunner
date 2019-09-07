using System;

namespace UnityTools.ScriptableVariables
{
    [Serializable]
    public class FloatReference
    {
        public bool UseConstant = true;
        public float ConstantValue;
        public GenericFloat Variable;

        public FloatReference()
        { }

        public FloatReference(float value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public float Value
        {
            get { return UseConstant ? ConstantValue : Variable.Get(); }
            set { if (UseConstant) ConstantValue = value; else Variable.Set(value); }
        }

        public static implicit operator float(FloatReference reference)
        {
            return reference.Value;
        }
    }
}
