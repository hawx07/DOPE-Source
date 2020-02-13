﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Packets.Static;

namespace DarkorbitAPI.Structures
{
	public class Hero : Ship
	{
		public GameManager Game
		{
			[CompilerGenerated]
			get
			{
				return this.<Game>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Game>k__BackingField, value))
				{
					return;
				}
				this.<Game>k__BackingField = value;
				this.method_11(Class5.Game);
			}
		}

		public GroupManager Group
		{
			[CompilerGenerated]
			get
			{
				return this.<Group>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Group>k__BackingField, value))
				{
					return;
				}
				this.<Group>k__BackingField = value;
				this.method_11(Class5.Group);
			}
		}

		public HeroPet Pet
		{
			[CompilerGenerated]
			get
			{
				return this.<Pet>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Pet>k__BackingField, value))
				{
					return;
				}
				this.<Pet>k__BackingField = value;
				this.method_11(Class5.Pet);
			}
		}

		static Hero()
		{
			Class13.igxcIukzfpare();
			Hero.Formations = new Dictionary<GEnum4, string>();
			foreach (object obj in Enum.GetValues(typeof(GEnum4)))
			{
				GEnum4 genum = (GEnum4)obj;
				Hero.Formations[genum] = genum.smethod_0();
			}
		}

		public GEnum4 Formation
		{
			get
			{
				GEnum4 result = GEnum4.Default;
				foreach (KeyValuePair<GEnum4, string> keyValuePair in Hero.Formations)
				{
					if (this.method_30(keyValuePair.Value))
					{
						return keyValuePair.Key;
					}
				}
				return result;
			}
		}

		public double Credits
		{
			[CompilerGenerated]
			get
			{
				return this.<Credits>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Credits>k__BackingField == value)
				{
					return;
				}
				this.<Credits>k__BackingField = value;
				this.method_11(Class5.Credits);
			}
		}

		public double BootyKeys
		{
			[CompilerGenerated]
			get
			{
				return this.<BootyKeys>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<BootyKeys>k__BackingField == value)
				{
					return;
				}
				this.<BootyKeys>k__BackingField = value;
				this.method_11(Class5.propertyChangedEventArgs_4);
			}
		}

		internal void method_12(GClass235 gclass235_0)
		{
			if (Enum.IsDefined(typeof(CooldownType), (int)gclass235_0.gclass178_0.uint_0))
			{
				this.ItemCooldown.method_1((CooldownType)gclass235_0.gclass178_0.uint_0, gclass235_0.double_0);
			}
		}

		internal void method_13(GClass276 gclass276_0)
		{
			MenuItem menuItem;
			if (!this.MenuItems.TryGetValue(gclass276_0.Id, out menuItem))
			{
				menuItem = (this.MenuItems[gclass276_0.Id] = new MenuItem());
			}
			menuItem.method_0(gclass276_0);
		}

		internal void method_14(GClass277 gclass277_0)
		{
			MenuItem menuItem;
			if (!this.MenuItems.TryGetValue(gclass277_0.Id, out menuItem))
			{
				return;
			}
			menuItem.method_1(gclass277_0);
		}

		internal void method_15(GClass243 gclass243_0)
		{
			string string_ = gclass243_0.string_0;
			if (string_ != null)
			{
				if (string_ == "currency_credits")
				{
					this.Credits = gclass243_0.double_2;
					return;
				}
				if (string_ == "currency_uridium")
				{
					this.Uridium = gclass243_0.double_2;
					return;
				}
				if (string_ == "currency_honour")
				{
					this.Honor = gclass243_0.double_2;
					return;
				}
				if (string_ == "currency_experience")
				{
					this.Experience = gclass243_0.double_2;
					return;
				}
				if (string_ == "currency_jackpotmoney")
				{
					this.Jackpot = gclass243_0.double_2;
					return;
				}
				if (string_.StartsWith("ammunition_"))
				{
					this.method_21(string_, gclass243_0.double_2);
					return;
				}
				string text = string_;
				if (text.StartsWith("resource_"))
				{
					this.method_23(text, (double)((int)gclass243_0.double_2));
					return;
				}
				string text2 = string_;
				if (text2.StartsWith("equipment_"))
				{
					this.method_22(text2, (int)gclass243_0.double_2);
				}
			}
		}

		public bool method_16(string string_0)
		{
			MenuItem menuItem;
			return this.MenuItems.TryGetValue(string_0, out menuItem) && menuItem.Available;
		}

		public bool method_17(string string_0, out MenuItem menuItem_0)
		{
			DateTimeOffset now = DateTimeOffset.Now;
			return this.MenuItems.TryGetValue(string_0, out menuItem_0) && menuItem_0.Available && menuItem_0.Activatable && now >= menuItem_0.NextUsable;
		}

		public bool method_18(string string_0, out MenuItem menuItem_0, bool bool_0 = false)
		{
			if (this.method_17(string_0, out menuItem_0))
			{
				this.Game.Connection.Server.method_14(string_0, bool_0, false);
				return true;
			}
			return false;
		}

		public bool method_19(string string_0)
		{
			MenuItem menuItem;
			return this.MenuItems.TryGetValue(string_0, out menuItem) && menuItem.Selected;
		}

		public double Uridium
		{
			[CompilerGenerated]
			get
			{
				return this.<Uridium>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Uridium>k__BackingField == value)
				{
					return;
				}
				this.<Uridium>k__BackingField = value;
				this.method_11(Class5.Uridium);
			}
		}

		public double Jackpot
		{
			[CompilerGenerated]
			get
			{
				return this.<Jackpot>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Jackpot>k__BackingField == value)
				{
					return;
				}
				this.<Jackpot>k__BackingField = value;
				this.method_11(Class5.propertyChangedEventArgs_46);
			}
		}

		public bool Premium
		{
			[CompilerGenerated]
			get
			{
				return this.<Premium>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Premium>k__BackingField == value)
				{
					return;
				}
				this.<Premium>k__BackingField = value;
				this.method_11(Class5.propertyChangedEventArgs_76);
			}
		}

		public int Level
		{
			[CompilerGenerated]
			get
			{
				return this.<Level>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Level>k__BackingField == value)
				{
					return;
				}
				this.<Level>k__BackingField = value;
				this.method_11(Class5.propertyChangedEventArgs_63);
			}
		}

		public double Honor
		{
			[CompilerGenerated]
			get
			{
				return this.<Honor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Honor>k__BackingField == value)
				{
					return;
				}
				this.<Honor>k__BackingField = value;
				this.method_11(Class5.Honor);
			}
		}

		public double Experience
		{
			[CompilerGenerated]
			get
			{
				return this.<Experience>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Experience>k__BackingField == value)
				{
					return;
				}
				this.<Experience>k__BackingField = value;
				this.method_11(Class5.Experience);
			}
		}

		public int Speed
		{
			[CompilerGenerated]
			get
			{
				return this.<Speed>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Speed>k__BackingField == value)
				{
					return;
				}
				this.<Speed>k__BackingField = value;
				this.method_11(Class5.propertyChangedEventArgs_102);
			}
		}

		public bool IsInitialized
		{
			[CompilerGenerated]
			get
			{
				return this.<IsInitialized>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsInitialized>k__BackingField == value)
				{
					return;
				}
				this.<IsInitialized>k__BackingField = value;
				this.method_11(Class5.propertyChangedEventArgs_42);
			}
		}

		public int Config
		{
			[CompilerGenerated]
			get
			{
				return this.<Config>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Config>k__BackingField == value)
				{
					return;
				}
				this.<Config>k__BackingField = value;
				this.method_20();
				this.method_11(Class5.Config);
			}
		}

		public DateTimeOffset LastConfigSwitched
		{
			[CompilerGenerated]
			get
			{
				return this.<LastConfigSwitched>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (DateTimeOffset.Equals(this.<LastConfigSwitched>k__BackingField, value))
				{
					return;
				}
				this.<LastConfigSwitched>k__BackingField = value;
				this.method_11(Class5.propertyChangedEventArgs_50);
			}
		}

		private void method_20()
		{
			this.LastConfigSwitched = DateTimeOffset.Now;
		}

		public Vector2? MovementDestination
		{
			get
			{
				return base.TargetPosition;
			}
		}

		public bool InSafeZone
		{
			[CompilerGenerated]
			get
			{
				return this.<InSafeZone>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InSafeZone>k__BackingField == value)
				{
					return;
				}
				this.<InSafeZone>k__BackingField = value;
				this.method_11(Class5.propertyChangedEventArgs_32);
			}
		}

		public int CargoCapacity
		{
			[CompilerGenerated]
			get
			{
				return this.<CargoCapacity>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CargoCapacity>k__BackingField == value)
				{
					return;
				}
				this.<CargoCapacity>k__BackingField = value;
				this.method_11(Class5.propertyChangedEventArgs_7);
				this.method_11(Class5.propertyChangedEventArgs_6);
			}
		}

		public int FreeCargo
		{
			[CompilerGenerated]
			get
			{
				return this.<FreeCargo>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				if (this.<FreeCargo>k__BackingField == value)
				{
					return;
				}
				this.<FreeCargo>k__BackingField = value;
				this.method_11(Class5.propertyChangedEventArgs_7);
				this.method_11(Class5.propertyChangedEventArgs_21);
			}
		}

		public string CargoDisplay
		{
			get
			{
				return string.Format("{0}/{1}", this.CargoCapacity - this.FreeCargo, this.CargoCapacity);
			}
		}

		public ConcurrentDictionary<string, double> Ammo
		{
			[CompilerGenerated]
			get
			{
				return this.<Ammo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Ammo>k__BackingField = value;
				this.method_11(Class5.AmmoX1);
				this.method_11(Class5.AmmoX2);
				this.method_11(Class5.AmmoX3);
				this.method_11(Class5.propertyChangedEventArgs_1);
				this.method_11(Class5.AmmoR1);
				this.method_11(Class5.AmmoR2);
				this.method_11(Class5.AmmoR3);
				this.method_11(Class5.AmmoR4);
				this.method_11(Class5.AmmoHS1);
				this.method_11(Class5.propertyChangedEventArgs_0);
			}
		}

		public ConcurrentDictionary<string, int> Equipment
		{
			[CompilerGenerated]
			get
			{
				return this.<Equipment>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Equipment>k__BackingField = value;
				this.method_11(Class5.propertyChangedEventArgs_18);
			}
		}

		public ConcurrentDictionary<string, double> Resources
		{
			[CompilerGenerated]
			get
			{
				return this.<Resources>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Resources>k__BackingField = value;
				this.method_11(Class5.propertyChangedEventArgs_87);
				this.method_11(Class5.propertyChangedEventArgs_83);
				this.method_11(Class5.propertyChangedEventArgs_89);
				this.method_11(Class5.propertyChangedEventArgs_86);
				this.method_11(Class5.propertyChangedEventArgs_82);
				this.method_11(Class5.propertyChangedEventArgs_85);
				this.method_11(Class5.propertyChangedEventArgs_88);
				this.method_11(Class5.propertyChangedEventArgs_90);
				this.method_11(Class5.propertyChangedEventArgs_84);
				this.method_11(Class5.Resources);
			}
		}

		public Hero(GameManager gameManager_0)
		{
			Class13.igxcIukzfpare();
			this.ItemCooldown = new CooldownTracker<CooldownType>();
			this.MenuItems = new ConcurrentDictionary<string, MenuItem>();
			this.<Ammo>k__BackingField = new ConcurrentDictionary<string, double>();
			this.<Equipment>k__BackingField = new ConcurrentDictionary<string, int>();
			this.<Resources>k__BackingField = new ConcurrentDictionary<string, double>();
			base..ctor(0, 0);
			this.IsInitialized = false;
			this.Pet = new HeroPet();
			this.Group = new GroupManager(this);
			this.Game = gameManager_0;
		}

		public override void Init(GClass219 gclass219_0)
		{
			this.Clear();
			this.Equipment.Clear();
			base.Init(gclass219_0);
			this.Speed = gclass219_0.int_4;
			this.Premium = gclass219_0.bool_2;
			this.Jackpot = gclass219_0.double_0;
			this.Credits = gclass219_0.Credits;
			this.Uridium = gclass219_0.Uridium;
			this.Experience = gclass219_0.Experience;
			this.Honor = gclass219_0.Honor;
			this.Game.Map.MapId = gclass219_0.MapId;
			this.Game.NextMapId = 0;
			this.Level = gclass219_0.int_16;
			this.CargoCapacity = gclass219_0.int_13;
			this.IsInitialized = true;
		}

		public void Clear()
		{
			this.IsInitialized = false;
			this.Pet.Clear();
			this.Modifiers.Clear();
			this.InSafeZone = false;
			base.LastAttacked = (base.LastTookDamage = (base.LastTookDamageEnemy = DateTimeOffset.MinValue));
		}

		public double NtagPxqlwQ(string string_0)
		{
			double result;
			if (this.Ammo.TryGetValue(string_0, out result))
			{
				return result;
			}
			return 0.0;
		}

		public void method_21(string string_0, double double_0)
		{
			this.Ammo[string_0] = double_0;
			this.Ammo = this.Ammo;
		}

		public void method_22(string string_0, int int_0)
		{
			this.Equipment[string_0] = int_0;
			this.Equipment = this.Equipment;
		}

		public void method_23(string string_0, double double_0)
		{
			this.Resources[string_0] = double_0;
			this.Resources = this.Resources;
		}

		public double method_24(ResourceType resourceType_0)
		{
			double result;
			if (this.Resources.TryGetValue("resource_" + resourceType_0.ToString().ToLower(), out result))
			{
				return result;
			}
			return 0.0;
		}

		public int method_25(ResourceType resourceType_0)
		{
			int result = 0;
			switch (resourceType_0)
			{
			case ResourceType.PROMETID:
				result = Math.Min((int)(this.ResourcePrometium / 20.0), (int)(this.ResourceEndurium / 10.0));
				break;
			case ResourceType.DURANIUM:
				result = Math.Min((int)(this.ResourceTerbium / 20.0), (int)(this.ResourceEndurium / 10.0));
				break;
			case ResourceType.PROMERIUM:
				result = Math.Min((int)this.ResourceXenomit, Math.Min((int)(this.ResourceDuranium / 10.0), (int)(this.ResourcePrometid / 10.0)));
				break;
			}
			return result;
		}

		public bool method_26(MapUtils.PortalEdge portalEdge_0, Gate gate_0 = null)
		{
			return (gate_0 != null && gate_0.FactionId == base.FactionId) || (portalEdge_0 != null && (!portalEdge_0.SelfFactionOnly || portalEdge_0.FactionId == base.FactionId || portalEdge_0.FactionId == 0));
		}

		public bool method_27(MapUtils.PortalEdge portalEdge_0, Gate gate_0 = null)
		{
			return (gate_0 != null && gate_0.FactionId == base.FactionId) || (portalEdge_0 != null && this.method_26(portalEdge_0, null) && !MapUtils.smethod_3(portalEdge_0.FromMapId).StartsWith("4-") && portalEdge_0.FactionId != 0 && portalEdge_0.FactionId == base.FactionId);
		}

		public int method_28()
		{
			MenuItem menuItem;
			if (this.method_17("ability_zephyr_mmt", out menuItem))
			{
				return (int)menuItem.CounterValue * 5;
			}
			return 0;
		}

		public void method_29(GClass229 gclass229_0)
		{
			base.method_0(gclass229_0);
			this.InSafeZone = gclass229_0.bool_3;
		}

		public double AmmoX1
		{
			get
			{
				return this.NtagPxqlwQ("ammunition_laser_lcb-10");
			}
		}

		public double AmmoX2
		{
			get
			{
				return this.NtagPxqlwQ("ammunition_laser_mcb-25");
			}
		}

		public double AmmoX3
		{
			get
			{
				return this.NtagPxqlwQ("ammunition_laser_mcb-50");
			}
		}

		public double AmmoX4
		{
			get
			{
				return this.NtagPxqlwQ("ammunition_laser_ucb-100");
			}
		}

		public double AmmoR1
		{
			get
			{
				return this.NtagPxqlwQ("ammunition_rocket_r-310");
			}
		}

		public double AmmoR2
		{
			get
			{
				return this.NtagPxqlwQ("ammunition_rocket_plt-2026");
			}
		}

		public double AmmoR3
		{
			get
			{
				return this.NtagPxqlwQ("ammunition_rocket_plt-2021");
			}
		}

		public double AmmoR4
		{
			get
			{
				return this.NtagPxqlwQ("ammunition_rocket_plt-3030");
			}
		}

		public double AmmoHS1
		{
			get
			{
				return this.NtagPxqlwQ("ammunition_rocketlauncher_eco-10");
			}
		}

		public double ResourcePrometium
		{
			get
			{
				return this.method_24(ResourceType.PROMETIUM);
			}
		}

		public double ResourceEndurium
		{
			get
			{
				return this.method_24(ResourceType.ENDURIUM);
			}
		}

		public double ResourceTerbium
		{
			get
			{
				return this.method_24(ResourceType.TERBIUM);
			}
		}

		public double ResourcePrometid
		{
			get
			{
				return this.method_24(ResourceType.PROMETID);
			}
		}

		public double ResourceDuranium
		{
			get
			{
				return this.method_24(ResourceType.DURANIUM);
			}
		}

		public double ResourcePromerium
		{
			get
			{
				return this.method_24(ResourceType.PROMERIUM);
			}
		}

		public double ResourceSeprom
		{
			get
			{
				return this.method_24(ResourceType.SEPROM);
			}
		}

		public double ResourceXenomit
		{
			get
			{
				return this.method_24(ResourceType.XENOMIT);
			}
		}

		public double ResourcePalladium
		{
			get
			{
				return this.method_24(ResourceType.PALLADIUM);
			}
		}

		[CompilerGenerated]
		private bool method_30(string string_0)
		{
			MenuItem menuItem;
			return this.MenuItems.TryGetValue(string_0, out menuItem) && menuItem.Selected;
		}

		public readonly CooldownTracker<CooldownType> ItemCooldown;

		public readonly ConcurrentDictionary<string, MenuItem> MenuItems;

		public static readonly Dictionary<GEnum4, string> Formations;
	}
}
