﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass455 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27965;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass455(int int_0 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.rAhcEbnBnH = int_0;
	}

	public virtual int vmethod_0()
	{
		return 27965;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.rAhcEbnBnH = binaryStream_0.smethod_0();
		this.rAhcEbnBnH = (U.smethod_0(this.rAhcEbnBnH, 3) | this.rAhcEbnBnH << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(27965);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-32055);
		binaryStream_0.smethod_6(19449);
		binaryStream_0.smethod_3(this.rAhcEbnBnH << 3 | U.smethod_0(this.rAhcEbnBnH, 29));
	}

	public int rAhcEbnBnH;
}
