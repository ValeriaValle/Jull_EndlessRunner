using UnityEngine;
using System;

namespace UnityTools.ScriptableVariables
{
    [Serializable]
    public class Vector3Reference
    {
        public bool UseConstant = true;
        public Vector3 ConstantValue;
        public GenericVector3 Variable;

        public Vector3Reference()
        { }

        public Vector3Reference(Vector3 value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public Vector3 Value
        {
            get { return UseConstant ? ConstantValue : Variable.Get(); }
            set { if (UseConstant) ConstantValue = value; else Variable.Set(value); }
        }

        public static implicit operator Vector3(Vector3Reference reference)
        {
            return reference.Value;
        }
    }
}
