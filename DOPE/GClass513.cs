﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass513 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 504;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 28;
		}
	}

	public GClass513(double double_3 = 0.0, double double_4 = 0.0, double double_5 = 0.0, int int_1 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.double_2 = double_3;
		this.double_0 = double_4;
		this.double_1 = double_5;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 504;
	}

	public virtual int vmethod_1()
	{
		return 28;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.double_2 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(504);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.smethod_3(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.WriteDouble(this.double_2);
	}

	public double double_0;

	public double double_1;

	public int int_0;

	public double double_2;
}
