## How to build Protobuf into *.dll?
1. Put your *.proto files into some folder
2. Create C# project, for example *Movies.Contracts.csproj*. This project will contain all utilities and insturctions for the build.
3. If you are going to publish artifacts as nuget package then specify in csproj file next directives:
	```    
	<Version>1.0.0</Version>
	<GeneratePackageOnBuild>true</GeneratePackageOnBuild>
	```
4. Via Nuget Package Manager add next dependencies:
	```
	<PackageReference Include="Google.Protobuf" Version="3.25.3" />
	<PackageReference Include="Grpc.Core.Api" Version="2.61.0" />
	<PackageReference Include="Grpc.Tools" Version="2.62.0">
	  <PrivateAssets>all</PrivateAssets>
	  <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
	</PackageReference>
	```
	*Important: IncludeAssets and PrivateAssets for Grpc.Tools need to include all instructions like in example.*

5. Specify path to your proto files which your created in p.1 in the csproj file, for example:
	```
	<ItemGroup>
	  <Protobuf Include="../Protobuf/*.proto" ProtoRoot="../Protobuf/" />
	</ItemGroup>
	```
6. You now ready to build!