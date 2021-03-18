#!/bin/bash
set -e
dotnet restore
#test db
until dotnet ef -s RemixedRecipe -p RemixedRecipe database update; do
>&2 echo "DB starting"
sleep 1
done
>&2 echo "DB up - starting backend"
dotnet watch -p RemixedRecipe 