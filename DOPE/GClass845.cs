﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;

public class GClass845 : GClass838
{
	private GClass831 Module { get; }

	public GClass845(GClass824 gclass824_1, GClass831 gclass831_1)
	{
		Class13.igxcIukzfpare();
		base..ctor(gclass824_1);
		this.Module = gclass831_1;
	}

	public override bool vmethod_19(GClass826 gclass826_0)
	{
		return gclass826_0 == this.Module;
	}

	public override bool vmethod_8(NpcShip npcShip_0)
	{
		NpcUtils.NpcType type = npcShip_0.Type;
		NpcUtils.NpcClass npcClass = (type != null) ? type.Class : null;
		return (npcClass == NpcUtils.N_Cubikon || Vector2.Distance(this.Module.BestSpawn, npcShip_0.Position) < 800f) && (npcClass != NpcUtils.N_Protegit || !this.method_23()) && base.vmethod_8(npcShip_0);
	}

	public override bool vmethod_13(Collectible collectible_0)
	{
		return Vector2.Distance(this.Module.BestSpawn, collectible_0.Position) < 800f && base.vmethod_13(collectible_0);
	}

	protected override IEnumerable<Vector2> vmethod_23()
	{
		IEnumerator<Vector2> enumerator = this.method_25().GetEnumerator();
		for (;;)
		{
			try
			{
				IL_52:
				if (!enumerator.MoveNext())
				{
					break;
				}
				goto IL_88;
				IL_4A:
				goto IL_52;
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			break;
			IL_88:
			Vector2 vector = enumerator.Current;
			yield return vector;
			goto IL_4A;
		}
		enumerator = null;
		yield return this.Module.BestSpawn;
		yield break;
		yield break;
	}

	[CompilerGenerated]
	public bool method_23()
	{
		return this.bool_3;
	}

	[CompilerGenerated]
	public void method_24(bool bool_4)
	{
		this.bool_3 = bool_4;
	}

	public override void Update()
	{
		base.Update();
		DateTimeOffset left = DateTimeOffset.Now.AddSeconds(30.0);
		this.method_24(left >= this.Module.BestSpawnTime);
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable<Vector2> method_25()
	{
		return base.vmethod_23();
	}

	[CompilerGenerated]
	private readonly GClass831 gclass831_0;

	[CompilerGenerated]
	private bool bool_3;
}
