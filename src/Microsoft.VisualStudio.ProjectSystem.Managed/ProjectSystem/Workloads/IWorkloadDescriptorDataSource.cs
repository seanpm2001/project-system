﻿// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

namespace Microsoft.VisualStudio.ProjectSystem.Workloads
{
    /// <summary>
    /// Project value data source for instances of <see cref="WorkloadDescriptor"/>.
    /// </summary>
    [ProjectSystemContract(ProjectSystemContractScope.ConfiguredProject, ProjectSystemContractProvider.Private, Cardinality = ImportCardinality.ExactlyOne)]
    internal interface IWorkloadDescriptorDataSource : IProjectValueDataSource<ISet<WorkloadDescriptor>>
    {
    }
}
