﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass633 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1474;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass633(bool bool_1 = false, Vector<int> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.bool_0 = bool_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 1474;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (U.smethod_0(num3, 10) | num3 << 22);
			this.vector_0.method_0(num3);
			num++;
		}
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(1474);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-20598);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_3(num << 10 | U.smethod_0(num, 22));
		}
		binaryStream_0.smethod_6(-15035);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public Vector<int> vector_0;

	public bool bool_0;
}
