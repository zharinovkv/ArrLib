r:
		sudo dotnet run --project ShowCase/ShowCase.csproj

rn:
		sudo dotnet run --no-build --project ShowCase/ShowCase.csproj

b: 
		sudo dotnet build

t:
		sudo dotnet test

f:
		sudo dotnet format ArrLib.sln

c:
		sudo dotnet clean ArrLib.
		
g:
		git push --set-upstream origin master
