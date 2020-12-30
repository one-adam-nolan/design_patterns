# Design Pattern Notes

### Why?

Design Patterns exist and there are Pros and Cons to using them in various implementations. The goal of this repository is to create a place where examples and reasons to use a particular pattern are easily accessible.

## Strategy Pattern

Code from the Duck example can be found [here](src/duck.objects).

## Decorator Pattern

Code for the Starbuzz Coffee can be found [here](src/Starbuzz.Domain).



## Code Style
[StyleCop.Analyzers](https://github.com/DotNetAnalyzers/StyleCopAnalyzers) has been added to the project to ensure uniform style between each of the projects. Because not all of the rules need to apply to this project, [a custom configuration](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/Configuration.md) is being used. To avoid having a separate stylecop.json file for each of the projects, a solution file has been added at the root of the src folder. Each of the projects can reference the root item with a `<link>` tag. 

Notes: Currently, Visual Studio adds the file to the `.csproj` with a `<None>` tag. This tag should be changed to `<AdditionalFiles>` like this:

```
<ItemGroup>
    <AdditionalFiles Include="..\stylecop.json">
        <Link>stylecop.json</Link>
    </AdditionalFiles>
</ItemGroup>
```
