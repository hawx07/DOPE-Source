﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass417 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15731;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass417(bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 15731;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(15731);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public bool bool_0;
}