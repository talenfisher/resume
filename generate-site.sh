#!/bin/bash
GENERATE_STATIC_FILES_ONLY=true dotnet run
git checkout gh-pages
cp -r bin/static/* .
git add .
git commit -m "update static site"
git push origin gh-pages
git checkout main