run:
	docker-compose up

stop:
	docker-compose down

setup:
	sudo rm -rf ./client/.cache
	sudo rm -rf ./client/node_modules
	docker-compose build 
	docker-compose run api dotnet tool restore
	docker-compose run client npm install

# run this after localstack has started
post_setup:
	aws --endpoint-url=http://localhost:4566 s3 mb s3://oneaps-bucket-local

update_db:
	docker-compose run dbupdate dotnet dotnet-ef database update


create_migration:
	docker-compose run dbupdate dotnet dotnet-ef migrations add $(name)


script_db:
	docker-compose run dbupdate dotnet dotnet-ef migrations script
