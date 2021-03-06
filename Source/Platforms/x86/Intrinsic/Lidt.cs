﻿/*
 * (c) 2008 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Michael Ruck (grover) <sharpos@michaelruck.de>
 */

using Mosa.Runtime.CompilerFramework;
using Mosa.Runtime.CompilerFramework.Operands;

namespace Mosa.Platforms.x86.Intrinsic
{
    /// <summary>
    /// Representations the x86 Lidt instruction.
    /// </summary>
	public sealed class Lidt : IIntrinsicMethod
    {
	
		#region Methods

		/// <summary>
		/// Replaces the instrinsic call site
		/// </summary>
		/// <param name="context">The context.</param>
		public void ReplaceIntrinsicCall(Context context)
		{
			MemoryOperand operand = new MemoryOperand(new Mosa.Runtime.Metadata.Signatures.SigType(Mosa.Runtime.Metadata.CilElementType.Ptr), GeneralPurposeRegister.EAX, new System.IntPtr(0));
			context.SetInstruction(CPUx86.Instruction.MovInstruction, new RegisterOperand(new Mosa.Runtime.Metadata.Signatures.SigType(Mosa.Runtime.Metadata.CilElementType.Ptr), GeneralPurposeRegister.EAX), context.Operand1);
			context.AppendInstruction(CPUx86.Instruction.LidtInstruction, null, operand);
		}

		#endregion // Methods

    }
}
