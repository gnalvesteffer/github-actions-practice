# GitHub Actions Practice
Practice repository for automating NuGet Package publishing via GitHub Actions.

## Publishing NuGet Package
- When a new commit is pushed to the `main` branch, the [Publish NuGet Package](https://github.com/gnalvesteffer/github-actions-practice/blob/main/.github/workflows/publish-nuget-package.yaml) workflow will automatically build and publish a **prerelease** NuGet package for the [ExampleClassLibrary](https://github.com/gnalvesteffer/github-actions-practice/tree/main/src/GithubActionsPractice/ExampleClassLibrary) project.
- When a Release is published, the workflow will trigger and publish a release version of the NuGet package.

### Versioning
- The package's version string is automatically generated using the latest [tag](https://github.com/gnalvesteffer/github-actions-practice/tags) via [MinVer](https://github.com/adamralph/minver), referenced in the ExampleClassLibrary project.
- Commits pushed to `main` will have its package version suffixed with `-prerelease-0.x`.
- Publishing a new release will trigger a NuGet Package publish as a release version.

#### Creating a Release package
- Create a new release via [this link](https://github.com/gnalvesteffer/github-actions-practice/releases/new) and create a new version tag following the semantic versioning scheme (for example: "0.1.0").
- The `Publish NuGet Package` workflow will trigger when the release is published and will generate a release version of the package.
