﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass380 : GClass377, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -15782;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass380(string string_1 = "")
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
	}

	public override int vmethod_0()
	{
		return -15782;
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
		binaryStream_0.smethod_7(-15782);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
	}

	public string string_0;
}
