﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass806 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2282;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass806(int int_1 = 0, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_1;
		this.double_0 = double_2;
		this.double_1 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 2282;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.double_1 = (double)binaryStream_0.smethod_10();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2282);
		binaryStream_0.smethod_4(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_9(this.double_1);
	}

	public int int_0;

	public double double_0;

	public double double_1;
}
