/*
 * (c) 2008 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Michael Ruck (<mailto:sharpos@michaelruck.de>)
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Mosa.Runtime.CompilerFramework.IL
{
	/// <summary>
    /// All CIL opcodes as defined in ISO/IEC 23271:2006 (E).
	/// </summary>
	public enum OpCode {
		Nop				= 0x000,
		Break			= 0x001,
		Ldarg_0			= 0x002,
		Ldarg_1			= 0x003,
		Ldarg_2			= 0x004,
		Ldarg_3			= 0x005,
		Ldloc_0			= 0x006,
		Ldloc_1			= 0x007,
		Ldloc_2			= 0x008,
		Ldloc_3			= 0x009,
		Stloc_0			= 0x00A,
		Stloc_1			= 0x00B,
		Stloc_2			= 0x00C,
		Stloc_3			= 0x00D,
		Ldarg_s			= 0x00E,
		Ldarga_s		= 0x00F,

		Starg_s			= 0x010,
		Ldloc_s			= 0x011,
		Ldloca_s		= 0x012,
		Stloc_s			= 0x013,
		Ldnull			= 0x014,
		Ldc_i4_m1		= 0x015,
		Ldc_i4_0		= 0x016,
		Ldc_i4_1		= 0x017,
		Ldc_i4_2		= 0x018,
		Ldc_i4_3		= 0x019,
		Ldc_i4_4		= 0x01A,
		Ldc_i4_5		= 0x01B,
		Ldc_i4_6		= 0x01C,
		Ldc_i4_7		= 0x01D,
		Ldc_i4_8		= 0x01E,
		Ldc_i4_s		= 0x01F,

		Ldc_i4			= 0x020,
		Ldc_i8			= 0x021,
		Ldc_r4			= 0x022,
		Ldc_r8			= 0x023,
		
        Dup				= 0x025,
		Pop				= 0x026,
		Jmp				= 0x027,
		Call			= 0x028,
		Calli			= 0x029,
		Ret				= 0x02A,
		Br_s			= 0x02B,
		Brfalse_s		= 0x02C,
		Brtrue_s		= 0x02D,
		Beq_s			= 0x02E,
		Bge_s			= 0x02F,

		Bgt_s			= 0x030,
		Ble_s			= 0x031,
		Blt_s			= 0x032,
		Bne_un_s		= 0x033,
		Bge_un_s		= 0x034,
		Bgt_un_s		= 0x035,
		Ble_un_s		= 0x036,
		Blt_un_s		= 0x037,
		Br				= 0x038,
		Brfalse			= 0x039,
		Brtrue			= 0x03A,
		Beq				= 0x03B,
		Bge				= 0x03C,
		Bgt				= 0x03D,
		Ble				= 0x03E,
		Blt				= 0x03F,

		Bne_un			= 0x040,
		Bge_un			= 0x041,
		Bgt_un			= 0x042,
		Ble_un			= 0x043,
		Blt_un			= 0x044,
		Switch			= 0x045,
		Ldind_i1		= 0x046,
		Ldind_u1		= 0x047,
		Ldind_i2		= 0x048,
		Ldind_u2		= 0x049,
		Ldind_i4		= 0x04A,
		Ldind_u4		= 0x04B,
		Ldind_i8		= 0x04C,
		Ldind_i			= 0x04D,
		Ldind_r4		= 0x04E,
		Ldind_r8		= 0x04F,

		Ldind_ref		= 0x050,
		Stind_ref		= 0x051,
		Stind_i1		= 0x052,
		Stind_i2		= 0x053,
		Stind_i4		= 0x054,
		Stind_i8		= 0x055,
		Stind_r4		= 0x056,
		Stind_r8		= 0x057,
		Add				= 0x058,
		Sub				= 0x059,
		Mul				= 0x05A,
		Div				= 0x05B,
		Div_un			= 0x05C,
		Rem				= 0x05D,
		Rem_un			= 0x05E,
		And				= 0x05F,

		Or				= 0x060,
		Xor				= 0x061,
		Shl				= 0x062,
		Shr				= 0x063,
		Shr_un			= 0x064,
		Neg				= 0x065,
		Not				= 0x066,
		Conv_i1			= 0x067,
		Conv_i2			= 0x068,
		Conv_i4			= 0x069,
		Conv_i8			= 0x06A,
		Conv_r4			= 0x06B,
		Conv_r8			= 0x06C,
		Conv_u4			= 0x06D,
		Conv_u8			= 0x06E,
		Callvirt		= 0x06F,

		Cpobj			= 0x070,
		Ldobj			= 0x071,
		Ldstr			= 0x072,
		Newobj			= 0x073,
		Castclass		= 0x074,
		Isinst			= 0x075,
		Conv_r_un		= 0x076,
		Unbox			= 0x079,
		Throw			= 0x07A,
		Ldfld			= 0x07B,
		Ldflda			= 0x07C,
		Stfld			= 0x07D,
		Ldsfld			= 0x07E,
		Ldsflda			= 0x07F,

		Stsfld			= 0x080,
		Stobj			= 0x081,
		Conv_ovf_i1_un	= 0x082,
		Conv_ovf_i2_un	= 0x083,
		Conv_ovf_i4_un	= 0x084,
		Conv_ovf_i8_un	= 0x085,
		Conv_ovf_u1_un	= 0x086,
		Conv_ovf_u2_un	= 0x087,
		Conv_ovf_u4_un	= 0x088,
		Conv_ovf_u8_un	= 0x089,
		Conv_ovf_i_un	= 0x08A,
		Conv_ovf_u_un	= 0x08B,
		Box				= 0x08C,
		Newarr			= 0x08D,
		Ldlen			= 0x08E,
		Ldelema			= 0x08F,

		Ldelem_i1		= 0x090,
		Ldelem_u1		= 0x091,
		Ldelem_i2		= 0x092,
		Ldelem_u2		= 0x093,
		Ldelem_i4		= 0x094,
		Ldelem_u4		= 0x095,
		Ldelem_i8		= 0x096,
		Ldelem_i		= 0x097,
		Ldelem_r4		= 0x098,
		Ldelem_r8		= 0x099,
		Ldelem_ref		= 0x09A,
		Stelem_i		= 0x09B,
		Stelem_i1		= 0x09C,
		Stelem_i2		= 0x09D,
		Stelem_i4		= 0x09E,
		Stelem_i8		= 0x09F,

		Stelem_r4		= 0x0A0,
		Stelem_r8		= 0x0A1,
		Stelem_ref		= 0x0A2,
		Ldelem			= 0x0A3,
		Stelem			= 0x0A4,
		Unbox_any		= 0x0A5,

		Conv_ovf_i1		= 0x0B3,
		Conv_ovf_u1		= 0x0B4,
		Conv_ovf_i2		= 0x0B5,
		Conv_ovf_u2		= 0x0B6,
		Conv_ovf_i4		= 0x0B7,
		Conv_ovf_u4		= 0x0B8,
		Conv_ovf_i8		= 0x0B9,
		Conv_ovf_u8		= 0x0BA,

		Refanyval		= 0x0C2,
		Ckfinite		= 0x0C3,

		Mkrefany		= 0x0C6,

        /* 0x0C7-0x0CF: Not valid for MSIL binaries. Opcodes used in IR transforms. */
        Ann_call        = 0x0C7,
        Ann_catch       = 0x0C8,
        Ann_dead        = 0x0C9,
        Ann_hoisted     = 0x0CA,
        Ann_hoistedcall = 0x0CB,
        Ann_lab         = 0x0CC,
        Ann_def         = 0x0CD,
        Ann_ref_s       = 0x0CE,
        Ann_phi         = 0x0CF,

		Ldtoken			= 0x0D0,
		Conv_u2			= 0x0D1,
		Conv_u1			= 0x0D2,
		Conv_i			= 0x0D3,
		Conv_ovf_i		= 0x0D4,
		Conv_ovf_u		= 0x0D5,
		Add_ovf			= 0x0D6,
		Add_ovf_un		= 0x0D7,
		Mul_ovf			= 0x0D8,
		Mul_ovf_un		= 0x0D9,
		Sub_ovf			= 0x0DA,
		Sub_ovf_un		= 0x0DB,
		Endfinally		= 0x0DC,
		Leave			= 0x0DD,
		Leave_s			= 0x0DE,
		Stind_i			= 0x0DF,

		Conv_u			= 0x0E0,

		Extop			= 0x0FE,

		Arglist			= 0x100,
		Ceq				= 0x101,
		Cgt				= 0x102,
		Cgt_un			= 0x103,
		Clt				= 0x104,
		Clt_un			= 0x105,
		Ldftn			= 0x106,
		Ldvirtftn		= 0x107,

		Ldarg			= 0x109,
		Ldarga			= 0x10A,
		Starg			= 0x10B,
		Ldloc			= 0x10C,
		Ldloca			= 0x10D,
		Stloc			= 0x10E,
		Localalloc		= 0x10F,

		Endfilter		= 0x111,
		PreUnaligned	= 0x112,
		PreVolatile		= 0x113,
		PreTail			= 0x114,
		InitObj			= 0x115,
		PreConstrained	= 0x116,
		Cpblk			= 0x117,
		Initblk			= 0x118,
		PreNo			= 0x119,
		Rethrow			= 0x11A,

		Sizeof			= 0x11C,
		Refanytype		= 0x11D,
		PreReadOnly		= 0x11E
	}
}