﻿using Xunit;

public partial class WithScalpelConstantTests
{
    [Fact]
    public void ApprovalTestsIsRemoved()
    {
        Assert.DoesNotContain(result.Assembly.GetReferencedAssemblies(), x => x.Name == "ApprovalTests");
    }

    [Fact]
    public void ApprovalUtilitiesIsRemoved()
    {
        Assert.DoesNotContain(result.Assembly.GetReferencedAssemblies(), x => x.Name == "ApprovalUtilities");
    }

    [Fact]
    public void WithApprovalTestsUseReporterRemoved()
    {
        Assert.DoesNotContain(result.Assembly.GetTypes(), x => x.Name == "WithApprovalTestsUseReporterAttribute");
    }
}