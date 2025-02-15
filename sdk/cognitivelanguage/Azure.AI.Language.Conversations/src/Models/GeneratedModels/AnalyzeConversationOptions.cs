// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.Language.Conversations
{
    /// <summary> The input ConversationItem and its optional parameters. </summary>
    public partial class AnalyzeConversationOptions
    {
        /// <summary> Initializes a new instance of AnalyzeConversationOptions. </summary>
        /// <param name="conversationItem"> The abstract base for a user input formatted conversation (e.g., Text, Transcript). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationItem"/> is null. </exception>
        public AnalyzeConversationOptions(ConversationItemBase conversationItem)
        {
            if (conversationItem == null)
            {
                throw new ArgumentNullException(nameof(conversationItem));
            }

            ConversationItem = conversationItem;
        }

        /// <summary> The abstract base for a user input formatted conversation (e.g., Text, Transcript). </summary>
        public ConversationItemBase ConversationItem { get; }
    }
}
