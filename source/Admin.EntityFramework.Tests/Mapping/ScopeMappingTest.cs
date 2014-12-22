using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Thinktecture.IdentityServer.v3.Admin.EntityFramework;
using Thinktecture.IdentityServer.v3.Admin.WebApi.Models.Storage;
using Xunit;

namespace Admin.EntityFramework.Tests.Mapping
{
    public class ScopeMappingTest
    {
        [Fact]
        public void Maps_empty_storage_scope_to_entity_framework_scope()
        {
            var storageScope = new Scope();
            var efScope = storageScope.ToEntity();

            efScope.ClaimsRule.Should().BeNull();
            efScope.Description.Should().BeNull();
            efScope.DisplayName.Should().BeNull();
            efScope.Emphasize.Should().BeFalse();
            efScope.Enabled.Should().BeFalse();
            efScope.Id.Should().Be(0);
            efScope.IncludeAllClaimsForUser.Should().BeFalse();
            efScope.Name.Should().BeNull();
            efScope.Required.Should().BeFalse();
            efScope.ScopeClaims.Should().BeNullOrEmpty();
            efScope.ShowInDiscoveryDocument.Should().BeFalse();
            efScope.Type.Should().Be(0);
        }

        [Fact]
        public void Maps_empty_entity_framework_scope_to_storage()
        {
            var efScope = new Thinktecture.IdentityServer.Core.EntityFramework.Entities.Scope();
            var storageScope = efScope.ToModel();

            storageScope.ClaimsRule.Should().BeNull();
            storageScope.Description.Should().BeNull();
            storageScope.DisplayName.Should().BeNull();
            storageScope.Emphasize.Should().BeFalse();
            storageScope.Enabled.Should().BeFalse();
            storageScope.Id.Should().Be(0);
            storageScope.IncludeAllClaimsForUser.Should().BeFalse();
            storageScope.Name.Should().BeNull();
            storageScope.Required.Should().BeFalse();
            storageScope.ScopeClaims.Should().BeNullOrEmpty();
            storageScope.ShowInDiscoveryDocument.Should().BeFalse();
            storageScope.Type.Should().Be(0);
        }

        [Fact]
        public void Maps_storage_scope_to_entity_framework_scope()
        {
            var storageScope = new Scope()
            {
                Id = 1,
                Name = "Name",
                DisplayName = "DisplayName",
                ClaimsRule = "ClaimsRule",
                Description = "Description",
                Emphasize = true,
                Enabled = true,
                IncludeAllClaimsForUser = true,
                Required = true,
                ScopeClaims = new List<ScopeClaim>()
                {
                    new ScopeClaim()
                    {
                        AlwaysIncludeInIdToken = true,
                        Description = "Description",
                        Id = 2,
                        Name = "Name"
                    }
                },
                ShowInDiscoveryDocument = true,
                Type = 1
            };

            var efScope = storageScope.ToEntity();

            efScope.Id.Should().Be(1);
            efScope.Name.Should().Be("Name");
            efScope.DisplayName.Should().Be("DisplayName");
            efScope.ClaimsRule.Should().Be("ClaimsRule");
            efScope.Description.Should().Be("Description");
            efScope.Emphasize.Should().BeTrue();
            efScope.Enabled.Should().BeTrue();
            efScope.IncludeAllClaimsForUser.Should().BeTrue();
            efScope.Required.Should().BeTrue();
            efScope.ScopeClaims.Count.Should().Be(1);
            efScope.ScopeClaims.First().AlwaysIncludeInIdToken.Should().BeTrue();
            efScope.ScopeClaims.First().Description.Should().Be("Description");
            efScope.ScopeClaims.First().Id.Should().Be(2);
            efScope.ScopeClaims.First().Name.Should().Be("Name");
            efScope.ShowInDiscoveryDocument.Should().BeTrue();
            efScope.Type.Should().Be(1);
        }

        [Fact]
        public void Maps_entity_framework_scope_to_storage_scope()
        {
            var efScope = new Thinktecture.IdentityServer.Core.EntityFramework.Entities.Scope()
            {
                Id = 1,
                Name = "Name",
                DisplayName = "DisplayName",
                ClaimsRule = "ClaimsRule",
                Description = "Description",
                Emphasize = true,
                Enabled = true,
                IncludeAllClaimsForUser = true,
                Required = true,
                ScopeClaims  = new List<Thinktecture.IdentityServer.Core.EntityFramework.Entities.ScopeClaim>()
                {
                    new Thinktecture.IdentityServer.Core.EntityFramework.Entities.ScopeClaim()
                    {
                        AlwaysIncludeInIdToken = true,
                        Description = "Description",
                        Id = 2,
                        Name = "Name"
                    }
                },
                ShowInDiscoveryDocument = true,
                Type = 1
            };

            var storageScope = efScope.ToModel();

            storageScope.Id.Should().Be(1);
            storageScope.Name.Should().Be("Name");
            storageScope.DisplayName.Should().Be("DisplayName");
            storageScope.ClaimsRule.Should().Be("ClaimsRule");
            storageScope.Description.Should().Be("Description");
            storageScope.Emphasize.Should().BeTrue();
            storageScope.Enabled.Should().BeTrue();
            storageScope.IncludeAllClaimsForUser.Should().BeTrue();
            storageScope.Required.Should().BeTrue();
            storageScope.ScopeClaims.Count.Should().Be(1);
            storageScope.ScopeClaims.First().AlwaysIncludeInIdToken.Should().BeTrue();
            storageScope.ScopeClaims.First().Description.Should().Be("Description");
            storageScope.ScopeClaims.First().Id.Should().Be(2);
            storageScope.ScopeClaims.First().Name.Should().Be("Name");
            storageScope.ShowInDiscoveryDocument.Should().BeTrue();
            storageScope.Type.Should().Be(1);
        }
    }
}