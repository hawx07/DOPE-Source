﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass342 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3947;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass342(Vector<int> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 3947;
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
			int num3 = binaryStream_0.smethod_0();
			num3 = (num3 << 4 | U.smethod_0(num3, 28));
			this.vector_0.method_0(num3);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(3947);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(30360);
		binaryStream_0.smethod_6(4198);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_3(U.smethod_0(num, 4) | num << 28);
		}
	}

	public Vector<int> vector_0;
}
