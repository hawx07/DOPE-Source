﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass781 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16539;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass781(GClass349 gclass349_1 = null, int int_2 = 0, int int_3 = 0, bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass349_1 == null)
		{
			this.gclass349_0 = new GClass349(0U);
		}
		else
		{
			this.gclass349_0 = gclass349_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 16539;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass349_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass349);
		this.gclass349_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(16539);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass349_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(792);
		binaryStream_0.smethod_3(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
	}

	public bool bool_0;

	public GClass349 gclass349_0;

	public int int_0;

	public int int_1;
}
