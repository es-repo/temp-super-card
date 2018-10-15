using System;

namespace Domain
{
	public abstract class AuditableEntity : Entity, IAuditable
	{
		public DateTimeOffset CreatedOn { get; set; }

		public string CreatedBy { get; set; }

		public DateTimeOffset UpdatedOn { get; set; }

		public string UpdatedBy { get; set; }
	}
}
