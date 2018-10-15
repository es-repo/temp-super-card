using System;

namespace Domain
{
	public abstract class SoftDeletableAuditableEntity : AuditableEntity, ISoftDeletable
	{
		public bool IsDeleted => DeletedOn.HasValue;

		public DateTimeOffset? DeletedOn { get; set; }

		public string DeletedBy { get; set; }
	}
}
