﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass702 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21988;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass702(uint uint_1 = 0U, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_2 = int_4;
		this.int_1 = int_5;
		this.int_3 = int_6;
		this.int_0 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 21988;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 11) | this.int_2 << 21);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 7 | U.smethod_0(this.int_3, 25));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(21988);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		binaryStream_0.smethod_5(3870);
		binaryStream_0.fUeiimuocMk(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.fUeiimuocMk(this.int_2 << 11 | U.smethod_0(this.int_2, 21));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 7) | this.int_3 << 25);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.smethod_5(-19706);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public uint uint_0;
}