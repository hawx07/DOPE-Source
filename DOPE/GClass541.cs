﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass541 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15173;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 19;
		}
	}

	public GClass541(int int_9 = 0, int int_10 = 0, int int_11 = 0, bool bool_1 = false, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_1 = int_9;
		this.int_7 = int_10;
		this.int_0 = int_11;
		this.bool_0 = bool_1;
		this.int_3 = int_12;
		this.int_6 = int_13;
		this.int_8 = int_14;
		this.int_4 = int_15;
		this.int_5 = int_16;
		this.int_2 = int_17;
	}

	public virtual int vmethod_0()
	{
		return 15173;
	}

	public virtual int vmethod_1()
	{
		return 19;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.int_3 = (int)binaryStream_0.smethod_1();
		this.int_4 = (int)binaryStream_0.smethod_1();
		this.int_5 = (int)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_6 = (int)binaryStream_0.smethod_1();
		this.int_7 = (int)binaryStream_0.smethod_1();
		this.int_8 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(15173);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(24776);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_5(this.int_0);
		binaryStream_0.smethod_5(this.int_1);
		binaryStream_0.smethod_5(this.int_2);
		binaryStream_0.smethod_5(this.int_3);
		binaryStream_0.smethod_5(this.int_4);
		binaryStream_0.smethod_5(this.int_5);
		binaryStream_0.smethod_5(-27842);
		binaryStream_0.smethod_5(this.int_6);
		binaryStream_0.smethod_5(this.int_7);
		binaryStream_0.smethod_5(this.int_8);
	}

	public bool bool_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;
}