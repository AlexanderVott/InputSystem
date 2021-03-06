using System;
using UnityEngine.Experimental.Input.LowLevel;

namespace UnityEngine.Experimental.Input.Controls
{
    ////TODO: allow format to be any integer format
    public class IntegerControl : InputControl<int>
    {
        public IntegerControl()
        {
            m_StateBlock.format = InputStateBlock.kTypeInt;
        }

        public override unsafe int ReadRawValueFrom(IntPtr statePtr)
        {
            var valuePtr = new IntPtr(statePtr.ToInt64() + (int)m_StateBlock.byteOffset);
            return *(int*)valuePtr;
        }

        protected override unsafe void WriteRawValueInto(IntPtr statePtr, int value)
        {
            var valuePtr = new IntPtr(statePtr.ToInt64() + (int)m_StateBlock.byteOffset);
            *(int*)valuePtr = value;
        }
    }
}
