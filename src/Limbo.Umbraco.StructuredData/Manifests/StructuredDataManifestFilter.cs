﻿using System.Collections.Generic;
using Skybrud.Essentials.Strings.Extensions;
using Umbraco.Cms.Core.Manifest;

namespace Limbo.Umbraco.StructuredData.Manifests {

    /// <inheritdoc />
    public class StructuredDataManifestFilter : IManifestFilter {

        /// <inheritdoc />
        public void Filter(List<PackageManifest> manifests) {
            manifests.Add(new PackageManifest {
                PackageName = StructuredDataPackage.Alias.ToKebabCase(),
                BundleOptions = BundleOptions.Independent,
                Scripts = new[] {
                    $"/App_Plugins/{StructuredDataPackage.Alias}/Scripts/Controllers/StructuredDataEditor.js",
                    $"/App_Plugins/{StructuredDataPackage.Alias}/Scripts/Controllers/StructuredDataOverlay.js"
                },
                Stylesheets = new[] {
                    $"/App_Plugins/{StructuredDataPackage.Alias}/Styles/Styles.css"
                }
            });
        }

    }

}