﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using DarkorbitAPI;
using DarkorbitAPI.Structures;
using DOPE.Common;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;

public class GClass836 : GClass834
{
	public GClass847 Behavior
	{
		[CompilerGenerated]
		get
		{
			return this.gclass847_0;
		}
		[CompilerGenerated]
		private set
		{
			if (object.Equals(this.gclass847_0, value))
			{
				return;
			}
			this.gclass847_0 = value;
			this.method_0(Class10.propertyChangedEventArgs_2);
		}
	}

	public int FailedJumpCount
	{
		[CompilerGenerated]
		get
		{
			return this.int_2;
		}
		[CompilerGenerated]
		private set
		{
			if (this.int_2 == value)
			{
				return;
			}
			this.int_2 = value;
			this.method_0(Class10.propertyChangedEventArgs_19);
		}
	}

	public int method_3()
	{
		MenuItem menuItem;
		return (int)(base.C.Hero.MenuItems.TryGetValue("ammunition_ggportal_quarantine-zone-cpu", out menuItem) ? menuItem.CounterValue : 0.0);
	}

	public GClass836(GClass824 gclass824_1)
	{
		Class13.igxcIukzfpare();
		base..ctor(gclass824_1, TargetMap.GG_QZ);
		this.Behavior = new GClass847(gclass824_1, this);
	}

	public override MapProfile UpdateProfile(BotProfile botProfile_1)
	{
		if (botProfile_1 == null)
		{
			return null;
		}
		List<MapProfile> maps = botProfile_1.Maps;
		if (maps == null)
		{
			return null;
		}
		return maps.FirstOrDefault(new Func<MapProfile, bool>(GClass836.<>c.<>c_0.QajoOpvlseN));
	}

	public override int UpdatePriority()
	{
		MapProfile mapProfile = base.MapProfile;
		if (mapProfile != null)
		{
			int qz_GroupSize = mapProfile.QZ_GroupSize;
		}
		int num = this.method_3();
		if ((base.C.Hero.IsInitialized || base.C.Hero.LastStatUpdate.smethod_0(3600000)) && (num == 0 || base.C.Hero.Group.Members.Count < 2))
		{
			return int.MinValue;
		}
		return base.UpdatePriority();
	}

	protected override void OnBind()
	{
		base.OnBind();
		base.C.Game.LogMessage += this.method_4;
	}

	protected override void OnUnbind()
	{
		base.OnUnbind();
		base.C.Game.LogMessage -= this.method_4;
	}

	private void method_4(GameManager gameManager_0, GClass269 gclass269_0)
	{
		if (gclass269_0.string_0 == "0|A|STM|jumpgate_failed_no_key_activated" && this.method_3() > 0)
		{
			base.C.Server.method_14("ammunition_ggportal_quarantine-zone-cpu", false, false);
			return;
		}
	}

	public override GClass837 GetBehavior()
	{
		if (base.C.Map.MapId == 229)
		{
			return this.Behavior;
		}
		return base.GetBehavior();
	}

	public override void ClearStats()
	{
		base.ClearStats();
		this.FailedJumpCount = 0;
	}

	public override bool TrySwitchMap(out int int_3)
	{
		if (!base.C.IsStopping)
		{
			if (base.State == ModuleState.Started)
			{
				int_3 = MapUtils.smethod_0(base.C.MapProfile.TargetMap.GetName(), base.C.Hero.FactionId);
				return int_3 != base.C.Map.MapId;
			}
		}
		int_3 = MapUtils.smethod_10(1, base.C.Hero.FactionId);
		return true;
	}

	public override void HandleError(GClass826.GEnum10 genum10_0)
	{
		TimeSpan value = TimeSpan.FromMinutes(3.0);
		base.C.Timeout = new DateTime?(DateTime.Now.Add(value));
		base.C.method_13(true, false);
	}

	[CompilerGenerated]
	private GClass847 gclass847_0;

	[CompilerGenerated]
	private int int_2;
}
