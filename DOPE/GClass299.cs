﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass299 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28983;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass299(string string_1 = "", GClass186 gclass186_1 = null)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (gclass186_1 == null)
		{
			this.gclass186_0 = new GClass186(0, 0U, 0, "", 0, false);
			return;
		}
		this.gclass186_0 = gclass186_1;
	}

	public virtual int vmethod_0()
	{
		return 28983;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass186_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass186);
		this.gclass186_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(28983);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(27198);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		this.gclass186_0.imethod_2(binaryStream_0);
	}

	public string string_0;

	public GClass186 gclass186_0;
}
