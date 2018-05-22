using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

using Phone.DB.Entities;

namespace DataAcces
{
	class PhoneDbContext : DbContext
	{

		public DbSet<BaseEntity> Phones { get; set; }

	}
}
