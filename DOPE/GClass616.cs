﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass616 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -332;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass616(int int_1 = 0, Vector<GClass425> vector_1 = null, string string_2 = "", string string_3 = "")
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_0 = string_2;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass425>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.string_1 = string_3;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return -332;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass425 gclass = (GClass425)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.string_1 = binaryStream_0.smethod_2();
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-332);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass425 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_7(this.int_0);
	}

	public string string_0;

	public Vector<GClass425> vector_0;

	public string string_1;

	public int int_0;
}
