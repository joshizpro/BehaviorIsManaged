// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'JobExperienceMultiUpdateMessage.xml' the '27/06/2012 15:55:03'
using System;
using BiM.Core.IO;
using System.Collections.Generic;
using System.Linq;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class JobExperienceMultiUpdateMessage : NetworkMessage
	{
		public const uint Id = 5809;
		public override uint MessageId
		{
			get
			{
				return 5809;
			}
		}
		
		public IEnumerable<Types.JobExperience> experiencesUpdate;
		
		public JobExperienceMultiUpdateMessage()
		{
		}
		
		public JobExperienceMultiUpdateMessage(IEnumerable<Types.JobExperience> experiencesUpdate)
		{
			this.experiencesUpdate = experiencesUpdate;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)experiencesUpdate.Count());
			foreach (var entry in experiencesUpdate)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			experiencesUpdate = new Types.JobExperience[limit];
			for (int i = 0; i < limit; i++)
			{
				(experiencesUpdate as Types.JobExperience[])[i] = new Types.JobExperience();
				(experiencesUpdate as Types.JobExperience[])[i].Deserialize(reader);
			}
		}
	}
}