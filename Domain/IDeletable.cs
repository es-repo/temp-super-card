﻿using System;

namespace Domain
{
	public interface IDeletable
	{
		bool IsDeleted { get; set; }
		DateTimeOffset DeletedOn { get; }
		string DeletedBy { get; }
	}
}
