﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass778 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27347;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass778(int int_1 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 27347;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(27347);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		binaryStream_0.smethod_6(12485);
	}

	public int int_0;
}
