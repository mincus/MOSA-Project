﻿/*
 * (c) 2008 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *  Michael Ruck (grover) <sharpos@michaelruck.de>
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using IR = Mosa.Runtime.CompilerFramework.IR;

using Mosa.Runtime.CompilerFramework;


namespace Mosa.Platforms.x86.CPUx86
{
    /// <summary>
    /// Representations the x86 iretd instruction.
    /// </summary>
    public sealed class IRetdInstruction : BaseInstruction
    {
 
        #region Methods


		/// <summary>
		/// Emits the specified platform instruction.
		/// </summary>
		/// <param name="ctx">The context.</param>
		/// <param name="emitter">The emitter.</param>
		protected override void Emit(Context ctx, MachineCodeEmitter emitter)
		{
			emitter.WriteByte(0xCF);
		}

		/// <summary>
		/// Allows visitor based dispatch for this instruction object.
		/// </summary>
		/// <param name="visitor">The visitor object.</param>
		/// <param name="context">The context.</param>
		public override void Visit(IX86Visitor visitor, Context context)
		{
			visitor.Iretd(context);
		}

        #endregion // Methods
    }
}
