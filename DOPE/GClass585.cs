﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass585 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11490;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass585(int int_0 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.Id = int_0;
	}

	public virtual int vmethod_0()
	{
		return 11490;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 14) | this.Id << 18);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(11490);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-20218);
		binaryStream_0.smethod_3(this.Id << 14 | U.smethod_0(this.Id, 18));
	}

	public int Id;
}
