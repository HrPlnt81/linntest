using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ExtendedProperty
	{
        /// <summary>
        /// Record row ID 
        /// </summary>
		public Guid RowId { get; set; }

        /// <summary>
        /// Extended property name 
        /// </summary>
		public String Name { get; set; }

        /// <summary>
        /// Extended property value 
        /// </summary>
		public String Value { get; set; }

        /// <summary>
        /// Extended property type 
        /// </summary>
		public String Type { get; set; }
	} 
}