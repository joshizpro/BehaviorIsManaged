// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ObjectEffectLadder.xml' the '27/06/2012 15:55:16'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Types
{
	public class ObjectEffectLadder : ObjectEffectCreature
	{
		public const uint Id = 81;
		public override short TypeId
		{
			get
			{
				return 81;
			}
		}
		
		public int monsterCount;
		
		public ObjectEffectLadder()
		{
		}
		
		public ObjectEffectLadder(short actionId, short monsterFamilyId, int monsterCount)
			 : base(actionId, monsterFamilyId)
		{
			this.monsterCount = monsterCount;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(monsterCount);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			monsterCount = reader.ReadInt();
			if ( monsterCount < 0 )
			{
				throw new Exception("Forbidden value on monsterCount = " + monsterCount + ", it doesn't respect the following condition : monsterCount < 0");
			}
		}
	}
}