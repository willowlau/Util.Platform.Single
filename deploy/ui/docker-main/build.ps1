docker build -t util.platform.ui.main:v1 .
docker run --name util.platform.ui.main -d -p 16004:80 -e ManifestUrl='/assets/mf.manifest.json' -e IdentityUrl='https://localhost:12086' -e ApiBaseUrl='https://localhost:12086' util.platform.ui.main:v1