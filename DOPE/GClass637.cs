﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass637 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6339;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass637(Vector<GClass676> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass676>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 6339;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass676 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass676;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(6339);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(4153);
		binaryStream_0.smethod_6(-25470);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass676 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass676> vector_0;
}
