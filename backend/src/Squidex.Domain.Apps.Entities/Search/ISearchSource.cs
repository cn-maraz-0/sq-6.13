﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

namespace Squidex.Domain.Apps.Entities.Search
{
    public interface ISearchSource
    {
        Task<SearchResults> SearchAsync(string query, Context context,
            CancellationToken ct);
    }
}
