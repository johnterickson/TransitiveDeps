```
dotnet build ProjA\ProjA.csproj && dir output\net8.0\Microsoft.IdentityModel.Abstractions.dll
```
will show `19,376 Microsoft.IdentityModel.Abstractions.dll`.

```
dotnet build ProjC\ProjC.csproj && dir output\net8.0\Microsoft.IdentityModel.Abstractions.dll
```
will show `18,968 Microsoft.IdentityModel.Abstractions.dll`.

```
git clean -xdf && dotnet build /bl && dir output\net8.0\Microsoft.IdentityModel.Abstractions.dll
```
will randomly show one of the above two.