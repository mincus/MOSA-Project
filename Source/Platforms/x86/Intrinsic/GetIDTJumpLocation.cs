﻿/*
 * (c) 2008 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Simon Wollwage (rootnode) <kintaro@think-in-co.de>
 */

using System;
using Mosa.Runtime.CompilerFramework;
using Mosa.Runtime.CompilerFramework.Operands;
using Mosa.Runtime.Metadata;
using Mosa.Runtime.Metadata.Signatures;
using IR = Mosa.Runtime.CompilerFramework.IR;

namespace Mosa.Platforms.x86.Intrinsic
{
	/// <summary>
	/// Representations a jump to the global interrupt handler.
	/// </summary>
	public sealed class GetIDTJumpLocation : IIntrinsicMethod
	{
		#region Methods

		/// <summary>
		/// Replaces the instrinsic call site
		/// </summary>
		/// <param name="context">The context.</param>
		public void ReplaceIntrinsicCall(Context context)
		{
			if (!(context.Operand1 is ConstantOperand))
				throw new InvalidOperationException();

			int irq = -1;

			object obj = (context.Operand1 as ConstantOperand).Value;

			if ((obj is int) || (obj is uint))
				irq = (int)obj;
			else if (obj is sbyte)
				irq = (sbyte)obj;

			if ((irq > 256) || (irq < 0))
				throw new InvalidOperationException();

			SigType PTR = new SigType(CilElementType.Ptr);

			context.SetInstruction(IR.Instruction.MoveInstruction, context.Result, new SymbolOperand(PTR, @"Mosa.Tools.Compiler.LinkerGenerated.<$>InterruptISR" + irq.ToString() + "()"));
		}

		#endregion // Methods
	}
}
