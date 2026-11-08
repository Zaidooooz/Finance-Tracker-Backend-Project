public string Name { get; set; }
	public string Currency { get; set; }
	public decimal StartAmount { get; set; }
	public bool IsArchived { get; set; }
	public DateTime CreatedAt { get; set; }

	public User User { get; set; }
