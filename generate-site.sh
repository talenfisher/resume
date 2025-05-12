#!/bin/bash
GENERATE_STATIC_FILES_ONLY=true dotnet run
git checkout gh-pages
cp -r bin/static/* .