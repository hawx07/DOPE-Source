﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass624 : GClass618, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27189;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass624(string string_1 = "", string string_2 = "")
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor(string_1);
		this.string_0 = string_2;
	}

	public override int vmethod_0()
	{
		return 27189;
	}

	public override int vmethod_1()
	{
		return 2;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27189);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
	}

	public string string_0;
}
