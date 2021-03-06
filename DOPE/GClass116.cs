﻿using System;
using System.Runtime.CompilerServices;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass116 : GInterface4
{
	public GClass116()
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
	}

	public Map Map
	{
		get
		{
			return ConnectionManager.Instance.Value.Game.Map;
		}
	}

	public void method_0(GClass126 gclass126_0)
	{
		Map map = ConnectionManager.Instance.Value.Game.Map;
		Asset asset;
		if (gclass126_0.gclass130_0.int_0 != 35)
		{
			if (gclass126_0.gclass130_0.int_0 != 36)
			{
				if ((long)gclass126_0.gclass130_0.int_0 == 37L)
				{
					asset = new BattlestationModule(gclass126_0.int_4, gclass126_0.int_5);
					goto IL_91;
				}
				asset = new Asset(gclass126_0.int_4, gclass126_0.int_5);
				goto IL_91;
			}
		}
		asset = (map.Battlestation = new Battlestation(gclass126_0.int_4, gclass126_0.int_5));
		IL_91:
		if (asset != null)
		{
			asset.method_0(gclass126_0);
			map.Assets[gclass126_0.int_2] = asset;
			ICollidable collidable = asset;
			if (collidable != null)
			{
				map.Collidables[gclass126_0.string_1] = collidable;
			}
			map.Grid.method_10(asset);
		}
	}

	public void method_1(GClass191 gclass191_0)
	{
		this.Map.method_10(gclass191_0);
	}

	public void method_2(GClass244 gclass244_0)
	{
		this.Map.method_19(gclass244_0);
	}

	public void method_3(GClass246 gclass246_0)
	{
		this.Map.method_20(gclass246_0);
	}

	public void method_4(GClass182 gclass182_0)
	{
		this.Map.ElDbxisjQW(gclass182_0);
	}

	public void method_5(GClass268 gclass268_0)
	{
		this.Map.method_12(gclass268_0);
	}

	public void rgnhLwKlpi(GClass266 gclass266_0)
	{
		this.Map.method_21(gclass266_0);
	}

	public void method_6(GClass270 gclass270_0)
	{
		this.Map.SelectedShip = null;
	}

	public void method_7(GClass186 gclass186_0)
	{
		GClass116.<>c__DisplayClass11_0 CS$<>8__locals1;
		CS$<>8__locals1.gclass186_0 = gclass186_0;
		Gate iinteractible_;
		if (this.Map.Gates.TryGetValue(CS$<>8__locals1.gclass186_0.Id, out iinteractible_))
		{
			GClass116.smethod_0(iinteractible_, ref CS$<>8__locals1);
		}
		Asset iinteractible_2;
		if (this.Map.Assets.TryGetValue(CS$<>8__locals1.gclass186_0.Id, out iinteractible_2))
		{
			GClass116.smethod_0(iinteractible_2, ref CS$<>8__locals1);
			return;
		}
	}

	public void method_8(GClass187 gclass187_0)
	{
		this.Map.method_16(gclass187_0);
	}

	public void method_9(GClass181 gclass181_0)
	{
		this.Map.qVibdgqUh5(gclass181_0);
	}

	public void method_10(GClass140 gclass140_0)
	{
		this.Map.YisbbqPhOt(gclass140_0);
	}

	public void method_11(GClass263 gclass263_0)
	{
		this.Map.method_14(gclass263_0);
	}

	public void method_12(GClass179 gclass179_0)
	{
		this.Map.method_15(gclass179_0);
	}

	public void method_13(GClass267 gclass267_0)
	{
		this.Map.method_11(gclass267_0.int_0, false);
	}

	public void method_14(GClass265 gclass265_0)
	{
		this.Map.method_11(gclass265_0.int_0, true);
	}

	public void method_15(GClass264 gclass264_0)
	{
		this.Map.yZubzmcSq5(gclass264_0);
	}

	public void method_16(GClass254 gclass254_0)
	{
		this.Map.method_18(gclass254_0);
	}

	public void method_17(GClass238 gclass238_0)
	{
		this.Map.method_22(gclass238_0);
	}

	public void method_18(GClass247 gclass247_0)
	{
		this.Map.method_23(gclass247_0);
		if (gclass247_0.string_0.StartsWith("group_ping"))
		{
			this.Map.Hero.Group.method_0(gclass247_0);
		}
	}

	[CompilerGenerated]
	internal static bool smethod_0(IInteractible iinteractible_0, ref GClass116.<>c__DisplayClass11_0 <>c__DisplayClass11_0_0)
	{
		if (iinteractible_0.Id == <>c__DisplayClass11_0_0.gclass186_0.Id)
		{
			iinteractible_0.Activatable = <>c__DisplayClass11_0_0.gclass186_0.bool_0;
			iinteractible_0.Activated = (<>c__DisplayClass11_0_0.gclass186_0.State == 0);
			return true;
		}
		return false;
	}
}
