using System;

namespace Domain
{
	public interface ISoftDeletable
	{
		bool IsDeleted { get; }
		DateTimeOffset? DeletedOn { get; }
		string DeletedBy { get; }
	}
}
