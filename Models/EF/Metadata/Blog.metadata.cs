using System;
using System.ComponentModel.DataAnnotations;

namespace Model.EF
{

    [MetadataTypeAttribute(typeof(Blog))]
    public partial class Blog
    {
        internal sealed class BlogMetadata
        {

        }
    }
}
