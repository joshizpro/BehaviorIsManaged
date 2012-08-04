// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PrismAlignmentBonusResultMessage.xml' the '27/06/2012 15:55:12'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class PrismAlignmentBonusResultMessage : NetworkMessage
	{
		public const uint Id = 5842;
		public override uint MessageId
		{
			get
			{
				return 5842;
			}
		}
		
		public Types.AlignmentBonusInformations alignmentBonus;
		
		public PrismAlignmentBonusResultMessage()
		{
		}
		
		public PrismAlignmentBonusResultMessage(Types.AlignmentBonusInformations alignmentBonus)
		{
			this.alignmentBonus = alignmentBonus;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			alignmentBonus.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			alignmentBonus = new Types.AlignmentBonusInformations();
			alignmentBonus.Deserialize(reader);
		}
	}
}