using System;

namespace Domain
{
	public interface IAuditable
	{
		DateTimeOffset CreatedOn { get; }
		string CreatedBy { get; }
		DateTimeOffset? UpdatedOn { get; }
		string UpdatedBy { get; }
	}
}
