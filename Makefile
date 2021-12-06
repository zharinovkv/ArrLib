start:
		sudo dotnet run --project ShowCase/ShowCase.csproj

test:
		sudo dotnet test

build: 
		sudo dotnet build

r:
		sudo dotnet run --no-build --project ShowCase/ShowCase.csproj

format:
		sudo dotnet format ArrLib.sln

