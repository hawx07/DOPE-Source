﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass253 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21985;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass253(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_3 = int_4;
		this.int_1 = int_5;
		this.int_2 = int_6;
		this.int_0 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 21985;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 15) | this.int_2 << 17);
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 13 | U.smethod_0(this.int_3, 19));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(21985);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		binaryStream_0.fUeiimuocMk(this.int_2 << 15 | U.smethod_0(this.int_2, 17));
		binaryStream_0.smethod_5(18137);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 13) | this.int_3 << 19);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}