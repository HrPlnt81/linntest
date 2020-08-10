using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Identifier
	{
		public Int32 IdentifierId { get; set; }

		public Boolean IsCustom { get; set; }

		public Guid ImageId { get; set; }

		public String ImageUrl { get; set; }

		public String Tag { get; set; }

		public String Name { get; set; }
	} 
}