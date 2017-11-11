using System;
using System.ComponentModel.DataAnnotations;

namespace Model.EF
{

    [MetadataTypeAttribute(typeof(Comment))]
    public partial class Comment
    {
        internal sealed class CommentMetadata
        {

        }
    }
}

