using System;

namespace SuperCard.Domain
{
	public interface IAuditable
	{
		DateTimeOffset CreatedOn { get; }
		string CreatedBy { get; }
		DateTimeOffset? UpdatedOn { get; }
		string UpdatedBy { get; }
	}
}
