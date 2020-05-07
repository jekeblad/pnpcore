﻿namespace PnP.Core.Model.Teams
{
    public interface ITeamChatMessageContent : IComplexType
    {
        /// <summary>
        /// The content of the item.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// The type of the content. Possible values are text and html.
        /// </summary>
        public ChatMessageContentType ContentType { get; set; }
    }
}
