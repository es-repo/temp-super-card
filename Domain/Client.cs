namespace SuperCard.Domain
{
	// TODO: consider implement it as Entity and store the types in data base 
	public enum PostageType
	{
		RoyalMail1stClass
	}

	// TODO: consider implement it as Entity and store the types in data base 
	public enum ClientAcquirerType
	{
		Paysafe
	}

	public class Client : SoftDeletableAuditableEntity
	{
		public string Name { set; get; }

		public string Description { set; get; }

		public string Url { set; get; }

		public ClientAcquirerType AcquirerType { set; get; }

		public PostageType PostageType { set; get; }

		public bool IsActive { get; set; }

		public string WelcomeEmail { get; set; }
	}
}
