﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass695 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24395;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass695(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_2 = false, bool bool_3 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_1 = int_3;
		this.int_2 = int_4;
		this.int_0 = int_5;
		this.kvfKevjuq5 = int_6;
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 24395;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.kvfKevjuq5 = binaryStream_0.smethod_0();
		this.kvfKevjuq5 = (this.kvfKevjuq5 << 12 | U.smethod_0(this.kvfKevjuq5, 20));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 2) | this.int_2 << 30);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(24395);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_5(6643);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.kvfKevjuq5, 12) | this.kvfKevjuq5 << 20);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		binaryStream_0.fUeiimuocMk(this.int_2 << 2 | U.smethod_0(this.int_2, 30));
	}

	public bool bool_0;

	public int kvfKevjuq5;

	public int int_0;

	public bool bool_1;

	public int int_1;

	public int int_2;
}