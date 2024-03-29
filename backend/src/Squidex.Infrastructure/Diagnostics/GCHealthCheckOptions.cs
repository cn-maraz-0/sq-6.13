﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

namespace Squidex.Infrastructure.Diagnostics
{
    public sealed class GCHealthCheckOptions
    {
        public long ThresholdInMB { get; set; } = 8192;
    }
}
