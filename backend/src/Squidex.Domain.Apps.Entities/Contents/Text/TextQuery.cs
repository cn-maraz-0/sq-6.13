﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using Squidex.Infrastructure;

#pragma warning disable SA1313 // Parameter names should begin with lower-case letter

namespace Squidex.Domain.Apps.Entities.Contents.Text
{
    public sealed record TextQuery(string Text, int Take)
    {
        public IReadOnlyList<DomainId>? RequiredSchemaIds { get; init; }

        public DomainId? PreferredSchemaId { get; init; }
    }
}
