﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass440 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25741;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass440(Vector<GClass586> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass586>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 25741;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass586 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass586;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(25741);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass586 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_6(25242);
	}

	public Vector<GClass586> vector_0;
}
