using System;

namespace Domain
{
	public interface ISoftDeletable
	{
		bool IsDeleted { get; set; }
		DateTimeOffset DeletedOn { get; }
		string DeletedBy { get; }
	}
}
