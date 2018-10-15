using System;

namespace SuperCard.Domain
{
	public interface ISoftDeletable
	{
		bool IsDeleted { get; }
		DateTimeOffset? DeletedOn { get; }
		string DeletedBy { get; }
	}
}
