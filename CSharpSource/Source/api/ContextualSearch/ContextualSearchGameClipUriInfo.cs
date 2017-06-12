// Copyright (c) Microsoft Corporation
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// 
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Xbox.Services.ContextualSearch
{
    public class ContextualSearchGameClipUriInfo
    {

        public DateTimeOffset Expiration
        {
            get;
            private set;
        }

        public ContextualSearchGameClipUriType UriType
        {
            get;
            private set;
        }

        public ulong FileSize
        {
            get;
            private set;
        }

        public Uri Url
        {
            get;
            private set;
        }

    }
}