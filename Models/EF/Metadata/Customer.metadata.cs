using System;
using System.ComponentModel.DataAnnotations;

namespace Model.EF
{

    [MetadataTypeAttribute(typeof(Customer))]
    public partial class Customer
    {
        internal sealed class CustomerMetadata
        {

        }
    }
}

