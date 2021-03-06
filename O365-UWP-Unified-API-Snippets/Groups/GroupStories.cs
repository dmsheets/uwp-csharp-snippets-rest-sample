﻿// Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license. See full license at the bottom of this file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;


namespace O365_UWP_Unified_API_Snippets
{
    class GroupStories
    {

        private static readonly string STORY_DATA_IDENTIFIER = Guid.NewGuid().ToString();

        public static async Task<bool> TryGetGroupsAsync()
        {
            var groups = await GroupSnippets.GetGroupsAsync();
            return groups != null;
        }

        public static async Task<bool> TryGetGroupAsync()
        {
            var groups = await GroupSnippets.GetGroupsAsync();
            var groupId = groups[0];
            var groupName = await GroupSnippets.GetGroupAsync(groupId);
            return groupName != null;
        }

        public static async Task<bool> TryGetGroupMembersAsync()
        {
            // Get all groups, then pass the first group id from the list.
            var groups = await GroupSnippets.GetGroupsAsync();
            var groupId = groups[0];
            var members = await GroupSnippets.GetGroupMembersAsync(groupId);
            return members != null;
        }

        public static async Task<bool> TryGetGroupOwnersAsync()
        {
            // Get all groups, then pass the first group id from the list.
            var groups = await GroupSnippets.GetGroupsAsync();
            var groupId = groups[0];
            var members = await GroupSnippets.GetGroupOwnersAsync(groupId);
            return members != null;
        }

        public static async Task<bool> TryCreateGroupAsync()
        {
            string createdGroup = await GroupSnippets.CreateGroupAsync(STORY_DATA_IDENTIFIER);
            return createdGroup != null;
        }

        public static async Task<bool> TryUpdateGroupAsync()
        {
            // Create an group first, then update it.
            string createdGroup = await GroupSnippets.CreateGroupAsync(STORY_DATA_IDENTIFIER);
            return await GroupSnippets.UpdateGroupAsync(createdGroup);
        }

        public static async Task<bool> TryDeleteGroupAsync()
        {
            // Create a group first, then delete it.
            string createdGroup = await GroupSnippets.CreateGroupAsync(STORY_DATA_IDENTIFIER);
            return await GroupSnippets.DeleteGroupAsync(createdGroup);
        }

    }
}



//********************************************************* 
// 
//O365-UWP-Microsoft-Graph-Snippets, https://github.com/OfficeDev/O365-UWP-Microsoft-Graph-Snippets
//
//Copyright (c) Microsoft Corporation
//All rights reserved. 
//
// MIT License:
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// ""Software""), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:

// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 
//********************************************************* 